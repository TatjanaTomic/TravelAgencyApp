
namespace TravelAgency.Forms
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.gbReservation = new System.Windows.Forms.GroupBox();
            this.tbSelectedOffer = new System.Windows.Forms.TextBox();
            this.tbSelectedTraveller = new System.Windows.Forms.TextBox();
            this.btnClearOffer = new System.Windows.Forms.Button();
            this.btnClearTraveller = new System.Windows.Forms.Button();
            this.listBoxTravellers = new System.Windows.Forms.ListBox();
            this.tbFilterTravellers = new System.Windows.Forms.TextBox();
            this.listBoxOffers = new System.Windows.Forms.ListBox();
            this.tbFilterOffers = new System.Windows.Forms.TextBox();
            this.labelOffer = new System.Windows.Forms.Label();
            this.labelTraveller = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.btnAddReceipt = new System.Windows.Forms.Button();
            this.gbReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReservation
            // 
            resources.ApplyResources(this.gbReservation, "gbReservation");
            this.gbReservation.BackColor = System.Drawing.Color.LightGray;
            this.gbReservation.Controls.Add(this.tbSelectedOffer);
            this.gbReservation.Controls.Add(this.tbSelectedTraveller);
            this.gbReservation.Controls.Add(this.btnClearOffer);
            this.gbReservation.Controls.Add(this.btnClearTraveller);
            this.gbReservation.Controls.Add(this.listBoxTravellers);
            this.gbReservation.Controls.Add(this.tbFilterTravellers);
            this.gbReservation.Controls.Add(this.listBoxOffers);
            this.gbReservation.Controls.Add(this.tbFilterOffers);
            this.gbReservation.Controls.Add(this.labelOffer);
            this.gbReservation.Controls.Add(this.labelTraveller);
            this.gbReservation.Controls.Add(this.btnCancel);
            this.gbReservation.Controls.Add(this.btnAddNew);
            this.gbReservation.Name = "gbReservation";
            this.gbReservation.TabStop = false;
            // 
            // tbSelectedOffer
            // 
            resources.ApplyResources(this.tbSelectedOffer, "tbSelectedOffer");
            this.tbSelectedOffer.Name = "tbSelectedOffer";
            this.tbSelectedOffer.ReadOnly = true;
            this.tbSelectedOffer.TabStop = false;
            // 
            // tbSelectedTraveller
            // 
            resources.ApplyResources(this.tbSelectedTraveller, "tbSelectedTraveller");
            this.tbSelectedTraveller.Name = "tbSelectedTraveller";
            this.tbSelectedTraveller.ReadOnly = true;
            this.tbSelectedTraveller.TabStop = false;
            // 
            // btnClearOffer
            // 
            resources.ApplyResources(this.btnClearOffer, "btnClearOffer");
            this.btnClearOffer.BackgroundImage = global::TravelAgency.Properties.Resources._90_905672_x_cross_close_symbol_icon_button_gui_close;
            this.btnClearOffer.FlatAppearance.BorderSize = 0;
            this.btnClearOffer.Name = "btnClearOffer";
            this.btnClearOffer.UseVisualStyleBackColor = true;
            this.btnClearOffer.Click += new System.EventHandler(this.btnClearOffer_Click);
            // 
            // btnClearTraveller
            // 
            resources.ApplyResources(this.btnClearTraveller, "btnClearTraveller");
            this.btnClearTraveller.BackgroundImage = global::TravelAgency.Properties.Resources._90_905672_x_cross_close_symbol_icon_button_gui_close;
            this.btnClearTraveller.FlatAppearance.BorderSize = 0;
            this.btnClearTraveller.Name = "btnClearTraveller";
            this.btnClearTraveller.UseVisualStyleBackColor = true;
            this.btnClearTraveller.Click += new System.EventHandler(this.btnClearTraveller_Click);
            // 
            // listBoxTravellers
            // 
            resources.ApplyResources(this.listBoxTravellers, "listBoxTravellers");
            this.listBoxTravellers.FormattingEnabled = true;
            this.listBoxTravellers.Name = "listBoxTravellers";
            this.listBoxTravellers.TabStop = false;
            this.listBoxTravellers.SelectedIndexChanged += new System.EventHandler(this.listBoxTravellers_SelectedIndexChanged);
            // 
            // tbFilterTravellers
            // 
            resources.ApplyResources(this.tbFilterTravellers, "tbFilterTravellers");
            this.tbFilterTravellers.Name = "tbFilterTravellers";
            this.tbFilterTravellers.TextChanged += new System.EventHandler(this.tbTravellers_TextChanged);
            // 
            // listBoxOffers
            // 
            resources.ApplyResources(this.listBoxOffers, "listBoxOffers");
            this.listBoxOffers.FormattingEnabled = true;
            this.listBoxOffers.Name = "listBoxOffers";
            this.listBoxOffers.TabStop = false;
            this.listBoxOffers.SelectedIndexChanged += new System.EventHandler(this.listBoxOffers_SelectedIndexChanged);
            // 
            // tbFilterOffers
            // 
            resources.ApplyResources(this.tbFilterOffers, "tbFilterOffers");
            this.tbFilterOffers.Name = "tbFilterOffers";
            this.tbFilterOffers.TextChanged += new System.EventHandler(this.tbOffers_TextChanged);
            // 
            // labelOffer
            // 
            resources.ApplyResources(this.labelOffer, "labelOffer");
            this.labelOffer.Name = "labelOffer";
            // 
            // labelTraveller
            // 
            resources.ApplyResources(this.labelTraveller, "labelTraveller");
            this.labelTraveller.Name = "labelTraveller";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNew
            // 
            resources.ApplyResources(this.btnAddNew, "btnAddNew");
            this.btnAddNew.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dataGridView
            // 
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView.ContextMenuStrip = this.contextMenu;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            resources.ApplyResources(this.Column5, "Column5");
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            resources.ApplyResources(this.Column6, "Column6");
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            resources.ApplyResources(this.Column8, "Column8");
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            resources.ApplyResources(this.Column9, "Column9");
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // contextMenu
            // 
            resources.ApplyResources(this.contextMenu, "contextMenu");
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrisiToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            // 
            // obrisiToolStripMenuItem
            // 
            resources.ApplyResources(this.obrisiToolStripMenuItem, "obrisiToolStripMenuItem");
            this.obrisiToolStripMenuItem.Name = "obrisiToolStripMenuItem";
            this.obrisiToolStripMenuItem.Click += new System.EventHandler(this.obrisiToolStripMenuItem_Click);
            // 
            // panelFilter
            // 
            resources.ApplyResources(this.panelFilter, "panelFilter");
            this.panelFilter.Controls.Add(this.tbFilter);
            this.panelFilter.Controls.Add(this.lbFilter);
            this.panelFilter.Name = "panelFilter";
            // 
            // tbFilter
            // 
            resources.ApplyResources(this.tbFilter, "tbFilter");
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // lbFilter
            // 
            resources.ApplyResources(this.lbFilter, "lbFilter");
            this.lbFilter.Name = "lbFilter";
            // 
            // btnAddReceipt
            // 
            resources.ApplyResources(this.btnAddReceipt, "btnAddReceipt");
            this.btnAddReceipt.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddReceipt.Name = "btnAddReceipt";
            this.btnAddReceipt.UseVisualStyleBackColor = false;
            this.btnAddReceipt.Click += new System.EventHandler(this.btnAddReceipt_Click);
            // 
            // ReservationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnAddReceipt);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gbReservation);
            this.Name = "ReservationForm";
            this.gbReservation.ResumeLayout(false);
            this.gbReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReservation;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label labelOffer;
        private System.Windows.Forms.Label labelTraveller;
        private System.Windows.Forms.TextBox tbFilterOffers;
        private System.Windows.Forms.ListBox listBoxOffers;
        private System.Windows.Forms.ListBox listBoxTravellers;
        private System.Windows.Forms.TextBox tbFilterTravellers;
        private System.Windows.Forms.Button btnClearOffer;
        private System.Windows.Forms.Button btnClearTraveller;
        private System.Windows.Forms.TextBox tbSelectedTraveller;
        private System.Windows.Forms.TextBox tbSelectedOffer;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
        private System.Windows.Forms.Button btnAddReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}