namespace GunnerClient
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("描绘信封靶");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("对不动目标射击");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("原地射击");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("行进射击");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("平稳跟踪目标");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("稳定器操作训练", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("白天稳像工况射击");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("白天装表工况射击");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("夜间稳像工况射击");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("夜间装表工况射击");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("自动跟踪射击");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("稳像工况应急射击");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("射击操作训练", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("综合射击训练");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("全部训练", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode13,
            treeNode14});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Testlabel3 = new System.Windows.Forms.Label();
            this.Testlabel2 = new System.Windows.Forms.Label();
            this.Testlabel1 = new System.Windows.Forms.Label();
            this.BGTTlabel = new System.Windows.Forms.Label();
            this.Scorepanel = new GunnerClient.MyPanel();
            this.Scoretree = new System.Windows.Forms.TreeView();
            this.Scoredata = new System.Windows.Forms.DataGridView();
            this.Loginpanel = new GunnerClient.MyPanel();
            this.Scorebutton = new System.Windows.Forms.Button();
            this.Logoutbutton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.RegistButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NumberTextbox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.BGpanel = new GunnerClient.MyPanel();
            this.TestpictureBox1 = new GunnerClient.MyPictureBox();
            this.TestpictureBox2 = new GunnerClient.MyPictureBox();
            this.TestpictureBox3 = new GunnerClient.MyPictureBox();
            this.BGTTpictureBox = new GunnerClient.MyPictureBox();
            this.BGpictureBox = new GunnerClient.MyPictureBox();
            this.Scorepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scoredata)).BeginInit();
            this.Loginpanel.SuspendLayout();
            this.BGpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestpictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestpictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestpictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGTTpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Testlabel3
            // 
            this.Testlabel3.AutoSize = true;
            this.Testlabel3.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Testlabel3.ForeColor = System.Drawing.Color.White;
            this.Testlabel3.Location = new System.Drawing.Point(291, 546);
            this.Testlabel3.Name = "Testlabel3";
            this.Testlabel3.Size = new System.Drawing.Size(354, 30);
            this.Testlabel3.TabIndex = 7;
            this.Testlabel3.Text = "综合射击训练";
            // 
            // Testlabel2
            // 
            this.Testlabel2.AutoSize = true;
            this.Testlabel2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Testlabel2.ForeColor = System.Drawing.Color.White;
            this.Testlabel2.Location = new System.Drawing.Point(398, 398);
            this.Testlabel2.Name = "Testlabel2";
            this.Testlabel2.Size = new System.Drawing.Size(137, 30);
            this.Testlabel2.TabIndex = 5;
            this.Testlabel2.Text = "基础射击训练";
            // 
            // Testlabel1
            // 
            this.Testlabel1.AutoSize = true;
            this.Testlabel1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Testlabel1.ForeColor = System.Drawing.Color.White;
            this.Testlabel1.Location = new System.Drawing.Point(398, 246);
            this.Testlabel1.Name = "Testlabel1";
            this.Testlabel1.Size = new System.Drawing.Size(137, 30);
            this.Testlabel1.TabIndex = 3;
            this.Testlabel1.Text = "稳定器操作训练";
            // 
            // BGTTlabel
            // 
            this.BGTTlabel.AutoSize = true;
            this.BGTTlabel.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BGTTlabel.ForeColor = System.Drawing.Color.White;
            this.BGTTlabel.Location = new System.Drawing.Point(323, 82);
            this.BGTTlabel.Name = "BGTTlabel";
            this.BGTTlabel.Size = new System.Drawing.Size(293, 30);
            this.BGTTlabel.TabIndex = 1;
            this.BGTTlabel.Text = "XX坦克射击训练系统";
            // 
            // Scorepanel
            // 
            this.Scorepanel.BackColor = System.Drawing.Color.Transparent;
            this.Scorepanel.BackgroundImage = global::GunnerClient.Properties.Resources.mask;
            this.Scorepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Scorepanel.Controls.Add(this.Scoretree);
            this.Scorepanel.Controls.Add(this.Scoredata);
            this.Scorepanel.Location = new System.Drawing.Point(920, 350);
            this.Scorepanel.Name = "Scorepanel";
            this.Scorepanel.Size = new System.Drawing.Size(1000, 730);
            this.Scorepanel.TabIndex = 3;
            this.Scorepanel.Visible = false;
            // 
            // Scoretree
            // 
            this.Scoretree.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Scoretree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scoretree.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Scoretree.ForeColor = System.Drawing.Color.White;
            this.Scoretree.Location = new System.Drawing.Point(18, 25);
            this.Scoretree.Name = "Scoretree";
            treeNode1.Name = "t1t1";
            treeNode1.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode1.Text = "描绘信封靶";
            treeNode2.Name = "t1t2";
            treeNode2.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode2.Text = "对不动目标射击";
            treeNode3.Name = "t1t3";
            treeNode3.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode3.Text = "原地射击";
            treeNode4.Name = "t1t4";
            treeNode4.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode4.Text = "行进射击";
            treeNode5.Name = "t1t5";
            treeNode5.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode5.Text = "平稳跟踪目标";
            treeNode6.Name = "t1";
            treeNode6.NodeFont = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode6.Text = "稳定器操作训练";
            treeNode7.Name = "t2t1";
            treeNode7.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode7.Text = "白天稳像工况射击";
            treeNode8.Name = "t2t2";
            treeNode8.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode8.SelectedImageIndex = -2;
            treeNode8.Text = "白天装表工况射击";
            treeNode9.Name = "t2t3";
            treeNode9.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode9.Text = "夜间稳像工况射击";
            treeNode10.Name = "t2t4";
            treeNode10.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode10.Text = "夜间装表工况射击";
            treeNode11.Name = "t2t5";
            treeNode11.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode11.Text = "自动跟踪射击";
            treeNode12.Name = "t2t6";
            treeNode12.NodeFont = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode12.Text = "稳像工况应急射击";
            treeNode13.Name = "t2";
            treeNode13.NodeFont = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode13.Text = "射击操作训练";
            treeNode14.Name = "t3";
            treeNode14.NodeFont = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode14.Text = "综合射击训练";
            treeNode15.Name = "t0";
            treeNode15.NodeFont = new System.Drawing.Font("黑体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode15.Text = "全部训练";
            this.Scoretree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.Scoretree.ShowLines = false;
            this.Scoretree.ShowPlusMinus = false;
            this.Scoretree.Size = new System.Drawing.Size(307, 682);
            this.Scoretree.TabIndex = 1;
            this.Scoretree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Scoretree_AfterSelect);
            // 
            // Scoredata
            // 
            this.Scoredata.AllowUserToAddRows = false;
            this.Scoredata.AllowUserToDeleteRows = false;
            this.Scoredata.AllowUserToResizeColumns = false;
            this.Scoredata.AllowUserToResizeRows = false;
            this.Scoredata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Scoredata.BackgroundColor = System.Drawing.Color.SlateGray;
            this.Scoredata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scoredata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Scoredata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Scoredata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Scoredata.ColumnHeadersHeight = 30;
            this.Scoredata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Scoredata.DefaultCellStyle = dataGridViewCellStyle2;
            this.Scoredata.Location = new System.Drawing.Point(331, 25);
            this.Scoredata.Name = "Scoredata";
            this.Scoredata.ReadOnly = true;
            this.Scoredata.RowHeadersVisible = false;
            this.Scoredata.RowTemplate.Height = 27;
            this.Scoredata.ShowEditingIcon = false;
            this.Scoredata.Size = new System.Drawing.Size(647, 682);
            this.Scoredata.TabIndex = 0;
            // 
            // Loginpanel
            // 
            this.Loginpanel.BackColor = System.Drawing.Color.Transparent;
            this.Loginpanel.BackgroundImage = global::GunnerClient.Properties.Resources.mask;
            this.Loginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loginpanel.Controls.Add(this.Scorebutton);
            this.Loginpanel.Controls.Add(this.Logoutbutton);
            this.Loginpanel.Controls.Add(this.ErrorLabel);
            this.Loginpanel.Controls.Add(this.passwordCheckBox);
            this.Loginpanel.Controls.Add(this.RegistButton);
            this.Loginpanel.Controls.Add(this.LoginButton);
            this.Loginpanel.Controls.Add(this.PasswordTextbox);
            this.Loginpanel.Controls.Add(this.PasswordLabel);
            this.Loginpanel.Controls.Add(this.NumberTextbox);
            this.Loginpanel.Controls.Add(this.NumberLabel);
            this.Loginpanel.Location = new System.Drawing.Point(920, 0);
            this.Loginpanel.Name = "Loginpanel";
            this.Loginpanel.Size = new System.Drawing.Size(1000, 350);
            this.Loginpanel.TabIndex = 2;
            // 
            // Scorebutton
            // 
            this.Scorebutton.BackgroundImage = global::GunnerClient.Properties.Resources.bluebtn;
            this.Scorebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Scorebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Scorebutton.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Scorebutton.ForeColor = System.Drawing.Color.White;
            this.Scorebutton.Location = new System.Drawing.Point(437, 39);
            this.Scorebutton.Name = "Scorebutton";
            this.Scorebutton.Size = new System.Drawing.Size(150, 50);
            this.Scorebutton.TabIndex = 19;
            this.Scorebutton.Text = "我的成绩";
            this.Scorebutton.UseVisualStyleBackColor = true;
            this.Scorebutton.Visible = false;
            this.Scorebutton.Click += new System.EventHandler(this.Scorebutton_Click);
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.BackgroundImage = global::GunnerClient.Properties.Resources.redbtn;
            this.Logoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logoutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logoutbutton.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Logoutbutton.ForeColor = System.Drawing.Color.White;
            this.Logoutbutton.Location = new System.Drawing.Point(472, 252);
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Size = new System.Drawing.Size(80, 50);
            this.Logoutbutton.TabIndex = 18;
            this.Logoutbutton.Text = "登出";
            this.Logoutbutton.UseVisualStyleBackColor = true;
            this.Logoutbutton.Visible = false;
            this.Logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("楷体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Moccasin;
            this.ErrorLabel.Location = new System.Drawing.Point(380, 163);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 30);
            this.ErrorLabel.TabIndex = 17;
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Font = new System.Drawing.Font("楷体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordCheckBox.ForeColor = System.Drawing.Color.Moccasin;
            this.passwordCheckBox.Location = new System.Drawing.Point(660, 104);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(142, 29);
            this.passwordCheckBox.TabIndex = 16;
            this.passwordCheckBox.Text = "显示密码";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegistButton
            // 
            this.RegistButton.BackgroundImage = global::GunnerClient.Properties.Resources.redbtn;
            this.RegistButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistButton.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegistButton.ForeColor = System.Drawing.Color.White;
            this.RegistButton.Location = new System.Drawing.Point(552, 252);
            this.RegistButton.Name = "RegistButton";
            this.RegistButton.Size = new System.Drawing.Size(80, 50);
            this.RegistButton.TabIndex = 14;
            this.RegistButton.Text = "注册";
            this.RegistButton.UseVisualStyleBackColor = true;
            this.RegistButton.Click += new System.EventHandler(this.RegistButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackgroundImage = global::GunnerClient.Properties.Resources.bluebtn;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(392, 252);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(80, 50);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.PasswordTextbox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordTextbox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextbox.Location = new System.Drawing.Point(392, 102);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(240, 34);
            this.PasswordTextbox.TabIndex = 12;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("楷体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Moccasin;
            this.PasswordLabel.Location = new System.Drawing.Point(271, 105);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 30);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "密码";
            // 
            // NumberTextbox
            // 
            this.NumberTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.NumberTextbox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumberTextbox.ForeColor = System.Drawing.Color.White;
            this.NumberTextbox.Location = new System.Drawing.Point(392, 47);
            this.NumberTextbox.Name = "NumberTextbox";
            this.NumberTextbox.Size = new System.Drawing.Size(240, 34);
            this.NumberTextbox.TabIndex = 10;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("楷体", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumberLabel.ForeColor = System.Drawing.Color.Moccasin;
            this.NumberLabel.Location = new System.Drawing.Point(271, 50);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(75, 30);
            this.NumberLabel.TabIndex = 9;
            this.NumberLabel.Text = "学号";
            // 
            // BGpanel
            // 
            this.BGpanel.BackColor = System.Drawing.Color.Transparent;
            this.BGpanel.Controls.Add(this.TestpictureBox1);
            this.BGpanel.Controls.Add(this.TestpictureBox2);
            this.BGpanel.Controls.Add(this.TestpictureBox3);
            this.BGpanel.Controls.Add(this.BGTTpictureBox);
            this.BGpanel.Location = new System.Drawing.Point(0, 0);
            this.BGpanel.Name = "BGpanel";
            this.BGpanel.Size = new System.Drawing.Size(920, 1080);
            this.BGpanel.TabIndex = 1;
            // 
            // TestpictureBox1
            // 
            this.TestpictureBox1.BackgroundImage = global::GunnerClient.Properties.Resources.sltt;
            this.TestpictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TestpictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestpictureBox1.Location = new System.Drawing.Point(160, 326);
            this.TestpictureBox1.Name = "TestpictureBox1";
            this.TestpictureBox1.Size = new System.Drawing.Size(600, 100);
            this.TestpictureBox1.TabIndex = 2;
            this.TestpictureBox1.TabStop = false;
            this.TestpictureBox1.Click += new System.EventHandler(this.TestpictureBox1_Click);
            this.TestpictureBox1.MouseEnter += new System.EventHandler(this.TestpictureBox1_MouseEnter);
            this.TestpictureBox1.MouseLeave += new System.EventHandler(this.TestpictureBox1_MouseLeave);
            // 
            // TestpictureBox2
            // 
            this.TestpictureBox2.BackgroundImage = global::GunnerClient.Properties.Resources.sltt;
            this.TestpictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TestpictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestpictureBox2.Location = new System.Drawing.Point(160, 476);
            this.TestpictureBox2.Name = "TestpictureBox2";
            this.TestpictureBox2.Size = new System.Drawing.Size(600, 100);
            this.TestpictureBox2.TabIndex = 4;
            this.TestpictureBox2.TabStop = false;
            this.TestpictureBox2.Click += new System.EventHandler(this.TestpictureBox2_Click);
            this.TestpictureBox2.MouseEnter += new System.EventHandler(this.TestpictureBox2_MouseEnter);
            this.TestpictureBox2.MouseLeave += new System.EventHandler(this.TestpictureBox2_MouseLeave);
            // 
            // TestpictureBox3
            // 
            this.TestpictureBox3.BackgroundImage = global::GunnerClient.Properties.Resources.sltt;
            this.TestpictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TestpictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestpictureBox3.Location = new System.Drawing.Point(160, 626);
            this.TestpictureBox3.Name = "TestpictureBox3";
            this.TestpictureBox3.Size = new System.Drawing.Size(600, 100);
            this.TestpictureBox3.TabIndex = 6;
            this.TestpictureBox3.TabStop = false;
            this.TestpictureBox3.Click += new System.EventHandler(this.TestpictureBox3_Click);
            this.TestpictureBox3.MouseEnter += new System.EventHandler(this.TestpictureBox3_MouseEnter);
            this.TestpictureBox3.MouseLeave += new System.EventHandler(this.TestpictureBox3_MouseLeave);
            // 
            // BGTTpictureBox
            // 
            this.BGTTpictureBox.BackgroundImage = global::GunnerClient.Properties.Resources.btt;
            this.BGTTpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BGTTpictureBox.Location = new System.Drawing.Point(60, 30);
            this.BGTTpictureBox.Name = "BGTTpictureBox";
            this.BGTTpictureBox.Size = new System.Drawing.Size(800, 150);
            this.BGTTpictureBox.TabIndex = 0;
            this.BGTTpictureBox.TabStop = false;
            // 
            // BGpictureBox
            // 
            this.BGpictureBox.BackgroundImage = global::GunnerClient.Properties.Resources.bg11;
            this.BGpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BGpictureBox.Location = new System.Drawing.Point(0, 0);
            this.BGpictureBox.Name = "BGpictureBox";
            this.BGpictureBox.Size = new System.Drawing.Size(920, 1080);
            this.BGpictureBox.TabIndex = 0;
            this.BGpictureBox.TabStop = false;
            this.BGpictureBox.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GunnerClient.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Scorepanel);
            this.Controls.Add(this.Loginpanel);
            this.Controls.Add(this.BGpanel);
            this.Controls.Add(this.BGpictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "射击训练";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.Scorepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Scoredata)).EndInit();
            this.Loginpanel.ResumeLayout(false);
            this.Loginpanel.PerformLayout();
            this.BGpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestpictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestpictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestpictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGTTpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BGTTlabel;
        private System.Windows.Forms.Label Testlabel1;
        private System.Windows.Forms.Label Testlabel2;
        private System.Windows.Forms.Label Testlabel3;
        private System.Windows.Forms.Timer Timer;
        private MyPanel BGpanel;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private System.Windows.Forms.Button RegistButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox NumberTextbox;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private MyPictureBox BGpictureBox;
        private MyPictureBox BGTTpictureBox;
        private MyPictureBox TestpictureBox1;
        private MyPictureBox TestpictureBox2;
        private MyPictureBox TestpictureBox3;
        private MyPanel Loginpanel;
        private System.Windows.Forms.Button Logoutbutton;
        private System.Windows.Forms.Button Scorebutton;
        private MyPanel Scorepanel;
        private System.Windows.Forms.TreeView Scoretree;
        private System.Windows.Forms.DataGridView Scoredata;


    }
}

