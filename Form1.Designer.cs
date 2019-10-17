namespace RandomPicker
{
    partial class frmLogin
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
            this.pnlCover = new System.Windows.Forms.Panel();
            this.btnRand = new System.Windows.Forms.Button();
            this.txtRand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTo2 = new System.Windows.Forms.TextBox();
            this.txtFrom2 = new System.Windows.Forms.TextBox();
            this.pnlCover.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCover
            // 
            this.pnlCover.Controls.Add(this.btnRand);
            this.pnlCover.Controls.Add(this.txtRand);
            this.pnlCover.Controls.Add(this.label3);
            this.pnlCover.Controls.Add(this.label2);
            this.pnlCover.Controls.Add(this.label1);
            this.pnlCover.Controls.Add(this.txtTo);
            this.pnlCover.Controls.Add(this.txtFrom);
            this.pnlCover.Location = new System.Drawing.Point(-1, -1);
            this.pnlCover.Name = "pnlCover";
            this.pnlCover.Size = new System.Drawing.Size(220, 165);
            this.pnlCover.TabIndex = 2;
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(73, 132);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(75, 23);
            this.btnRand.TabIndex = 2;
            this.btnRand.Text = "Rand";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.BtnRand_Click);
            // 
            // txtRand
            // 
            this.txtRand.BackColor = System.Drawing.Color.White;
            this.txtRand.Location = new System.Drawing.Point(36, 70);
            this.txtRand.Name = "txtRand";
            this.txtRand.ReadOnly = true;
            this.txtRand.Size = new System.Drawing.Size(149, 20);
            this.txtRand.TabIndex = 3;
            this.txtRand.TextChanged += new System.EventHandler(this.TxtRand_TextChanged);
            this.txtRand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtRand_KeyUp);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter number range";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(160, 32);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(48, 20);
            this.txtTo.TabIndex = 1;
            this.txtTo.TextChanged += new System.EventHandler(this.TxtTo_TextChanged);
            this.txtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCover_KeyDown);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(46, 32);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(48, 20);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.TextChanged += new System.EventHandler(this.TxtFrom_TextChanged);
            this.txtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCover_KeyDown);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label6);
            this.pnlLogin.Controls.Add(this.txtTo2);
            this.pnlLogin.Controls.Add(this.txtFrom2);
            this.pnlLogin.Enabled = false;
            this.pnlLogin.Location = new System.Drawing.Point(-1, -1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(220, 165);
            this.pnlLogin.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(73, 132);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Rand";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(36, 96);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(149, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Visible = false;
            this.txtPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPass_KeyUp);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(36, 70);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(149, 20);
            this.txtUser.TabIndex = 2;
            this.txtUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtUser_KeyUp);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Enter number range";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "To:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "From:";
            // 
            // txtTo2
            // 
            this.txtTo2.Location = new System.Drawing.Point(160, 32);
            this.txtTo2.Name = "txtTo2";
            this.txtTo2.Size = new System.Drawing.Size(48, 20);
            this.txtTo2.TabIndex = 1;
            this.txtTo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCover_KeyDown);
            // 
            // txtFrom2
            // 
            this.txtFrom2.Location = new System.Drawing.Point(46, 32);
            this.txtFrom2.Name = "txtFrom2";
            this.txtFrom2.Size = new System.Drawing.Size(48, 20);
            this.txtFrom2.TabIndex = 0;
            this.txtFrom2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCover_KeyDown);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(218, 162);
            this.Controls.Add(this.pnlCover);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlCover.ResumeLayout(false);
            this.pnlCover.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCover;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.TextBox txtRand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTo2;
        private System.Windows.Forms.TextBox txtFrom2;
    }
}

