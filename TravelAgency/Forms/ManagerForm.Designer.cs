
namespace TravelAgency.Forms
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnBuses = new FontAwesome.Sharp.IconButton();
            this.btnReservation = new FontAwesome.Sharp.IconButton();
            this.btnTraveller = new FontAwesome.Sharp.IconButton();
            this.btnReceipt = new FontAwesome.Sharp.IconButton();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lbTravelAgency = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.panelMenu.Controls.Add(this.iconButton4);
            this.panelMenu.Controls.Add(this.btnBuses);
            this.panelMenu.Controls.Add(this.btnReservation);
            this.panelMenu.Controls.Add(this.btnTraveller);
            this.panelMenu.Controls.Add(this.btnReceipt);
            this.panelMenu.Controls.Add(this.panelUser);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // iconButton4
            // 
            resources.ApplyResources(this.iconButton4, "iconButton4");
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.UserSlash;
            this.iconButton4.IconColor = System.Drawing.SystemColors.Control;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 45;
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnBuses
            // 
            resources.ApplyResources(this.btnBuses, "btnBuses");
            this.btnBuses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuses.FlatAppearance.BorderSize = 0;
            this.btnBuses.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuses.IconChar = FontAwesome.Sharp.IconChar.BusAlt;
            this.btnBuses.IconColor = System.Drawing.SystemColors.Control;
            this.btnBuses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuses.IconSize = 45;
            this.btnBuses.Name = "btnBuses";
            this.btnBuses.UseVisualStyleBackColor = true;
            this.btnBuses.Click += new System.EventHandler(this.btnBuses_Click);
            // 
            // btnReservation
            // 
            resources.ApplyResources(this.btnReservation, "btnReservation");
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReservation.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.btnReservation.IconColor = System.Drawing.SystemColors.Control;
            this.btnReservation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReservation.IconSize = 45;
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnTraveller
            // 
            resources.ApplyResources(this.btnTraveller, "btnTraveller");
            this.btnTraveller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraveller.FlatAppearance.BorderSize = 0;
            this.btnTraveller.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTraveller.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnTraveller.IconColor = System.Drawing.SystemColors.Control;
            this.btnTraveller.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTraveller.IconSize = 45;
            this.btnTraveller.Name = "btnTraveller";
            this.btnTraveller.UseVisualStyleBackColor = true;
            this.btnTraveller.Click += new System.EventHandler(this.btnTraveller_Click);
            // 
            // btnReceipt
            // 
            resources.ApplyResources(this.btnReceipt, "btnReceipt");
            this.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReceipt.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnReceipt.IconColor = System.Drawing.SystemColors.Control;
            this.btnReceipt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReceipt.IconSize = 45;
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.lbUser);
            this.panelUser.Controls.Add(this.pbUser);
            resources.ApplyResources(this.panelUser, "panelUser");
            this.panelUser.Name = "panelUser";
            // 
            // lbUser
            // 
            resources.ApplyResources(this.lbUser, "lbUser");
            this.lbUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUser.Name = "lbUser";
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImage = global::TravelAgency.Properties.Resources.userIcon;
            resources.ApplyResources(this.pbUser, "pbUser");
            this.pbUser.Image = global::TravelAgency.Properties.Resources.userIcon;
            this.pbUser.Name = "pbUser";
            this.pbUser.TabStop = false;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.panelHome.Controls.Add(this.iconButton3);
            this.panelHome.Controls.Add(this.iconButton2);
            this.panelHome.Controls.Add(this.iconButton1);
            this.panelHome.Controls.Add(this.lbTravelAgency);
            resources.ApplyResources(this.panelHome, "panelHome");
            this.panelHome.Name = "panelHome";
            this.panelHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHome_MouseDown);
            // 
            // iconButton3
            // 
            resources.ApplyResources(this.iconButton3, "iconButton3");
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton3.IconColor = System.Drawing.SystemColors.Control;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            resources.ApplyResources(this.iconButton2, "iconButton2");
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton2.IconColor = System.Drawing.SystemColors.Control;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            resources.ApplyResources(this.iconButton1, "iconButton1");
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton1.IconColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 33;
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lbTravelAgency
            // 
            resources.ApplyResources(this.lbTravelAgency, "lbTravelAgency");
            this.lbTravelAgency.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTravelAgency.Name = "lbTravelAgency";
            // 
            // panelDesktop
            // 
            resources.ApplyResources(this.panelDesktop, "panelDesktop");
            this.panelDesktop.Name = "panelDesktop";
            // 
            // ManagerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ManagerForm";
            this.ShowInTaskbar = false;
            this.panelMenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelUser;
        private FontAwesome.Sharp.IconButton btnTraveller;
        private FontAwesome.Sharp.IconButton btnReceipt;
        private FontAwesome.Sharp.IconButton btnReservation;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbTravelAgency;
        private System.Windows.Forms.PictureBox pbUser;
        private FontAwesome.Sharp.IconButton btnBuses;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}