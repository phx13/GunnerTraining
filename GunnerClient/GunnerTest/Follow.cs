using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GunnerClient.GunnerTest
{
    public partial class Follow : Form
    {
        #region 初始化
        public Follow()
        {
            InitializeComponent();
            for (int i = startPoint1.X + (endPoint1.X - startPoint1.X) / 4; i < endPoint1.X - (endPoint1.X - startPoint1.X) / 4; i++)
            {
                for (int j = startPoint1.Y + (endPoint1.Y - startPoint1.Y) / 4; j < endPoint1.Y - (endPoint1.Y - startPoint1.Y) / 4; j++)
                {
                    initList.Add(new Point(i, j));
                }
            }
        }
        #endregion

        #region 变量定义
        private bool startFollow = false;
        Point startPoint1 = new Point(200, 100);
        Point endPoint1 = new Point(300, 160);
        List<Point> initList = new List<Point>();
        List<Point> pointList = new List<Point>();
        private float counter;
        private float followTime;
        private int xOffset = 4;
        public int XOffset
        {
            get
            {
                return xOffset;
            }
            set
            {
                xOffset = value;
            }
        }
        private bool isRuin;
        #endregion

        #region 定时器
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            for (int i = endPoint1.X - (endPoint1.X - startPoint1.X) / 4; i < (endPoint1.X - (endPoint1.X - startPoint1.X) / 4) + xOffset; i++)
            {
                for (int j = startPoint1.Y + (endPoint1.Y - startPoint1.Y) / 4; j < endPoint1.Y - (endPoint1.Y - startPoint1.Y) / 4; j++)
                {
                    initList.Add(new Point(i, j));
                    initList.RemoveAt(0);
                }
            }
            startPoint1.Offset(xOffset, 0);
            endPoint1.Offset(xOffset, 0);

            if (pointList.Count>0)
            {
                if (initList.Contains(pointList[pointList.Count - 1]))
                {
                    followTime += .1f;
                    isRuin = true;
                }
                else
                {
                    followTime = 0;
                    isRuin = false;
                }
            }
            counter += .1f;
            timeLabel.Text = "计时：" + Math.Floor(counter);
        }
        #endregion

        #region 按键
        private void Follow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                startPoint1 = new Point(200, 100);
                endPoint1 = new Point(300, 160);
                for (int i = startPoint1.X + (endPoint1.X - startPoint1.X) / 4; i < endPoint1.X - (endPoint1.X - startPoint1.X) / 4; i++)
                {
                    for (int j = startPoint1.Y + (endPoint1.Y - startPoint1.Y) / 4; j < endPoint1.Y - (endPoint1.Y - startPoint1.Y) / 4; j++)
                    {
                        initList.Add(new Point(i, j));
                    }
                }
                startFollow = true;
                timeLabel.Text = "计时：0";
                scoreLabel.Text = "";
                counter = 0;
                Timer.Enabled = true;
                Timer.Start();
            }
            else if (e.KeyCode == Keys.E)
            {
                Graphics hitPointGra = this.CreateGraphics();
                Brush hitPoint = new SolidBrush(Color.Red);
                hitPointGra.FillEllipse(hitPoint, Control.MousePosition.X-115, Control.MousePosition.Y-73, 7f, 7f);

                if (isRuin&&followTime>=2)
                {
                    scoreLabel.Text = "跟踪了" + followTime.ToString() + "秒\n" + "命中目标\n"+"成绩合格";
                }
                else if(isRuin&&followTime<2)
                {
                    scoreLabel.Text = "跟踪了" + followTime.ToString() + "秒\n" + "命中目标\n" + "成绩不合格";
                }
                else
                {
                    scoreLabel.Text = "跟踪了" + followTime.ToString() + "秒\n" + "没有命中目标\n" + "成绩不合格";
                }
                MySQLiteClass.Getmysqlcom("insert into ConScore(Number,平稳跟踪目标,训练时间) values('" + MainWindow.number + "','" + scoreLabel.Text + "','" + DateTime.Now.ToString() + "')");
                startFollow = false;
                Timer.Dispose();
                Timer.Enabled = false;
                initList.Clear();
                pointList.Clear();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                GC.Collect();
                this.Dispose();
            }
        }
        #endregion

        #region 绘画
        private void Follow_Paint(object sender, PaintEventArgs e)
        {
            Graphics initGra = this.CreateGraphics();
            Brush initBrush = new SolidBrush(Color.White);
            initGra.FillRectangle(initBrush, startPoint1.X, startPoint1.Y, endPoint1.X - startPoint1.X, endPoint1.Y - startPoint1.Y);
        }
        #endregion

        #region 跟踪
        private void Follow_MouseMove(object sender, MouseEventArgs e)
        {
            if (startFollow == true)
            {
                pointList.Add(e.Location);
            }
        }
        #endregion
    }
}
