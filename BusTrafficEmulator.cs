using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandExt4MMPE;
using InterferenceGeneratorNamespace;

namespace MMEP
{
    class BusTrafficEmulator
    {
        internal static uint ONEHOUR = 3600; 
        
        internal StartData startData;
        internal OutputData outputData;
        Random rand;

        internal uint tick;
        internal uint _dTick = 15;
        internal uint ticksToWork = 15 * ONEHOUR;
        internal uint nearestActTick;

        internal List<Bus> listBuses;
        uint totalBusSpawned;
        internal List<Station> listStations;

        internal string act = "";

        private bool justDoIt = true;
        private bool isPause = false;
        private int pauseInterval = 0;

        private Form1 form1;
        internal int PauseInterval
        {
            get { return pauseInterval; }
            set {
                //if (value > 0) pauseInterval = value;
                if (pauseInterval + value > 0) pauseInterval = value;
                else pauseInterval = 0;
            }
        }

        //-------------------------------------------------------
        internal BusTrafficEmulator(Form1 form1)
        {
            startData = new StartData(ref tick, ref _dTick);
            outputData = new OutputData();
            Reset();

            this.form1 = form1;
        }
        internal void Reset()
        {
            tick = 0;
            //nearestActTick = uint.MaxValue;
            rand = new Random();

            listBuses = new List<Bus>();
            totalBusSpawned = 0;

            listStations = new List<Station>();
            char startLetter = 'A'; 
            for(int i = 0; i < 3; ++i)//3 pcs st
            {
                listStations.Add(new Station( startLetter, startData.StSpawnRate ));
                startLetter++;
            }
            outputData.Reset();

            justDoIt = true;
            isPause = false;

            startData.interGen.ChetoNeYasnoe2(startData.interGenCoeffs, 1, (int)((int)(ticksToWork + _dTick) / _dTick));

        }//reset
        internal void MakeTick()
        {
            act = "";
            nearestActTick = uint.MaxValue;//тик+время до справна авто = костаната = нужный тик для акта
            foreach (Station s in listStations)
            {
                foreach(User u in s.usersQueue)
                {
                    u.waitTime += _dTick;
                }
                if (s.spawnAwait >= s.spawnRate)
                {
                    outputData._sumUsersInModel += s.SpawnUsers(startData.U1SpawnCnt, startData.U2SpawnCnt);
                    s.spawnAwait = 0;
                }
                else s.spawnAwait += _dTick;
            }

            if (
                totalBusSpawned < startData.BusMaxCnt &&
                listBuses.Count < startData.BusMaxCnt
                )
            {
                nearestActTick = Math.Min(nearestActTick, tick+Bus.busSpawnRate-Bus.busSpawnAwait);
                if (Bus.busSpawnAwait >= Bus.busSpawnRate)
                {
                    listBuses.Add(new Bus(startData.BusMaxCapacity, 'A', tick));
                    Bus.busSpawnAwait = 0;
                    totalBusSpawned++;
                }
                else Bus.busSpawnAwait += _dTick;
            }

            foreach (Bus b in listBuses)
            {
                if (tick >= b.arriveTick && b.isWorks)
                {
                    uint bСopy_u1 = b.u1;
                    uint bСopy_u2 = b.u2;
                    uint bNew_u1 = 0;
                    uint bNew_u2 = 0;
                    Station stNow = listStations.Find(s => s.name.Equals(b.nextStation));

                    if ( rand.Next(101) > startData.BreakingСhance )
                    {
                        b.Drain();

                        bСopy_u1 = b.u1;
                        bСopy_u2 = b.u2;

                        outputData._sumBusAwait += b.PickUp(stNow, tick, ref bNew_u1, ref bNew_u2);
                    }
                    else
                    {
                        act += "bus broken on " + b.nextStation + " (" + b.u1 + '+' + b.u2 + ')';
                        b.TroubleDrain(stNow);
                        b.isWorks = false;
                        form1.Invoke(
                            (MethodInvoker)delegate
                            {
                                form1.nBusBrokenCnt.Value++;
                            }
                            );
                        continue;
                    }
                    
                    //act += b.nextStation + " " + b.u1 + " " + b.u2;
                    act += b.nextStation + " " + bСopy_u1 + "+" + bNew_u1 + " | " + bСopy_u2 + "+" + bNew_u2;

                    if (b.nextStation >= 'A' + listStations.Count - 1)
                    {
                        b.nextStation = 'A';
                    }
                    else b.nextStation++;

                    switch (b.nextStation)
                    {
                        case 'A': b.arriveTick = tick + startData.T_CA; break;
                        case 'B': b.arriveTick = tick + startData.T_AB; break;
                        case 'C': b.arriveTick = tick + startData.T_BC; break;
                    }
                }//if
            }//forbus

            foreach(Bus b in listBuses) if (b.isWorks) nearestActTick = Math.Min(nearestActTick, b.arriveTick);
            tick += _dTick;
            nearestActTick += _dTick;
        }//tick
        internal float AvgBusLoad()
        {
            float sum = 0;
            listBuses.ForEach( b => sum += (b.u1 + b.u2) );
            if (listBuses.Count > 0) return sum / listBuses.Count;
            return -1;
        }
        //-----------------------------------------
        internal static Point Tween(Point a, Point b, float t)
        {
            return new Point(
                (int)(a.X * (1 - t) + b.X * t),
                (int)(a.Y * (1 - t) + b.Y * t)
                );
        }
        internal static void DrawPointMarker(Graphics g, Pen pen, Point p)
        {
            g.DrawLine(pen, p.X, p.Y - 10, p.X, p.Y + 10);//vert
            g.DrawLine(pen, p.X - 10, p.Y, p.X + 10, p.Y);//hor
        }
        //----------------------------------------
        internal async void SemiThreadMethod()
        {
            //startData.interGen.ChetoNeYasnoe2(startData.interGenCoeffs, 1, (int)((int)(ticksToWork + _dTick) /_dTick) );
            while (justDoIt && tick < ticksToWork)
            {
                if (isPause)
                {
                    await Task.Delay(100);
                    continue;
                }
                
                if (null != form1)
                {

                    form1.Invoke(
                            (MethodInvoker)delegate
                            {
                                form1.dataGridView1.Rows.Add(
                                    tick,
                                    listStations[0].usersQueue.Count,
                                    listStations[1].usersQueue.Count,
                                    listStations[2].usersQueue.Count,
                                    act,
                                    AvgBusLoad(),
                                    //nearestActTick - tick//
                                    nearestActTick//
                                );
                            }
                        );
                    //-----
                    int value = 0;
                    ProgressBar[] pbArr = { form1.progressBarA, form1.progressBarB, form1.progressBarC };
                    NumericUpDown[] nudArr = { form1.nNearBarA, form1.nNearBarB, form1.nNearBarC };

                    for(int i = 0; i < 3; ++i)
                    {
                        //nudArr[i].Value = listStations[i].usersQueue.Count;

                        if (listStations[i].usersQueue.Count < pbArr[i].Maximum)
                        {
                            value = listStations[i].usersQueue.Count;
                        }
                        else value = pbArr[i].Maximum;

                        form1.Invoke(
                                (MethodInvoker)delegate
                                {
                                    pbArr[i].Value = value;
                                    nudArr[i].Value = listStations[i].usersQueue.Count;
                                }
                            );
                    }
                    //-----
                    form1.Invoke(
                        (MethodInvoker)delegate
                        {
                            form1.nAvgAwaitTime.Value = (decimal)outputData.CalcAvgAwaitMinutes();
                            form1.pbModelProgress.Value = (int)tick;

                            Graphics g = Graphics.FromHwnd(form1.Handle);
                            Color cl = Color.FromArgb(50, 50, 50);
                            Pen pen = new Pen(cl);
                            SolidBrush sb = new SolidBrush(form1.BackColor);
                            SolidBrush sbBlack = new SolidBrush(cl);

                            Point a = new Point(550, 150);//left  A
                            Point b = new Point(700, 150);//right B
                            Point c = new Point(625, 250);//down  C

                            g.FillRectangle(sb, a.X - 20, a.Y - 20, b.X - a.X + 45, c.Y - a.Y + 40);

                            g.DrawLine(pen, a, b);
                            g.DrawLine(pen, b, c);
                            g.DrawLine(pen, c, a);

                            foreach (Bus bus in listBuses)
                            {
                                if (!bus.isWorks) continue;

                                Point p = new Point();
                                float t = (float)(tick - bus.startTick) / (bus.arriveTick - bus.startTick);
                                switch (bus.nextStation)
                                {
                                    case 'A':
                                        {
                                            p = Tween(c, a, t);
                                        }
                                        break;
                                    case 'B':
                                        {
                                            p = Tween(a, b, t);                                        
                                        }
                                        break;
                                    case 'C':
                                        {
                                            p = Tween(b, c, t);
                                        }
                                        break;
                                }//sw
                                DrawPointMarker(g, pen, p);

                                p.X += 5;
                                p.Y += 5;

                                g.DrawString((bus.u1 + bus.u2).ToString(), form1.Font, sbBlack, p);
                            }//for

                        }//delegate
                        );
                }//if Form
                MakeTick();
                await Task.Delay(pauseInterval);
            }
        }
        internal void Pause() => isPause = true;
        internal void Resume() => isPause = false;
        internal void Stop() => justDoIt = false;
    }//sim
        
