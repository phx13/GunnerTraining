using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace GunnerClient
{
    public partial class Test : Form, IDisposable
    {
        public Test()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.DoubleBuffer, true);
            SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw, true);
            MyUDPSocket.Init();
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

        private void Test1_Load(object sender, EventArgs e)
        {
            t1ttL.Location = new Point(300, 50);
            t2ttL.Location = new Point(310, 50);
            t3ttL.Location = new Point(310, 50);

            CurrentScoreLabel.Parent = ScoreRichTextBox;
            CurrentScoreLabel.Location = new Point(85, 800);
            ScoreRichTextBox.Parent = Gamepanel;
            ScoreRichTextBox.Location = new Point(1292, 0);

            t1t1L.Location = new Point(170, 45);
            t1t2L.Location = new Point(150, 45);
            t1t3L.Location = new Point(180, 45);
            t1t4L.Location = new Point(180, 45);
            t1t5L.Location = new Point(160, 45);

            t2t1L.Location = new Point(130, 45);
            t2t2L.Location = new Point(130, 45);
            t2t3L.Location = new Point(130, 45);
            t2t4L.Location = new Point(130, 45);
            t2t5L.Location = new Point(150, 45);
            t2t6L.Location = new Point(130, 45);

            t3t1L.Location = new Point(150, 45);
            FileSystemWatcher fWatcher = new FileSystemWatcher();
            fWatcher.Path = path + "\\";
            fWatcher.Filter = "log.txt";
            fWatcher.NotifyFilter = NotifyFilters.Size;
            fWatcher.Changed += new FileSystemEventHandler(Changed);
            fWatcher.EnableRaisingEvents = true;
            MyUDPSocket.Receive();
        }

        private void Test1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (Gamepanel.Visible == true)
                {
                    if (myExe != null)
                    {
                        myExe.Stop();
                    }
                    ScoreRichTextBox.Text = "";
                    CurrentScoreLabel.Text = "当前分数：5";
                    Gamepanel.Controls.Clear();
                    Gamepanel.Visible = false;
                    Startbutton.Visible = false;
                }
                else
                {
                    t1tt.Visible = false;
                    t2tt.Visible = false;

                    t1t1.Visible = false;
                    t1t2.Visible = false;
                    t1t3.Visible = false;
                    t1t4.Visible = false;
                    t1t5.Visible = false;

                    t2t1.Visible = false;
                    t2t2.Visible = false;
                    t2t3.Visible = false;
                    t2t4.Visible = false;
                    t2t5.Visible = false;
                    t2t6.Visible = false;

                    t3tt.Visible = false;
                    t3t1.Visible = false;
                    this.Close();                
                }
            }
        }

        #region Mousehover
        private void t1t1_MouseEnter(object sender, EventArgs e)
        {
            t1t1L.ForeColor = Color.OrangeRed;
        }

        private void t1t1_MouseLeave(object sender, EventArgs e)
        {
            t1t1L.ForeColor = Color.White;
        }

        private void t1t2_MouseEnter(object sender, EventArgs e)
        {
            t1t2L.ForeColor = Color.OrangeRed;
        }

        private void t1t2_MouseLeave(object sender, EventArgs e)
        {
            t1t2L.ForeColor = Color.White;
        }

        private void t1t3_MouseEnter(object sender, EventArgs e)
        {
            t1t3L.ForeColor = Color.OrangeRed;
        }

        private void t1t3_MouseLeave(object sender, EventArgs e)
        {
            t1t3L.ForeColor = Color.White;
        }

        private void t1t4_MouseEnter(object sender, EventArgs e)
        {
            t1t4L.ForeColor = Color.OrangeRed;
        }

        private void t1t4_MouseLeave(object sender, EventArgs e)
        {
            t1t4L.ForeColor = Color.White;
        }

        private void t1t5_MouseEnter(object sender, EventArgs e)
        {
            t1t5L.ForeColor = Color.OrangeRed;
        }

        private void t1t5_MouseLeave(object sender, EventArgs e)
        {
            t1t5L.ForeColor = Color.White;
        }

        private void t2t1_MouseEnter(object sender, EventArgs e)
        {
            t2t1L.ForeColor = Color.OrangeRed;
        }

        private void t2t1_MouseLeave(object sender, EventArgs e)
        {
            t2t1L.ForeColor = Color.White;
        }

        private void t2t2_MouseEnter(object sender, EventArgs e)
        {
            t2t2L.ForeColor = Color.OrangeRed;
        }

        private void t2t2_MouseLeave(object sender, EventArgs e)
        {
            t2t2L.ForeColor = Color.White;
        }

        private void t2t3_MouseEnter(object sender, EventArgs e)
        {
            t2t3L.ForeColor = Color.OrangeRed;
        }

        private void t2t3_MouseLeave(object sender, EventArgs e)
        {
            t2t3L.ForeColor = Color.White;
        }

        private void t2t4_MouseEnter(object sender, EventArgs e)
        {
            t2t4L.ForeColor = Color.OrangeRed;
        }

        private void t2t4_MouseLeave(object sender, EventArgs e)
        {
            t2t4L.ForeColor = Color.White;
        }

        private void t2t5_MouseEnter(object sender, EventArgs e)
        {
            t2t5L.ForeColor = Color.OrangeRed;
        }

        private void t2t5_MouseLeave(object sender, EventArgs e)
        {
            t2t5L.ForeColor = Color.White;
        }

        private void t2t6_MouseEnter(object sender, EventArgs e)
        {
            t2t6L.ForeColor = Color.OrangeRed;
        }

        private void t2t6_MouseLeave(object sender, EventArgs e)
        {
            t2t6L.ForeColor = Color.White;
        }
        private void t3t1_MouseEnter(object sender, EventArgs e)
        {
            t3t1L.ForeColor = Color.OrangeRed;
        }

        private void t3t1_MouseLeave(object sender, EventArgs e)
        {
            t3t1L.ForeColor = Color.White;
        }
        #endregion

        #region Click
        MyEXEClass myExe = null;
        Option option = new Option();

        public void OpenOption(string infoArg)
        {
            string path = Application.StartupPath;
            StreamWriter sw = new StreamWriter(path + "\\OptionLog.txt",false);
            sw.Write(infoArg);
            sw.Close();

            switch (infoArg)
            {
                case "t1t1":
                    option.L1.Text = "描绘信封靶操作。。。";
                    option.L2.Text = "描绘信封靶成绩。。。";
                    break;
                case "t1t2":
                    option.L1.Text = "对不动目标射击操作。。。";
                    option.L2.Text = "对不动目标射击成绩。。。";
                    break;
                case "t1t3":
                    option.L1.Text = "原地射击操作。。。";
                    option.L2.Text = "原地射击成绩。。。";
                    break;
                case "t1t4":
                    option.L1.Text = "行进射击操作。。。";
                    option.L2.Text = "行进射击成绩。。。";
                    break;
                case "t1t5":
                    option.L1.Text = "平稳跟踪操作。。。";
                    option.L2.Text = "平稳跟踪成绩。。。";
                    break;
                case "t2t1":
                    option.L1.Text = "白天稳像工况设计操作。。。";
                    option.L2.Text = "白天稳像工况设计成绩。。。";
                    break;
                case "t2t2":
                    option.L1.Text = "白天装表工况设计操作。。。";
                    option.L2.Text = "白天装表工况设计成绩。。。";
                    break;
                case "t2t3":
                    option.L1.Text = "夜间稳像工况设计操作。。。";
                    option.L2.Text = "夜间稳像工况设计成绩。。。";
                    break;
                case "t2t4":
                    option.L1.Text = "夜间装表工况设计操作。。。";
                    option.L2.Text = "夜间装表工况设计成绩。。。";
                    break;
                case "t2t5":
                    option.L1.Text = "自动跟踪射击操作。。。";
                    option.L2.Text = "自动跟踪射击成绩。。。";
                    break;
                case "t2t6":
                    option.L1.Text = "稳像工况应急射击操作。。。";
                    option.L2.Text = "稳像工况应急射击成绩。。。";
                    break;
                case "t3t1":
                    option.L1.Text = "综合射击训练操作。。。";
                    option.L2.Text = "综合射击训练成绩。。。";
                    break;
                default:
                    option.L1.Text = "";
                    option.L2.Text = "";
                    break;
            }

            Gamepanel.BringToFront();
            Gamepanel.Visible = true;
            Gamepanel.Controls.Clear();
            Startbutton.Visible = true;
            option.TopLevel = false;
            option.Dock = DockStyle.Fill;
            Gamepanel.Controls.Add(option);
            option.Show();
        }

        private void t1t1_Click(object sender, EventArgs e)
        {
            OpenOption("t1t1");
        }

        private void t1t2_Click(object sender, EventArgs e)
        {
            OpenOption("t1t2");
        }

        private void t1t3_Click(object sender, EventArgs e)
        {
            OpenOption("t1t3");
        }

        private void t1t4_Click(object sender, EventArgs e)
        {
            OpenOption("t1t4");
        }

        private void t1t5_Click(object sender, EventArgs e)
        {
            OpenOption("t1t5");
        }

        private void t2t1_Click(object sender, EventArgs e)
        {
            OpenOption("t2t1");
        }

        private void t2t2_Click(object sender, EventArgs e)
        {
            OpenOption("t2t2");
        }

        private void t2t3_Click(object sender, EventArgs e)
        {
            OpenOption("t2t3");
        }

        private void t2t4_Click(object sender, EventArgs e)
        {
            OpenOption("t2t4");
        }

        private void t2t5_Click(object sender, EventArgs e)
        {
            OpenOption("t2t5");
        }

        private void t2t6_Click(object sender, EventArgs e)
        {
            OpenOption("t2t6");
        }

        private void t3t1_Click(object sender, EventArgs e)
        {
            OpenOption("t3t1");
        }

        private void Write()
        {
            FileStream fs = new FileStream(path + "\\OptionLog.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Close();
            fs.Close();
        }

        private string readArg;
        private void Startbutton_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(path + "\\OptionLog.txt", FileMode.Open);
            StreamReader sr = new StreamReader(file);
            readArg = sr.ReadToEnd();
            sr.Close();

            //Write();

            Startbutton.Visible = false;
            Gamepanel.Controls.Clear();
            Gamepanel.Controls.Add(ScoreRichTextBox);

            switch (readArg)
            {
                case "t1t1":
                    GunnerTest.Draw draw=new GunnerTest.Draw();
                    draw.TopLevel = false;
                    draw.Parent = Gamepanel;
                    draw.Location = new Point(0, 0);
                    draw.Width = Gamepanel.Width - 400;
                    draw.Height = Gamepanel.Height;
                    draw.Show();
                    draw.Focus();
                    break;
                case "t1t2":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t1t3":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t1t4":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t1t5":
                    GunnerTest.Follow follow = new GunnerTest.Follow();
                    follow.TopLevel = false;
                    follow.Parent = Gamepanel;
                    follow.Location = new Point(0, 0);
                    follow.Width = Gamepanel.Width - 400;
                    follow.Height = Gamepanel.Height;
                    follow.Show();
                    follow.Focus();
                    break;
                case "t2t1":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t2t2":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t2t3":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t2t4":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t2t5":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t2t6":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                case "t3t1":
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
                default:
                    myExe = new MyEXEClass(Gamepanel, "-admin -forceSimul -window");
                    break;
            }
            if (myExe!=null)
            {
                myExe.Start("C:\\Program Files\\Bohemia Interactive Simulations\\VBS3 3.9.2 YYMEA_General\\VBS3_64.exe");
                //myExe.Start("D:\\Program Files\\VBS3_64.exe");
            }
        }
        #endregion

        #region Read
        private string strLine;
        private string strSub;

        private string Read(string path)
        {
            try
            {
                FileStream file = new FileStream(path, FileMode.Open);
                StreamReader sRead = new StreamReader(file);
                strLine = sRead.ReadToEnd();
                sRead.Close();
            }
            catch
            {

            }
            if (strLine.Length > 10)
            {
                strSub = strLine.Substring(strLine.Length - 10);
                return strSub;
            }
            else
            {
                return strLine;
            }
        }

        private string message;
        private string messageSub;
        private string path = Application.StartupPath;
        private int curScore=5;
        ArrayList scores = new ArrayList();

        private delegate void ChangedDelegate(FileSystemEventArgs e);

        private void ChangedEvent(FileSystemEventArgs e)
        {
            if (e.Name == "log.txt")
            {
                message = Read(path + "\\log.txt");
                messageSub = message.Substring(message.Length - 10);

                switch (messageSub)
                {
                    case "YLGanYLGan":
                        messageSub = "左边履带压杆!扣1分!\n";
                        curScore -= 1;
                        CurrentScoreLabel.Text = "当前分数：" + curScore.ToString();
                        break;
                    case "YRGanYRGan":
                        messageSub = "右边履带压杆!扣1分!\n";
                        curScore -= 1;
                        CurrentScoreLabel.Text = "当前分数：" + curScore.ToString();
                        break;
                    case "QiGanQiGan":
                        messageSub = "车体骑杆!扣2分!\n";
                        curScore -= 2;
                        CurrentScoreLabel.Text = "当前分数："+curScore.ToString();
                        break;
                    default:
                        messageSub = null;
                        break;
                }
                if (curScore >= 3)
                {
                    CurrentScoreLabel.ForeColor = Color.White;
                }
                else
                {
                    CurrentScoreLabel.ForeColor = Color.Red;
                }
                ScoreRichTextBox.Text += messageSub;
            }
        }

        private void Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (ScoreRichTextBox.InvokeRequired)
            {
                ScoreRichTextBox.Invoke(new ChangedDelegate(ChangedEvent), new object[] { e });
            }
        }
        #endregion
    }
}
