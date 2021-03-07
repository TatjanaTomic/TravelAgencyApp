
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
            this.btnSerbian = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.pnlUsername, "pnlUsername");
            this.pnlUsername.Name = "pnlUsername";
            // 
            // pbUsername
            // 
            this.pbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.pbUsername.BackgroundImage = global::TravelAgency.Properties.Resources.profileIcon1;
            resources.ApplyResources(this.pbUsername, "pbUsername");
            this.pbUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbUsername.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pbUsername.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbUsername.IconSize = 50;
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.TabStop = false;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.ForeColor = System.Drawing.Color.Silver;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Click += new System.EventHandler(this.tbUsername_Click);
            this.tbUsername.DoubleClick += new System.EventHandler(this.tbUsername_Click);
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.tbPassword);
            this.pnlPassword.Controls.Add(this.pbPassword);
            resources.ApplyResources(this.pnlPassword, "pnlPassword");
            this.pnlPassword.Name = "pnlPassword";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.ForeColor = System.Drawing.Color.Silver;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.DoubleClick += new System.EventHandler(this.tbPassword_Click);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Click);
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.pbPassword.BackgroundImage = global::TravelAgency.Properties.Resources.passwordIcon1;
            resources.ApplyResources(this.pbPassword, "pbPassword");
            this.pbPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbPassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pbPassword.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbPassword.IconSize = 39;
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.TabStop = false;
            this.pbPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPassword_MouseDown);
            this.pbPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPassword_MouseUp);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.btnInformation.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.btnInformation, "btnInformation");
            this.btnInformation.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnInformation.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.btnInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformation.IconSize = 35;
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(129)))), ((int)(((byte)(172)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSerbian
            // 
            this.btnSerbian.BackgroundImage = global::TravelAgency.Properties.Resources.srpski;
            resources.ApplyResources(this.btnSerbian, "btnSerbian");
            this.btnSerbian.Name = "btnSerbian";
            this.btnSerbian.UseVisualStyleBackColor = true;
            this.btnSerbian.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackgroundImage = global::TravelAgency.Properties.Resources.engleski;
            resources.ApplyResources(this.btnEnglish, "btnEnglish");
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.button2_Click);
            // 
            // NewLoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TravelAgency.Properties.Resources.final;
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnSerbian);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "NewLoginForm";
            this.Load += new System.EventHandler(this.NewLoginForm_Load);
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
        private System.Windows.Forms.Button btnSerbian;
        private System.Windows.Forms.Button btnEnglish;
    }
}