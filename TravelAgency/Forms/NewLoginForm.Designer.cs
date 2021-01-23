
namespace TravelAgency.Forms
{
    partial class NewLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLoginForm));
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pbUsername = new FontAwesome.Sharp.IconPictureBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbPassword = new FontAwesome.Sharp.IconPictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnInformation = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsername
            // 
            this.pnlUsername.Controls.Add(this.pbUsername);
            this.pnlUsername.Controls.Add(this.tbUsername);
            this.pnlUsername.Location = new System.Drawing.Point(223, 102);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(274, 51);
            this.pnlUsername.TabIndex = 1;
            // 
            // pbUsername
            // 
            this.pbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.pbUsername.BackgroundImage = global::TravelAgency.Properties.Resources.profileIcon1;
            this.pbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbUsername.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pbUsername.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbUsername.IconSize = 50;
            this.pbUsername.Location = new System.Drawing.Point(0, 0);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(50, 51);
            this.pbUsername.TabIndex = 1;
            this.pbUsername.TabStop = false;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbUsername.ForeColor = System.Drawing.Color.Silver;
            this.tbUsername.Location = new System.Drawing.Point(56, 15);
            this.tbUsername.MaxLength = 25;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(215, 22);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Text = "Korisnicko ime";
            this.tbUsername.WordWrap = false;
            this.tbUsername.Click += new System.EventHandler(this.tbUsername_Click);
            this.tbUsername.DoubleClick += new System.EventHandler(this.tbUsername_Click);
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.tbPassword);
            this.pnlPassword.Controls.Add(this.pbPassword);
            this.pnlPassword.Location = new System.Drawing.Point(223, 179);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(274, 51);
            this.pnlPassword.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Location = new System.Drawing.Point(56, 16);
            this.tbPassword.MaxLength = 25;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(215, 22);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.Text = "xxxxxxxx";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.WordWrap = false;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.DoubleClick += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Click);
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.pbPassword.BackgroundImage = global::TravelAgency.Properties.Resources.passwordIcon1;
            this.pbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pbPassword.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbPassword.IconSize = 39;
            this.pbPassword.Location = new System.Drawing.Point(5, 3);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(39, 45);
            this.pbPassword.TabIndex = 2;
            this.pbPassword.TabStop = false;
            this.pbPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPassword_MouseDown);
            this.pbPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPassword_MouseUp);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Location = new System.Drawing.Point(469, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.Location = new System.Drawing.Point(438, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "___";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnInformation.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.btnInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformation.IconSize = 35;
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInformation.Location = new System.Drawing.Point(12, 12);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(46, 38);
            this.btnInformation.TabIndex = 0;
            this.btnInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(279, 286);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(159, 48);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "&Prijavite se";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // NewLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TravelAgency.Properties.Resources.final;
            this.ClientSize = new System.Drawing.Size(498, 370);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLoginForm";
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsername;
        private FontAwesome.Sharp.IconPictureBox pbUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private FontAwesome.Sharp.IconPictureBox pbPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMinimize;
        private FontAwesome.Sharp.IconButton btnInformation;
        private System.Windows.Forms.Button btnLogin;
    }
}