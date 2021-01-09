using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace GunnerClient.GunnerTest
{
    public partial class Draw : Form
    {
        #region 初始化
        public Draw()
        {
            InitializeComponent();
            for (int i = startPoint1.X; i < endPoint1.X; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    initList.Add(new Point(i, startPoint1.Y+j));
                    initList.Add(new Point(i, endPoint1.Y+j));
                    initList.Add(new Point(i, startPoint1.Y + i * 2 / 3+j));
                    initList.Add(new Point(i, endPoint1.Y - i * 2 / 3+j));
                }
            }
            for (int j = startPoint1.Y; j < endPoint1.Y; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    initList.Add(new Point(startPoint1.X+i, j));
                    initList.Add(new Point(endPoint1.X+i, j));
                }
            }
        }
        #endregion
        
        #region 变量定义
        private bool startDraw = false;
        List<Point> pointList = new List<Point>();
        List<Point> initList = new List<Point>();
        List<Point> compareList = new List<Point>();

        Point startPoint1 = new Point(400, 300);
        Point endPoint1 = new Point(800, 600);
        Point startPoint2 = new Point(400, 600);
        Point endPoint2 = new Point(800, 300);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetCursorPos(int x,int y);

        int counter;
        #endregion

        #region 绘画
        private void Draw_Paint(object sender, PaintEventArgs e)
        {
            Graphics initGra = this.CreateGraphics();
            Pen initPen = new Pen(Color.White, 5);
            initGra.DrawRectangle(initPen, startPoint1.X, startPoint1.Y, endPoint1.X-startPoint1.X, endPoint1.Y-startPoint1.Y);
            initGra.DrawLine(initPen, startPoint1, endPoint1);
            initGra.DrawLine(initPen, startPoint2, endPoint2);
        }
        #endregion

        #region 按键
        private void Draw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.S)
            {
                this.Refresh();
                SetCursorPos(startPoint1.X+115,startPoint1.Y+73);
                startDraw = true;
                timeLabel.Text = "计时：0";
                scoreLabel.Text = "";
                counter = 0;
                Timer.Enabled = true;
                Timer.Start();
            }
            else if (e.KeyCode==Keys.E)
            {
                startDraw = false;
                compareList = initList.Intersect(pointList).ToList();
                double res = Math.Round((double)compareList.Count * 5 / initList.Count, 2);
                if (counter<25&&(res*100)>=60)
                {
                    scoreLabel.Text = "相似度：" + (res * 100).ToString() + "%\n"+"成绩：优秀";                    
                }
                else if (counter < 30 && (res * 100) >= 45&&(res*100)<60)
                {
                    scoreLabel.Text = "相似度：" + (res * 100).ToString() + "%\n" + "成绩：良好";
                }
                else if (counter < 35 && (res * 100) >= 30&&(res*100)<45)
                {
                    scoreLabel.Text = "相似度：" + (res * 100).ToString() + "%\n" + "成绩：合格";
                }
                else
                {
                    scoreLabel.Text = "相似度：" + (res * 100).ToString() + "%\n" + "成绩：不及格";
                }
                MySQLiteClass.Getmysqlcom("insert into ConScore(Number,描绘信封靶,训练时间) values('" + MainWindow.number + "','" + scoreLabel.Text + "','" + DateTime.Now.ToString() + "')");                
                Timer.Dispose();
                Timer.Enabled = false;
                pointList.Clear();
            }
            else if (e.KeyCode==Keys.Escape)
            {
                GC.Collect();
                this.Dispose();
            }
        }
        #endregion

        #region 移动
        void Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startDraw==true)
            {
                Graphics paintGra = this.CreateGraphics();
                paintGra.SmoothingMode = SmoothingMode.AntiAlias;
                pointList.Add(e.Location);

                
                
                if (pointList.Count>=2)
                {
                    using (Pen drawPen = new Pen(Color.Red, 4))
                    {
                        drawPen.StartCap = LineCap.Round;
                        drawPen.EndCap = LineCap.Round;
                        drawPen.LineJoin = LineJoin.Round;
                        paintGra.DrawCurve(drawPen, pointList.ToArray());

                    }
                }
            }
        }
        #endregion

        #region 定时器
        private void Timer_Tick(object sender, EventArgs e)
        {
            counter++;
            timeLabel.Text = "计时：" + counter;
        }
        #endregion
    }
}
