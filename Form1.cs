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
        //private Graphics _g;
        //private Pen _pen;
        BusTrafficEmulator bte;
        public Form1()
        {
            InitializeComponent();
            bte = new BusTrafficEmulator(this.dataGridView1);
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
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.R)
            {
                bte.Reset();
                dataGridView1.Rows.Clear();
                StartDataGUIEnabled(true);
                return;
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
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    _g = CreateGraphics();
        //    Color c = Color.FromArgb(50, 50, 50);
        //    _pen = new Pen(c, 5);

        //    Point p1 = new Point(0, 0);
        //    Point p2 = new Point(100, 100);
        //    _g.DrawLine(_pen, p1, p2);

        //    _g.Dispose();
        //}
    }
}