    class Station
    {
        internal char name;
        internal Queue<User> usersQueue;
        internal uint spawnRate;
        internal uint spawnAwait;
        internal Station(char name, uint spawnRate)
        {
            this.spawnRate = spawnRate;
            this.name = name;
            usersQueue = new Queue<User>();
        }
        internal uint SpawnUsers(uint u1cnt, uint u2cnt)
        {
            List<int> temp = new List<int>();
            for(int i = 0; i < u1cnt; ++i)
            {
                temp.Add(1);
            }
            for (int i = 0; i < u2cnt; ++i)
            {
                temp.Add(2);
            }
            temp.Shuffle();
            foreach(uint u in temp)
            {
                User ou = new User(u);
                usersQueue.Enqueue(ou);
                //Console.WriteLine(u);//deb
            }
            return (uint)temp.Count;
        }//spawn

    }
    class Bus
    {
        static internal uint busSpawnRate = 15*60;
        static internal uint busSpawnAwait = 0;

        internal bool isWorks = true;
        internal uint maxCapacity;
        internal uint u1;
        internal uint u2;
        internal uint startTick;
        internal uint arriveTick;
        internal char nextStation;
        internal Bus(uint maxCapacity, char nextStation, uint arriveTick)
        {
            this.maxCapacity = maxCapacity;
            this.nextStation = nextStation;
            this.arriveTick = arriveTick;
        }
        internal uint Drain()
        {
            uint temp = u1;

            u1 = 0;
            u1 = u2;
            u2 = 0;

            return temp;
        }
        internal uint TroubleDrain(Station toStation)
        {
            uint temp = Drain();
            for (int i = 0; i < u1; ++i) toStation.usersQueue.Enqueue(new User(1));
            return temp;
        }
        internal uint PickUp(Station st, uint startTick, ref uint newU1, ref uint newU2)
        {
            if (null == st) return 0;
            uint tempWaitSum = 0;
            this.startTick = startTick;

            while(u1 + u2 < maxCapacity && st.usersQueue.Count > 0)
            {
                User u = st.usersQueue.Dequeue();
                if (1 == u.stationtCntNeed) { u1++; newU1++; }
                else if (2 == u.stationtCntNeed) { u2++; newU2++; }
                tempWaitSum += u.waitTime;
            }
            return tempWaitSum;
        }
    }
    class User
    {
        internal uint stationtCntNeed;
        internal uint waitTime;
        internal User(uint stationtCntNeed)
        {
            this.stationtCntNeed = stationtCntNeed;
        }
    }
    class StartData
    {
        internal bool determ = true;
        Random rand = new Random();
        internal InterferenceGenerator interGen = new InterferenceGenerator();
        internal List<double> interGenCoeffs = new List<double> {
                0.309809101184247,
                0.114186070530348,
                0.042066228034606,
                0.017932178770123,
            };
        uint _sdTick;
        uint _sdDTick;
        //-----
        private uint _busMaxCnt;
        internal uint BusMaxCnt
        {
            get
            {
                if (determ) return _busMaxCnt;
                return _busMaxCnt;
            }
            set { _busMaxCnt = value; }
        }
        //-----
        private decimal _breakingСhance;
        internal decimal BreakingСhance
        {
            get
            {
                if (determ) return _breakingСhance;
                return (decimal)( interGen.Values[(int)(_sdTick / _sdDTick)] );
            }
            set { _breakingСhance = value; }
        }
        //-----
        private uint _busMaxCapacity;
        internal uint BusMaxCapacity
        {
            get
            {
                if (determ) return _busMaxCapacity;
                return _busMaxCapacity;
            }
            set { _busMaxCapacity = value;  }
        }
        //------
        private uint _tAB;//normal dist
        internal uint T_AB
        {
            get
            {
                if (determ) return _tAB;
                return 60*(uint)rand.NormalDistributionFunction(2, 20);
            }
            set { _tAB = value; }
        }
        //---------------------------------------------------------------------------
        private uint _tBC;
        internal uint T_BC//normal dist
        {
            get
            {
                if (determ) return _tBC;
                return 60*(uint)rand.NormalDistributionFunction(3, 30);
            }
            set { _tBC = value; }
        }
        //---------------------------------------------------------------------
        private uint _tCA;
        internal uint T_CA//normal dist
        {
            get
            {
                if (determ) return _tCA;
                return 60*(uint)rand.NormalDistributionFunction(5, 40);
            }
            set { _tCA = value; }
        }
        //--------------------------------------------------------------------------
        private uint _stSpawnRate;
        internal uint StSpawnRate
        {
            get
            {
                if (determ) return _stSpawnRate;
                return _stSpawnRate;
            }
            set { _stSpawnRate = value; }
        }
        //---------------------------------------------------------------------
        private uint _u1SpawnCnt;
        internal uint U1SpawnCnt//exp dist
        {
            get
            {
                if (determ) return _u1SpawnCnt;
                return (uint)rand.ExponentialDistributionFunction(0.1);
            }
            set { _u1SpawnCnt = value; }
        }
        //----------------------------------------------------------------------------
        private uint _u2SpawnCnt;
        internal uint U2SpawnCnt//exp dist
        {
            get
            {
                if (determ) return _u2SpawnCnt;
                return (uint)rand.ExponentialDistributionFunction(0.1);
            }
            set { _u2SpawnCnt = value; }
        }
        //--------------------------------------------------------------------------
        internal StartData(ref uint sdTick, ref uint sdDTick)
        {
            _sdTick = sdTick;
            _sdDTick = sdDTick;
        }
        internal void InStock()
        {
            _stSpawnRate = 5 * 60;
            _tAB = 20 * 60;
            _tBC = 30 * 60;
            _tCA = 40 * 60;
            _u1SpawnCnt = 10;
            _u2SpawnCnt = 10;
            _busMaxCnt = 10;
            _busMaxCapacity = 100;
            _breakingСhance = 1;
        }
        
    }//startData
    class OutputData
    {
        internal uint _sumBusAwait;
        internal uint _sumUsersInModel;
        internal void Reset()
        {
            _sumBusAwait = 0;
            _sumUsersInModel = 0;
        }
        internal float CalcAvgAwaitMinutes()
        {
            if(_sumUsersInModel > 0) return _sumBusAwait / _sumUsersInModel / 60;
            return -1;
        }
    }
}//ns
