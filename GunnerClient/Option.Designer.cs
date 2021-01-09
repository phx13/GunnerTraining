namespace GunnerClient
{
    partial class Option
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.TTlabel1 = new System.Windows.Forms.Label();
            this.TTlabel2 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TTlabel1
            // 
            this.TTlabel1.AutoSize = true;
            this.TTlabel1.BackColor = System.Drawing.Color.Transparent;
            this.TTlabel1.Font = new System.Drawing.Font("楷体", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TTlabel1.ForeColor = System.Drawing.Color.SkyBlue;
            this.TTlabel1.Location = new System.Drawing.Point(95, 52);
            this.TTlabel1.Name = "TTlabel1";
            this.TTlabel1.Size = new System.Drawing.Size(181, 40);
            this.TTlabel1.TabIndex = 12;
            this.TTlabel1.Text = "操作说明";
            // 
            // TTlabel2
            // 
            this.TTlabel2.AutoSize = true;
            this.TTlabel2.BackColor = System.Drawing.Color.Transparent;
            this.TTlabel2.Font = new System.Drawing.Font("楷体", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TTlabel2.ForeColor = System.Drawing.Color.SkyBlue;
            this.TTlabel2.Location = new System.Drawing.Point(95, 480);
            this.TTlabel2.Name = "TTlabel2";
            this.TTlabel2.Size = new System.Drawing.Size(181, 40);
            this.TTlabel2.TabIndex = 13;
            this.TTlabel2.Text = "成绩评定";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.BackColor = System.Drawing.Color.Transparent;
            this.L2.Font = new System.Drawing.Font("楷体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.L2.ForeColor = System.Drawing.Color.White;
            this.L2.Location = new System.Drawing.Point(372, 530);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(131, 38);
            this.L2.TabIndex = 14;
            this.L2.Text = "......";
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.BackColor = System.Drawing.Color.Transparent;
            this.L1.Font = new System.Drawing.Font("楷体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.L1.ForeColor = System.Drawing.Color.White;
            this.L1.Location = new System.Drawing.Point(372, 100);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(131, 38);
            this.L1.TabIndex = 15;
            this.L1.Text = "......";
            // 
            // Option
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GunnerClient.Properties.Resources.mask;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1684, 930);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.TTlabel2);
            this.Controls.Add(this.TTlabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Option_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label TTlabel1;
        private System.Windows.Forms.Label TTlabel2;
        public System.Windows.Forms.Label L2;
        public System.Windows.Forms.Label L1;
    }
}