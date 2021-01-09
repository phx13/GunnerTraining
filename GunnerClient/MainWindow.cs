using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GunnerClient
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetStyle(System.Windows.Forms.ControlStyles.UserPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(System.Windows.Forms.ControlStyles.DoubleBuffer, true);
            UpdateStyles();
            Timer.Tick+=new EventHandler(Timer_Tick);
            base.Opacity = 0;
            Timer.Start();
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

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                GC.Collect();
                this.Dispose();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            BGpanel.Parent = BGpictureBox;
            BGTTlabel.Parent = BGTTpictureBox;
            BGTTlabel.Location = new Point(270, 60);
            Testlabel1.Parent = TestpictureBox1;
            Testlabel1.Location = new Point(190, 45);
            Testlabel2.Parent = TestpictureBox2;
            Testlabel2.Location = new Point(200, 45);
            Testlabel3.Parent = TestpictureBox3;
            Testlabel3.Location = new Point(200, 45);
            Scoretree.ExpandAll();
        }

        #region Click
        Test test = new Test();
        private void TestpictureBox1_Click(object sender, EventArgs e)
        {
            test.t1tt.Visible = true;
            test.t1t1.Visible = true;
            test.t1t2.Visible = true;
            test.t1t3.Visible = true;
            test.t1t4.Visible = true;
            test.t1t5.Visible = true;
            test.ShowDialog();
        }

        private void TestpictureBox2_Click(object sender, EventArgs e)
        {
            test.t2tt.Visible = true;
            test.t2t1.Visible = true;
            test.t2t2.Visible = true;
            test.t2t3.Visible = true;
            test.t2t4.Visible = true;
            test.t2t5.Visible = true;
            test.t2t6.Visible = true;
            test.ShowDialog();
        }

        private void TestpictureBox3_Click(object sender, EventArgs e)
        {
            test.t3tt.Visible = true;
            test.t3t1.Visible = true;
            test.ShowDialog();
        }
        #endregion

        #region Mousehover
        private void TestpictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Testlabel1.ForeColor = Color.OrangeRed;
        }

        private void TestpictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Testlabel2.ForeColor = Color.OrangeRed;
        }

        private void TestpictureBox3_MouseEnter(object sender, EventArgs e)
        {
            Testlabel3.ForeColor = Color.OrangeRed;
        }

        private void TestpictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Testlabel1.ForeColor = Color.White;
        }

        private void TestpictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Testlabel2.ForeColor = Color.White;
        }

        private void TestpictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Testlabel3.ForeColor = Color.White;
        }
        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity>=1)
            {
                Timer.Stop();
            }
            else
            {
                base.Opacity += 0.8;
            }
        }

        #region Log
        public static string number;
        public static string password;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            number = NumberTextbox.Text;
            password = PasswordTextbox.Text;
            if (number == "" || password == "")
            {
                ErrorLabel.Text = "请输入学号或密码";
            }
            else
            {
                SQLiteDataReader sdrLogin = MySQLiteClass.Getmysqlread("select Password from Login where Number ='" + number + "'");
                sdrLogin.Read();
                if (sdrLogin.HasRows)
                {
                    if (password != sdrLogin["Password"].ToString())
                    {
                        ErrorLabel.Text = "请输入正确的学号和密码";
                    }
                    else
                    {
                        sdrLogin.Close();
                        sdrLogin.Dispose();
                        MySQLiteClass.sqlClose(MySQLiteClass.Getsqlitecon());
                        ErrorLabel.Text = "欢迎回来，学员" + number;
                        BGpictureBox.Visible = true;
                        Logoutbutton.Visible = true;
                        Scorebutton.Visible = true;
                        NumberLabel.Visible = false;
                        NumberTextbox.Visible = false;
                        PasswordLabel.Visible = false;
                        PasswordTextbox.Visible = false;
                        passwordCheckBox.Visible = false;
                        LoginButton.Visible = false;
                        RegistButton.Visible = false;
                    }
                }
                else
                {
                    ErrorLabel.Text = "请输入正确的学号和密码";
                }
            }
            NumberTextbox.Text = "";
            PasswordTextbox.Text = "";
        }

        private void RegistButton_Click(object sender, EventArgs e)
        {
            number = NumberTextbox.Text;
            password = PasswordTextbox.Text;
            if (number == "" || password == "")
            {
                ErrorLabel.Text = "请输入注册学号或密码";
            }
            else
            {
                SQLiteDataReader sdrLogin = MySQLiteClass.Getmysqlread("select Number from Login where Number='" + number + "'");
                sdrLogin.Read();
                if (sdrLogin.HasRows)
                {
                    sdrLogin.Close();
                    sdrLogin.Dispose();
                    ErrorLabel.Text = "该学号已注册";
                }
                else
                {
                    MySQLiteClass.Getmysqlcom("insert into Login(Number,Password) values('"+number+"','"+password+"')");
                    ErrorLabel.Text = "注册成功";
                }
            }
            NumberTextbox.Text = "";
            PasswordTextbox.Text = "";
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            BGpictureBox.Visible = false;
            Logoutbutton.Visible = false;
            Scorebutton.Visible = false;
            Scorepanel.Visible = false;
            NumberLabel.Visible = true;
            NumberTextbox.Visible = true;
            PasswordLabel.Visible = true;
            PasswordTextbox.Visible = true;
            passwordCheckBox.Visible = true;
            LoginButton.Visible = true;
            RegistButton.Visible = true;
            ErrorLabel.Text = "";
        }

        private void Scorebutton_Click(object sender, EventArgs e)
        {
            if (Scorepanel.Visible == false)
            {
                Scorepanel.Visible = true;
            }
            else
            {
                Scorepanel.Visible = false;
            }
        }
        #endregion

        private string selectText;
        private void Scoretree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectText = Scoretree.SelectedNode.Text;
            Scoredata.DataSource = null;
            if (selectText=="全部训练")
            {
                Scoredata.DataSource = MySQLiteClass.Getsqliteset("select 训练时间,描绘信封靶,对不动目标射击,原地射击,行进射击,平稳跟踪目标,白天稳像工况射击,白天装表工况射击,夜间稳像工况射击,夜间装表工况射击,自动跟踪射击,稳像工况应急射击 from ConScore where Number='" + number + "'", "ConScore").Tables[0];                
            }
            else if (selectText=="稳定器操作训练")
            {
                Scoredata.DataSource = MySQLiteClass.Getsqliteset("select 训练时间,描绘信封靶,对不动目标射击,原地射击,行进射击,平稳跟踪目标 from ConScore where Number='" + number + "'", "ConScore").Tables[0];                
            }
            else if (selectText=="射击操作训练")
            {
                Scoredata.DataSource = MySQLiteClass.Getsqliteset("select 训练时间,白天稳像工况射击,白天装表工况射击,夜间稳像工况射击,夜间装表工况射击,自动跟踪射击,稳像工况应急射击 from ConScore where Number='" + number + "'", "ConScore").Tables[0];                
            }
            else
            {
                Scoredata.DataSource = MySQLiteClass.Getsqliteset("select 训练时间," + selectText + " from ConScore where Number='" + number + "' and " + selectText + " is not null", "ConScore").Tables[0];
            }
        }
    }
}
