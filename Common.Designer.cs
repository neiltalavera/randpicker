namespace RandomPicker
{
    partial class Common
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Common));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.winnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnWageUp = new System.Windows.Forms.Button();
            this.lblVoted = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOpacity = new System.Windows.Forms.TrackBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtMonitor = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "C600";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.logToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(203, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toTrayToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toTrayToolStripMenuItem
            // 
            this.toTrayToolStripMenuItem.Name = "toTrayToolStripMenuItem";
            this.toTrayToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.toTrayToolStripMenuItem.Text = "Minimize to tray";
            this.toTrayToolStripMenuItem.Click += new System.EventHandler(this.ToTrayToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentToolStripMenuItem,
            this.winnersToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.paymentToolStripMenuItem.Text = "Balance";
            // 
            // winnersToolStripMenuItem
            // 
            this.winnersToolStripMenuItem.Name = "winnersToolStripMenuItem";
            this.winnersToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.winnersToolStripMenuItem.Text = "Winners";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactAdminToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactAdminToolStripMenuItem
            // 
            this.contactAdminToolStripMenuItem.Name = "contactAdminToolStripMenuItem";
            this.contactAdminToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.contactAdminToolStripMenuItem.Text = "Contact Admin";
            this.contactAdminToolStripMenuItem.Click += new System.EventHandler(this.ContactAdminToolStripMenuItem_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.Color.White;
            this.btnJoin.Enabled = false;
            this.btnJoin.Location = new System.Drawing.Point(12, 208);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(179, 33);
            this.btnJoin.TabIndex = 3;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = false;
            this.btnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // btnWageUp
            // 
            this.btnWageUp.BackColor = System.Drawing.Color.White;
            this.btnWageUp.Enabled = false;
            this.btnWageUp.Location = new System.Drawing.Point(12, 160);
            this.btnWageUp.Name = "btnWageUp";
            this.btnWageUp.Size = new System.Drawing.Size(82, 42);
            this.btnWageUp.TabIndex = 4;
            this.btnWageUp.Text = "vote for wage increase";
            this.btnWageUp.UseVisualStyleBackColor = false;
            this.btnWageUp.Click += new System.EventHandler(this.BtnWageUp_Click);
            // 
            // lblVoted
            // 
            this.lblVoted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblVoted.Location = new System.Drawing.Point(90, 160);
            this.lblVoted.Name = "lblVoted";
            this.lblVoted.Size = new System.Drawing.Size(101, 42);
            this.lblVoted.TabIndex = 5;
            this.lblVoted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWinner.Location = new System.Drawing.Point(12, 44);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(179, 23);
            this.lblWinner.TabIndex = 6;
            this.lblWinner.Text = "------";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDarkMode.BackColor = System.Drawing.Color.White;
            this.btnDarkMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDarkMode.Location = new System.Drawing.Point(12, 247);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(23, 23);
            this.btnDarkMode.TabIndex = 8;
            this.btnDarkMode.Text = "D";
            this.btnDarkMode.UseVisualStyleBackColor = false;
            this.btnDarkMode.Click += new System.EventHandler(this.BtnDarkMode_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(38, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 10;
            // 
            // tbOpacity
            // 
            this.tbOpacity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOpacity.BackColor = System.Drawing.Color.White;
            this.tbOpacity.Location = new System.Drawing.Point(31, 246);
            this.tbOpacity.Maximum = 100;
            this.tbOpacity.Minimum = 5;
            this.tbOpacity.Name = "tbOpacity";
            this.tbOpacity.Size = new System.Drawing.Size(166, 45);
            this.tbOpacity.TabIndex = 9;
            this.tbOpacity.Value = 100;
            this.tbOpacity.ValueChanged += new System.EventHandler(this.TbOpacity_ValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notfy text";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(-9, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(75, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "JingJong";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtMonitor);
            this.panel1.Location = new System.Drawing.Point(15, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 87);
            this.panel1.TabIndex = 12;
            // 
            // rtMonitor
            // 
            this.rtMonitor.BackColor = System.Drawing.Color.White;
            this.rtMonitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtMonitor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtMonitor.Location = new System.Drawing.Point(0, 0);
            this.rtMonitor.Name = "rtMonitor";
            this.rtMonitor.ReadOnly = true;
            this.rtMonitor.Size = new System.Drawing.Size(174, 85);
            this.rtMonitor.TabIndex = 0;
            this.rtMonitor.Text = "";
            // 
            // Common
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(203, 281);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnWageUp);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblVoted);
            this.Controls.Add(this.tbOpacity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Common";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem winnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactAdminToolStripMenuItem;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnWageUp;
        private System.Windows.Forms.Label lblVoted;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnDarkMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbOpacity;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtMonitor;
    }
}