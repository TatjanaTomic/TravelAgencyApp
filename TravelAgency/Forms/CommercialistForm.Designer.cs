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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnAllOffers = new FontAwesome.Sharp.IconButton();
            this.btnTrips = new FontAwesome.Sharp.IconButton();
            this.btnTravels = new FontAwesome.Sharp.IconButton();
            this.pnlUserInformation = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pnlTravels = new System.Windows.Forms.Panel();
            this.dgvTravels = new System.Windows.Forms.DataGridView();
            this.IdTravel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOffers = new System.Windows.Forms.Panel();
            this.dgvOffers = new System.Windows.Forms.DataGridView();
            this.OfferId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommercialistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommercialistLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTrips = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lbTravelAgency = new System.Windows.Forms.Label();
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlUserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.pnlTravels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravels)).BeginInit();
            this.pnlOffers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.pnlMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
            this.splitContainer.Panel1.Controls.Add(this.btnAllOffers);
            this.splitContainer.Panel1.Controls.Add(this.btnTrips);
            this.splitContainer.Panel1.Controls.Add(this.btnTravels);
            this.splitContainer.Panel1.Controls.Add(this.pnlUserInformation);
            this.splitContainer.Panel1MinSize = 200;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlTravels);
            this.splitContainer.Panel2.Controls.Add(this.pnlOffers);
            this.splitContainer.Panel2.Controls.Add(this.pnlTrips);
            this.splitContainer.Panel2.Controls.Add(this.pnlHome);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 2;
            // 
            // btnAllOffers
            // 
            this.btnAllOffers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAllOffers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllOffers.FlatAppearance.BorderSize = 0;
            this.btnAllOffers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllOffers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAllOffers.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnAllOffers.IconColor = System.Drawing.SystemColors.Control;
            this.btnAllOffers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAllOffers.IconSize = 45;
            this.btnAllOffers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllOffers.Location = new System.Drawing.Point(0, 194);
            this.btnAllOffers.Name = "btnAllOffers";
            this.btnAllOffers.Size = new System.Drawing.Size(200, 50);
            this.btnAllOffers.TabIndex = 0;
            this.btnAllOffers.Text = "&Sve ponude";
            this.btnAllOffers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllOffers.UseVisualStyleBackColor = true;
            this.btnAllOffers.Click += new System.EventHandler(this.btnAllOffers_Click);
            // 
            // btnTrips
            // 
            this.btnTrips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTrips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrips.FlatAppearance.BorderSize = 0;
            this.btnTrips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrips.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrips.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTrips.IconChar = FontAwesome.Sharp.IconChar.Hiking;
            this.btnTrips.IconColor = System.Drawing.SystemColors.Control;
            this.btnTrips.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrips.IconSize = 45;
            this.btnTrips.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrips.Location = new System.Drawing.Point(0, 304);
            this.btnTrips.Name = "btnTrips";
            this.btnTrips.Size = new System.Drawing.Size(200, 50);
            this.btnTrips.TabIndex = 2;
            this.btnTrips.Text = "&Izleti";
            this.btnTrips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrips.UseVisualStyleBackColor = true;
            this.btnTrips.Click += new System.EventHandler(this.btnTrips_Click);
            // 
            // btnTravels
            // 
            this.btnTravels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTravels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTravels.FlatAppearance.BorderSize = 0;
            this.btnTravels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTravels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTravels.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTravels.IconChar = FontAwesome.Sharp.IconChar.GlobeAmericas;
            this.btnTravels.IconColor = System.Drawing.SystemColors.Control;
            this.btnTravels.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTravels.IconSize = 45;
            this.btnTravels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTravels.Location = new System.Drawing.Point(0, 248);
            this.btnTravels.Name = "btnTravels";
            this.btnTravels.Size = new System.Drawing.Size(200, 50);
            this.btnTravels.TabIndex = 1;
            this.btnTravels.Text = "&Putovanja";
            this.btnTravels.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTravels.UseVisualStyleBackColor = true;
            this.btnTravels.Click += new System.EventHandler(this.btnTravels_Click);
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
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.Control;
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
            // pnlTravels
            // 
            this.pnlTravels.Controls.Add(this.dgvTravels);
            this.pnlTravels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTravels.Location = new System.Drawing.Point(0, 64);
            this.pnlTravels.Name = "pnlTravels";
            this.pnlTravels.Size = new System.Drawing.Size(599, 386);
            this.pnlTravels.TabIndex = 3;
            this.pnlTravels.Visible = false;
            // 
            // dgvTravels
            // 
            this.dgvTravels.AllowUserToAddRows = false;
            this.dgvTravels.AllowUserToDeleteRows = false;
            this.dgvTravels.AllowUserToResizeRows = false;
            this.dgvTravels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTravels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTravels.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvTravels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTravels.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTravel,
            this.TravelName});
            this.dgvTravels.Location = new System.Drawing.Point(0, 0);
            this.dgvTravels.Name = "dgvTravels";
            this.dgvTravels.ReadOnly = true;
            this.dgvTravels.RowHeadersVisible = false;
            this.dgvTravels.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTravels.Size = new System.Drawing.Size(599, 387);
            this.dgvTravels.TabIndex = 2;
            // 
            // IdTravel
            // 
            this.IdTravel.HeaderText = "IdTravel";
            this.IdTravel.Name = "IdTravel";
            this.IdTravel.ReadOnly = true;
            // 
            // TravelName
            // 
            this.TravelName.HeaderText = "Naziv";
            this.TravelName.Name = "TravelName";
            this.TravelName.ReadOnly = true;
            // 
            // pnlOffers
            // 
            this.pnlOffers.Controls.Add(this.dgvOffers);
            this.pnlOffers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOffers.Location = new System.Drawing.Point(0, 64);
            this.pnlOffers.Name = "pnlOffers";
            this.pnlOffers.Size = new System.Drawing.Size(599, 386);
            this.pnlOffers.TabIndex = 3;
            this.pnlOffers.Visible = false;
            // 
            // dgvOffers
            // 
            this.dgvOffers.AllowUserToAddRows = false;
            this.dgvOffers.AllowUserToDeleteRows = false;
            this.dgvOffers.AllowUserToResizeRows = false;
            this.dgvOffers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOffers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOffers.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvOffers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOffers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOffers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OfferId,
            this.OfferName,
            this.CommercialistName,
            this.CommercialistLastName,
            this.Price});
            this.dgvOffers.Location = new System.Drawing.Point(0, 0);
            this.dgvOffers.Name = "dgvOffers";
            this.dgvOffers.ReadOnly = true;
            this.dgvOffers.RowHeadersVisible = false;
            this.dgvOffers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvOffers.Size = new System.Drawing.Size(599, 387);
            this.dgvOffers.TabIndex = 1;
            // 
            // OfferId
            // 
            this.OfferId.HeaderText = "ID Ponude";
            this.OfferId.MinimumWidth = 30;
            this.OfferId.Name = "OfferId";
            this.OfferId.ReadOnly = true;
            // 
            // OfferName
            // 
            this.OfferName.HeaderText = "Naziv ponude";
            this.OfferName.Name = "OfferName";
            this.OfferName.ReadOnly = true;
            // 
            // CommercialistName
            // 
            this.CommercialistName.HeaderText = "Datum kreiranja";
            this.CommercialistName.Name = "CommercialistName";
            this.CommercialistName.ReadOnly = true;
            // 
            // CommercialistLastName
            // 
            this.CommercialistLastName.HeaderText = "Kreirao/la";
            this.CommercialistLastName.Name = "CommercialistLastName";
            this.CommercialistLastName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Cijena";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // pnlTrips
            // 
            this.pnlTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrips.Location = new System.Drawing.Point(0, 64);
            this.pnlTrips.Name = "pnlTrips";
            this.pnlTrips.Size = new System.Drawing.Size(599, 386);
            this.pnlTrips.TabIndex = 3;
            this.pnlTrips.Visible = false;
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.pnlHome.Controls.Add(this.lbTravelAgency);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(599, 64);
            this.pnlHome.TabIndex = 0;
            // 
            // lbTravelAgency
            // 
            this.lbTravelAgency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTravelAgency.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTravelAgency.Location = new System.Drawing.Point(3, 0);
            this.lbTravelAgency.Name = "lbTravelAgency";
            this.lbTravelAgency.Size = new System.Drawing.Size(307, 64);
            this.lbTravelAgency.TabIndex = 0;
            this.lbTravelAgency.Text = "TURISTICKA AGENCIJA";
            this.lbTravelAgency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.BackColor = System.Drawing.Color.Silver;
            this.pnlMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMainPanel.Controls.Add(this.splitContainer);
            this.pnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(800, 450);
            this.pnlMainPanel.TabIndex = 1;
            // 
            // CommercialistForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMainPanel);
            this.Name = "CommercialistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommercialistForm";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlUserInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.pnlTravels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravels)).EndInit();
            this.pnlOffers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffers)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlMainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private FontAwesome.Sharp.IconButton btnTrips;
        private FontAwesome.Sharp.IconButton btnTravels;
        private FontAwesome.Sharp.IconButton btnAllOffers;
        private System.Windows.Forms.Panel pnlUserInformation;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lbTravelAgency;
        private System.Windows.Forms.DataGridView dgvOffers;
        private System.Windows.Forms.DataGridView dgvTravels;
        //private System.Windows.Forms.DataGridView dgvTrips;
        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.Panel pnlOffers;
        private System.Windows.Forms.Panel pnlTravels;
        private System.Windows.Forms.Panel pnlTrips;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommercialistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommercialistLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTravel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelName;
    }
}