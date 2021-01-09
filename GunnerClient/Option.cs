using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GunnerClient
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
            Timer.Tick += new EventHandler(Timer_Tick);
            base.Opacity = 0;
            Timer.Start();
        }

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0 * 0014)
        //        return;
        //    base.WndProc(ref m);
        //}

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.ExStyle |= 0 * 02000000;
                return p;
            }
        }

        private void Option_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 1)
            {
                Timer.Stop();
            }
            else
            {
                base.Opacity += 0.8;
            }
        }
    }
}
