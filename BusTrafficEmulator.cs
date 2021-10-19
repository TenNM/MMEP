using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMEP
{
    class BusTrafficEmulator
    {
        internal static uint ONEHOUR = 3600; 
        
        internal StartData startData;
        internal OutputData outputData;
        Random rand;

        uint tick;
        internal List<Bus> listBuses;
        uint totalBusSpawned;
        internal List<Station> listStations;

        internal string act = "";

        private bool justDoIt = true;
        private bool isPause = false;
        private int pauseInterval = 1000;

        private object dataOutput;
        internal int PauseInterval
        {
            get { return pauseInterval; }
            set {
                //if (value > 0) pauseInterval = value;
                if (pauseInterval + value > 0) pauseInterval = value;
                else pauseInterval = 0;
            }
        }

        internal BusTrafficEmulator(object dataOutput)
        {
            startData = new StartData();
            outputData = new OutputData();
            Reset();

            this.dataOutput = dataOutput;
        }
        internal void Reset()
        {
            tick = 0;
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
        }//reset
        internal void MakeTick()
        {
            act = "";
            foreach (Station s in listStations)
            {
                foreach(User u in s.usersQueue)
                {
                    u.waitTime++;
                }
                if (s.spawnAwait >= s.spawnRate)
                {
                    //s.SpawnUsers(startData.U1SpawnCnt, startData.U2SpawnCnt);
                    outputData._sumUsersInModel += s.SpawnUsers(startData.U1SpawnCnt, startData.U2SpawnCnt);
                    s.spawnAwait = 0;
                }
                else s.spawnAwait++;
            }

            //if (listBuses.Count < startData.BusMaxCnt)//!!!!!!!
            if (
                totalBusSpawned < startData.BusMaxCnt &&
                listBuses.Count < startData.BusMaxCnt
                )
            {
                if (Bus.busSpawnAwait >= Bus.busSpawnRate)
                {
                    listBuses.Add(new Bus(startData.BusMaxCapacity, 'A', tick));
                    Bus.busSpawnAwait = 0;
                    totalBusSpawned++;
                }
                else Bus.busSpawnAwait++;
            }

            foreach (Bus b in listBuses)
            {
                if (tick >= b.arriveTick && b.isWorks)
                {
                    Station stNow = listStations.Find(s => s.name.Equals(b.nextStation));

                    if ( rand.Next(101) > startData.BreakingСhance )
                    {
                        b.Drain();
                        outputData._sumBusAwait += b.PickUp(stNow);
                    }
                    else
                    {
                        act += "bus broken on " + b.nextStation + " (" + b.u1 + ' ' + b.u2 + ')';
                        b.TroubleDrain(stNow);
                        b.isWorks = false;                      
                        continue;
                    }
                    
                    act += b.nextStation + " " + b.u1 + " " + b.u2;

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
            tick++;
        }//tick
        internal float AvgBusLoad()
        {
            float sum = 0;
            listBuses.ForEach( b => sum += (b.u1 + b.u2) );
            if (listBuses.Count > 0) return sum / listBuses.Count;
            return -1;
        }
        //-------------------------------
        internal async void SemiThreadMethod(uint ticksToWork)//what about reset justDoIt?
        {
            while (justDoIt && tick < ticksToWork)
            {
                if (isPause)
                {
                    await Task.Delay(100);
                    continue;
                }
                //Console.WriteLine(
                //    "t {0, -10}a {1, -10}b {2, -10}c {3, -10} {4, -10}avgBusLoad {5, -10}",
                //    tick,
                //    listStations[0].usersQueue.Count,
                //    listStations[1].usersQueue.Count,
                //    listStations[2].usersQueue.Count,
                //    act,
                //    AvgBusLoad()
                //);
                //Form1.data
                //if(dataOutput is DataGridView)
                //{
                //    DataGridView d = dataOutput as DataGridView;
                //    if (null == d) continue;
                //    d.Invoke(
                //            (MethodInvoker)delegate {
                //                d.Rows.Add(
                //                    tick,
                //                    listStations[0].usersQueue.Count,
                //                    listStations[1].usersQueue.Count,
                //                    listStations[2].usersQueue.Count,
                //                    act,
                //                    AvgBusLoad()
                //                );
                //            }
                //        );

                //}
                if (dataOutput is Form1)
                {
                    Form1 f = dataOutput as Form1;
                    if (null == f) continue;

                    f.dataGridView1.Invoke(
                            (MethodInvoker)delegate
                            {
                                f.dataGridView1.Rows.Add(
                                    tick,
                                    listStations[0].usersQueue.Count,
                                    listStations[1].usersQueue.Count,
                                    listStations[2].usersQueue.Count,
                                    act,
                                    AvgBusLoad()
                                );
                            }
                        );

                    int value = 0;
                    ProgressBar[] pbArr = { f.progressBarA, f.progressBarB, f.progressBarC };

                    for(int i = 0; i < listStations.Count; ++i)
                    {
                        if (listStations[i].usersQueue.Count < 100)
                        {
                            value = listStations[i].usersQueue.Count;
                        }
                        else value = 100;
                        f.progressBarA.Invoke(
                                (MethodInvoker)delegate
                                {
                                    pbArr[i].Value = value;
                                }
                            );
                    }
                    //-----
                    f.nAvgAwaitTime.Invoke(
                            (MethodInvoker)delegate
                            {
                                f.nAvgAwaitTime.Value = (decimal)outputData.CalcAvgAwaitMinutes();
                            }
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
        static internal uint busSpawnRate = 16*60;
        static internal uint busSpawnAwait = 0;

        internal bool isWorks = true;
        internal uint maxCapacity;
        internal uint u1;
        internal uint u2;
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
        internal uint PickUp(Station st)
        {
            if (null == st) return 0;
            uint tempWaitSum = 0;

            while(u1 + u2 < maxCapacity && st.usersQueue.Count > 0)
            {
                User u = st.usersQueue.Dequeue();
                if (1 == u.stationtCntNeed) u1++;
                else if (2 == u.stationtCntNeed) u2++;
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
        private uint _breakingСhance;
        internal uint BreakingСhance
        {
            get
            {
                if (determ) return _breakingСhance;
                return _breakingСhance;
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
        private uint _tAB;
        internal uint T_AB
        {
            get
            {
                if (determ) return _tAB;
                return _tAB;
            }
            set { _tAB = value; }
        }
        //-----
        private uint _tBC;
        internal uint T_BC
        {
            get
            {
                if (determ) return _tBC;
                return _tBC;
            }
            set { _tBC = value; }
        }
        //------
        private uint _tCA;
        internal uint T_CA
        {
            get
            {
                if (determ) return _tCA;
                return _tCA;
            }
            set { _tCA = value; }
        }
        //-----
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
        //-----
        private uint _u1SpawnCnt;
        internal uint U1SpawnCnt
        {
            get
            {
                if (determ) return _u1SpawnCnt;
                return _u1SpawnCnt;
            }
            set { _u1SpawnCnt = value; }
        }
        //-----
        private uint _u2SpawnCnt;
        internal uint U2SpawnCnt
        {
            get
            {
                if (determ) return _u2SpawnCnt;
                return _u2SpawnCnt;
            }
            set { _u2SpawnCnt = value; }
        }
        //-----
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
