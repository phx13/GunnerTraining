﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GunnerClient
{
    public class MyPanel:Panel
    {
        public MyPanel()
        {
            this.DoubleBuffered = true;
            SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.DoubleBuffer, true);
            UpdateStyles();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.ExStyle |= 0 * 02000000;
                return p;
            }
        }
    }
}
