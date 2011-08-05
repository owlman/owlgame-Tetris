namespace owlgame
{
    partial class mainForm
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
            this.gamewiew = new System.Windows.Forms.Panel();
            this.gaizi = new System.Windows.Forms.Panel();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.proview = new System.Windows.Forms.GroupBox();
            this.proimg = new System.Windows.Forms.PictureBox();
            this.settmaeg = new System.Windows.Forms.GroupBox();
            this.myweb = new System.Windows.Forms.LinkLabel();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonset = new System.Windows.Forms.Button();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.gamewiew.SuspendLayout();
            this.gaizi.SuspendLayout();
            this.proview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proimg)).BeginInit();
            this.settmaeg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamewiew
            // 
            this.gamewiew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gamewiew.AutoSize = true;
            this.gamewiew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gamewiew.Controls.Add(this.gaizi);
            this.gamewiew.Location = new System.Drawing.Point(3, 3);
            this.gamewiew.Name = "gamewiew";
            this.gamewiew.Size = new System.Drawing.Size(220, 388);
            this.gamewiew.TabIndex = 0;
            this.gamewiew.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gamewiew_PreviewKeyDown);
            this.gamewiew.Paint += new System.Windows.Forms.PaintEventHandler(this.gamewiew_Paint);
            // 
            // gaizi
            // 
            this.gaizi.Controls.Add(this.welcomelabel);
            this.gaizi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaizi.Location = new System.Drawing.Point(0, 0);
            this.gaizi.Name = "gaizi";
            this.gaizi.Size = new System.Drawing.Size(220, 388);
            this.gaizi.TabIndex = 0;
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("隶书", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcomelabel.ForeColor = System.Drawing.Color.Coral;
            this.welcomelabel.Location = new System.Drawing.Point(4, 132);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(213, 33);
            this.welcomelabel.TabIndex = 0;
            this.welcomelabel.Text = "欢迎尝试游戏";
            // 
            // proview
            // 
            this.proview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.proview.BackColor = System.Drawing.SystemColors.Control;
            this.proview.Controls.Add(this.proimg);
            this.proview.Location = new System.Drawing.Point(239, 14);
            this.proview.Name = "proview";
            this.proview.Size = new System.Drawing.Size(85, 73);
            this.proview.TabIndex = 1;
            this.proview.TabStop = false;
            this.proview.Text = "下一个：";
            // 
            // proimg
            // 
            this.proimg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.proimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proimg.Location = new System.Drawing.Point(3, 17);
            this.proimg.Name = "proimg";
            this.proimg.Size = new System.Drawing.Size(79, 53);
            this.proimg.TabIndex = 0;
            this.proimg.TabStop = false;
            this.proimg.Paint += new System.Windows.Forms.PaintEventHandler(this.proimg_Paint);
            // 
            // settmaeg
            // 
            this.settmaeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.settmaeg.Controls.Add(this.myweb);
            this.settmaeg.Controls.Add(this.buttonexit);
            this.settmaeg.Controls.Add(this.buttonback);
            this.settmaeg.Controls.Add(this.buttonstart);
            this.settmaeg.Controls.Add(this.buttonset);
            this.settmaeg.Location = new System.Drawing.Point(239, 93);
            this.settmaeg.Name = "settmaeg";
            this.settmaeg.Size = new System.Drawing.Size(82, 287);
            this.settmaeg.TabIndex = 2;
            this.settmaeg.TabStop = false;
            this.settmaeg.Text = "游戏控制：";
            // 
            // myweb
            // 
            this.myweb.AutoSize = true;
            this.myweb.Location = new System.Drawing.Point(11, 245);
            this.myweb.Name = "myweb";
            this.myweb.Size = new System.Drawing.Size(65, 12);
            this.myweb.TabIndex = 4;
            this.myweb.TabStop = true;
            this.myweb.Tag = "www.lingjie.net";
            this.myweb.Text = "owlnan制作";
            this.myweb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.myweb_LinkClicked);
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(16, 189);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(56, 23);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "退出(&X)";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(16, 140);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(56, 23);
            this.buttonback.TabIndex = 2;
            this.buttonback.Text = "重玩(&O)";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(16, 91);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(56, 23);
            this.buttonstart.TabIndex = 1;
            this.buttonstart.Text = "开始(&E)";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonset
            // 
            this.buttonset.Location = new System.Drawing.Point(16, 42);
            this.buttonset.Name = "buttonset";
            this.buttonset.Size = new System.Drawing.Size(56, 23);
            this.buttonset.TabIndex = 0;
            this.buttonset.Text = "说明(&S)";
            this.buttonset.UseVisualStyleBackColor = true;
            this.buttonset.Click += new System.EventHandler(this.buttonset_Click);
            // 
            // gametimer
            // 
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 392);
            this.Controls.Add(this.settmaeg);
            this.Controls.Add(this.proview);
            this.Controls.Add(this.gamewiew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "俄罗斯方块";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gamewiew.ResumeLayout(false);
            this.gaizi.ResumeLayout(false);
            this.gaizi.PerformLayout();
            this.proview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proimg)).EndInit();
            this.settmaeg.ResumeLayout(false);
            this.settmaeg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gamewiew;
        private System.Windows.Forms.GroupBox proview;
        private System.Windows.Forms.PictureBox proimg;
        private System.Windows.Forms.GroupBox settmaeg;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button buttonset;
        private System.Windows.Forms.LinkLabel myweb;
        private System.Windows.Forms.Panel gaizi;
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Timer gametimer;
    }
}

