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
            bte = new BusTrafficEmulator();
            bte.startData.InStock();
            bte.Reset();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.R: bte.Resume(); break;
                case Keys.P: bte.Pause(); break;
                case Keys.S: bte.Stop(); break;
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
