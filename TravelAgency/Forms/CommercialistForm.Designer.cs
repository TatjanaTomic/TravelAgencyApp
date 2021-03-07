
namespace TravelAgency.Forms
{
    partial class CommercialistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommercialistForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnAllOffers = new FontAwesome.Sharp.IconButton();
            this.btnTrips = new FontAwesome.Sharp.IconButton();
            this.btnTravels = new FontAwesome.Sharp.IconButton();
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
            this.panelMenu.Controls.Add(this.btnAllOffers);
            this.panelMenu.Controls.Add(this.btnTrips);
            this.panelMenu.Controls.Add(this.btnTravels);
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
            // btnAllOffers
            // 
            resources.ApplyResources(this.btnAllOffers, "btnAllOffers");
            this.btnAllOffers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllOffers.FlatAppearance.BorderSize = 0;
            this.btnAllOffers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAllOffers.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnAllOffers.IconColor = System.Drawing.SystemColors.Control;
            this.btnAllOffers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAllOffers.IconSize = 45;
            this.btnAllOffers.Name = "btnAllOffers";
            this.btnAllOffers.UseVisualStyleBackColor = true;
            this.btnAllOffers.Click += new System.EventHandler(this.btnAllOffers_Click);
            // 
            // btnTrips
            // 
            resources.ApplyResources(this.btnTrips, "btnTrips");
            this.btnTrips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrips.FlatAppearance.BorderSize = 0;
            this.btnTrips.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTrips.IconChar = FontAwesome.Sharp.IconChar.Hiking;
            this.btnTrips.IconColor = System.Drawing.SystemColors.Control;
            this.btnTrips.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrips.IconSize = 45;
            this.btnTrips.Name = "btnTrips";
            this.btnTrips.UseVisualStyleBackColor = true;
            this.btnTrips.Click += new System.EventHandler(this.btnTrips_Click);
            // 
            // btnTravels
            // 
            resources.ApplyResources(this.btnTravels, "btnTravels");
            this.btnTravels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTravels.FlatAppearance.BorderSize = 0;
            this.btnTravels.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTravels.IconChar = FontAwesome.Sharp.IconChar.GlobeAmericas;
            this.btnTravels.IconColor = System.Drawing.SystemColors.Control;
            this.btnTravels.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTravels.IconSize = 45;
            this.btnTravels.Name = "btnTravels";
            this.btnTravels.UseVisualStyleBackColor = true;
            this.btnTravels.Click += new System.EventHandler(this.btnTravels_Click);
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
            // CommercialistForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CommercialistForm";
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
        private FontAwesome.Sharp.IconButton btnTrips;
        private FontAwesome.Sharp.IconButton btnTravels;
        private FontAwesome.Sharp.IconButton btnAllOffers;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbTravelAgency;
        private System.Windows.Forms.PictureBox pbUser;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}