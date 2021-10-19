using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMEP
{
    public partial class Form1 : Form
    {
        BusTrafficEmulator bte;
        public Form1()
        {
            InitializeComponent();
            //bte = new BusTrafficEmulator(this.dataGridView1);
            bte = new BusTrafficEmulator(this);
            bte.startData.InStock();
            bte.Reset();

            FormReset();
        }
        private void StartDataGUIEnabled(bool isEnabled)
        {
            nStSpawnRate.Enabled = isEnabled;
            nTAB.Enabled = isEnabled;
            nTBC.Enabled = isEnabled;
            nTCA.Enabled = isEnabled;
            nU1SpawnCnt.Enabled = isEnabled;
            nU2SpawnCnt.Enabled = isEnabled;
            nBusMaxCnt.Enabled = isEnabled;
            nBusMaxCapacity.Enabled = isEnabled;
            nBreackingChance.Enabled = isEnabled;
        }
        private void StartDataFromGUIToModel()
        {
            bte.startData.StSpawnRate = (uint)nStSpawnRate.Value;
            bte.startData.T_AB = (uint)nTAB.Value;
            bte.startData.T_BC = (uint)nTBC.Value;
            bte.startData.T_CA = (uint)nTCA.Value;
            bte.startData.U1SpawnCnt = (uint)nU1SpawnCnt.Value;
            bte.startData.U2SpawnCnt = (uint)nU2SpawnCnt.Value;
            bte.startData.BusMaxCnt = (uint)nBusMaxCnt.Value;
            bte.startData.BusMaxCapacity= (uint)nBusMaxCapacity.Value;
            bte.startData.BreakingСhance = (uint)nBreackingChance.Value;
        }
        private void FormReset()
        {
            nStSpawnRate.Value = bte.startData.StSpawnRate;
            nTAB.Value = bte.startData.T_AB;
            nTBC.Value = bte.startData.T_BC;
            nTCA.Value = bte.startData.T_CA;
            nU1SpawnCnt.Value = bte.startData.U1SpawnCnt;
            nU2SpawnCnt.Value = bte.startData.U2SpawnCnt;
            nBusMaxCnt.Value = bte.startData.BusMaxCnt;
            nBusMaxCapacity.Value = bte.startData.BusMaxCapacity;
            nBreackingChance.Value = bte.startData.BreakingСhance;

            progressBarA.Value = 0;
            progressBarB.Value = 0;
            progressBarC.Value = 0;

            nAvgAwaitTime.Value = 0;
            nDelay.Value = bte.PauseInterval;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.R)
            {
                bte.Reset();
                dataGridView1.Rows.Clear();
                StartDataGUIEnabled(true);
                FormReset();
                return;
            }

            if (e.Alt && e.KeyCode == Keys.S)
            {
                bte.startData.InStock();
                FormReset();
            }

            switch (e.KeyCode)
            {
                case Keys.Oemplus: bte.PauseInterval += 250; break;
                case Keys.OemMinus: bte.PauseInterval -= 250; break;
                case Keys.R: bte.Resume(); break;
                case Keys.P: bte.Pause(); break;
                case Keys.S: bte.Stop(); break;
                case Keys.Z:
                    {
                        StartDataFromGUIToModel();

                        Task.Factory.StartNew(
                        () => bte.SemiThreadMethod(15 * BusTrafficEmulator.ONEHOUR)
                        );

                        StartDataGUIEnabled(false);
                    }
                    break;
            }
            nDelay.Value = bte.PauseInterval;
        }//KeyUp

        internal static Point Tween(Point a,  Point b, float t)
        {
            return new Point(
                (int)(a.X * (1 - t) + b.X * t),
                (int)(a.Y * (1 - t) + b.Y * t)
                );
        }
        internal static void DrawPointMarker(Graphics g, Pen pen, PointF p)
        {
            g.DrawLine(pen, p.X, p.Y - 10, p.X, p.Y + 10);//vert
            g.DrawLine(pen, p.X - 10, p.Y, p.X + 10, p.Y);//hor
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color cl = Color.FromArgb(50, 50, 50);
            Pen pen = new Pen(cl, 3);

            Point a = new Point(550, 150);//left  A
            Point b = new Point(700, 150);//right B
            Point c = new Point(625, 250);//down  C

            e.Graphics.DrawLine(pen, a, b);
            e.Graphics.DrawLine(pen, b, c);
            e.Graphics.DrawLine(pen, c, a);

        }//onPaint
    }
}
