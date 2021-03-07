
namespace TravelAgency.Forms
{
    partial class BusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusForm));
            this.gbBus = new System.Windows.Forms.GroupBox();
            this.tbNumberOfSeats = new System.Windows.Forms.TextBox();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.lbNumberOfSeats = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbLicensePlate = new System.Windows.Forms.Label();
            this.tbLicensePlate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.gbBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBus
            // 
            resources.ApplyResources(this.gbBus, "gbBus");
            this.gbBus.BackColor = System.Drawing.Color.LightGray;
            this.gbBus.Controls.Add(this.tbNumberOfSeats);
            this.gbBus.Controls.Add(this.lbManufacturer);
            this.gbBus.Controls.Add(this.tbManufacturer);
            this.gbBus.Controls.Add(this.lbNumberOfSeats);
            this.gbBus.Controls.Add(this.btnCancel);
            this.gbBus.Controls.Add(this.tbModel);
            this.gbBus.Controls.Add(this.btnSave);
            this.gbBus.Controls.Add(this.lbModel);
            this.gbBus.Controls.Add(this.lbLicensePlate);
            this.gbBus.Controls.Add(this.tbLicensePlate);
            this.gbBus.Name = "gbBus";
            this.gbBus.TabStop = false;
            // 
            // tbNumberOfSeats
            // 
            resources.ApplyResources(this.tbNumberOfSeats, "tbNumberOfSeats");
            this.tbNumberOfSeats.Name = "tbNumberOfSeats";
            this.tbNumberOfSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumberOfSeats_KeyPress);
            // 
            // lbManufacturer
            // 
            resources.ApplyResources(this.lbManufacturer, "lbManufacturer");
            this.lbManufacturer.Name = "lbManufacturer";
            // 
            // tbManufacturer
            // 
            resources.ApplyResources(this.tbManufacturer, "tbManufacturer");
            this.tbManufacturer.Name = "tbManufacturer";
            // 
            // lbNumberOfSeats
            // 
            resources.ApplyResources(this.lbNumberOfSeats, "lbNumberOfSeats");
            this.lbNumberOfSeats.Name = "lbNumberOfSeats";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbModel
            // 
            resources.ApplyResources(this.tbModel, "tbModel");
            this.tbModel.Name = "tbModel";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbModel
            // 
            resources.ApplyResources(this.lbModel, "lbModel");
            this.lbModel.Name = "lbModel";
            // 
            // lbLicensePlate
            // 
            resources.ApplyResources(this.lbLicensePlate, "lbLicensePlate");
            this.lbLicensePlate.Name = "lbLicensePlate";
            // 
            // tbLicensePlate
            // 
            resources.ApplyResources(this.tbLicensePlate, "tbLicensePlate");
            this.tbLicensePlate.Name = "tbLicensePlate";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.ContextMenuStrip = this.contextMenu;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // contextMenu
            // 
            resources.ApplyResources(this.contextMenu, "contextMenu");
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urediToolStripMenuItem,
            this.obrisiToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            // 
            // urediToolStripMenuItem
            // 
            resources.ApplyResources(this.urediToolStripMenuItem, "urediToolStripMenuItem");
            this.urediToolStripMenuItem.Image = global::TravelAgency.Properties.Resources.edit;
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Click += new System.EventHandler(this.urediToolStripMenuItem_Click);
            // 
            // obrisiToolStripMenuItem
            // 
            resources.ApplyResources(this.obrisiToolStripMenuItem, "obrisiToolStripMenuItem");
            this.obrisiToolStripMenuItem.Image = global::TravelAgency.Properties.Resources.close_512;
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
            // BusForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gbBus);
            this.Name = "BusForm";
            this.gbBus.ResumeLayout(false);
            this.gbBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBus;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lbLicensePlate;
        private System.Windows.Forms.TextBox tbLicensePlate;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.Label lbNumberOfSeats;
        private System.Windows.Forms.TextBox tbNumberOfSeats;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}