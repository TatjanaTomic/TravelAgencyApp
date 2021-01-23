
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnlUserInformation = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.pnlUserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(29)))), ((int)(((byte)(86)))));
            this.panelMenu.Controls.Add(this.iconButton3);
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.pnlUserInformation);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.DarkGray;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton3.IconColor = System.Drawing.Color.DarkGray;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 45;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 284);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(200, 48);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "iconButton3";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.DarkGray;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton2.IconColor = System.Drawing.Color.DarkGray;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 45;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 236);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(200, 48);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.DarkGray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton1.IconColor = System.Drawing.Color.DarkGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 45;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 188);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 48);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // pnlUserInformation
            // 
            this.pnlUserInformation.Controls.Add(this.lbUser);
            this.pnlUserInformation.Controls.Add(this.pbUser);
            this.pnlUserInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInformation.Location = new System.Drawing.Point(0, 0);
            this.pnlUserInformation.Name = "pnlUserInformation";
            this.pnlUserInformation.Size = new System.Drawing.Size(200, 188);
            this.pnlUserInformation.TabIndex = 0;
            // 
            // lbUser
            // 
            this.lbUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbUser.ForeColor = System.Drawing.Color.DarkGray;
            this.lbUser.Location = new System.Drawing.Point(0, 113);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(200, 75);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "IME PREZIME";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbUser
            // 
            this.pbUser.BackgroundImage = global::TravelAgency.Properties.Resources.userIcon;
            this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUser.Image = global::TravelAgency.Properties.Resources.userIcon;
            this.pbUser.Location = new System.Drawing.Point(49, 22);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(102, 88);
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 450);
            this.panel1.TabIndex = 1;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.panelMenu.ResumeLayout(false);
            this.pnlUserInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel pnlUserInformation;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Panel panel1;

    }
}