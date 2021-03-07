
namespace TravelAgency.Forms
{
    partial class TripForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripForm));
            this.gbTrip = new System.Windows.Forms.GroupBox();
            this.tbTravelInsurance = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbTouristTax = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbTouristTax = new System.Windows.Forms.CheckBox();
            this.cbTravelInsurance = new System.Windows.Forms.CheckBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.lbDeparture = new System.Windows.Forms.Label();
            this.lbReturn = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.gbTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTrip
            // 
            resources.ApplyResources(this.gbTrip, "gbTrip");
            this.gbTrip.BackColor = System.Drawing.Color.LightGray;
            this.gbTrip.Controls.Add(this.tbTravelInsurance);
            this.gbTrip.Controls.Add(this.btnCancel);
            this.gbTrip.Controls.Add(this.btnSave);
            this.gbTrip.Controls.Add(this.tbTouristTax);
            this.gbTrip.Controls.Add(this.tbPrice);
            this.gbTrip.Controls.Add(this.cbTouristTax);
            this.gbTrip.Controls.Add(this.cbTravelInsurance);
            this.gbTrip.Controls.Add(this.lbPrice);
            this.gbTrip.Controls.Add(this.dtpReturn);
            this.gbTrip.Controls.Add(this.dtpDeparture);
            this.gbTrip.Controls.Add(this.lbDeparture);
            this.gbTrip.Controls.Add(this.lbReturn);
            this.gbTrip.Controls.Add(this.lbDate);
            this.gbTrip.Controls.Add(this.dtpDate);
            this.gbTrip.Controls.Add(this.lbName);
            this.gbTrip.Controls.Add(this.tbName);
            this.gbTrip.Name = "gbTrip";
            this.gbTrip.TabStop = false;
            // 
            // tbTravelInsurance
            // 
            resources.ApplyResources(this.tbTravelInsurance, "tbTravelInsurance");
            this.tbTravelInsurance.Name = "tbTravelInsurance";
            this.tbTravelInsurance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTravelInsurance_KeyPress);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbTouristTax
            // 
            resources.ApplyResources(this.tbTouristTax, "tbTouristTax");
            this.tbTouristTax.Name = "tbTouristTax";
            this.tbTouristTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTravelInsurance_KeyPress);
            // 
            // tbPrice
            // 
            resources.ApplyResources(this.tbPrice, "tbPrice");
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTravelInsurance_KeyPress);
            // 
            // cbTouristTax
            // 
            resources.ApplyResources(this.cbTouristTax, "cbTouristTax");
            this.cbTouristTax.Name = "cbTouristTax";
            this.cbTouristTax.UseVisualStyleBackColor = true;
            this.cbTouristTax.CheckedChanged += new System.EventHandler(this.cbTouristTax_CheckedChanged);
            // 
            // cbTravelInsurance
            // 
            resources.ApplyResources(this.cbTravelInsurance, "cbTravelInsurance");
            this.cbTravelInsurance.Name = "cbTravelInsurance";
            this.cbTravelInsurance.UseVisualStyleBackColor = true;
            this.cbTravelInsurance.CheckedChanged += new System.EventHandler(this.cbTravelInsurance_CheckedChanged);
            // 
            // lbPrice
            // 
            resources.ApplyResources(this.lbPrice, "lbPrice");
            this.lbPrice.Name = "lbPrice";
            // 
            // dtpReturn
            // 
            resources.ApplyResources(this.dtpReturn, "dtpReturn");
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.ShowUpDown = true;
            // 
            // dtpDeparture
            // 
            resources.ApplyResources(this.dtpDeparture, "dtpDeparture");
            this.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.ShowUpDown = true;
            // 
            // lbDeparture
            // 
            resources.ApplyResources(this.lbDeparture, "lbDeparture");
            this.lbDeparture.Name = "lbDeparture";
            // 
            // lbReturn
            // 
            resources.ApplyResources(this.lbReturn, "lbReturn");
            this.lbReturn.Name = "lbReturn";
            // 
            // lbDate
            // 
            resources.ApplyResources(this.lbDate, "lbDate");
            this.lbDate.Name = "lbDate";
            // 
            // dtpDate
            // 
            resources.ApplyResources(this.dtpDate, "dtpDate");
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Name = "dtpDate";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
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
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
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
            // Column10
            // 
            resources.ApplyResources(this.Column10, "Column10");
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            resources.ApplyResources(this.Column11, "Column11");
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            resources.ApplyResources(this.Column12, "Column12");
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urediToolStripMenuItem,
            this.obrisiToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            resources.ApplyResources(this.contextMenu, "contextMenu");
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
            this.panelFilter.Controls.Add(this.tbFilter);
            this.panelFilter.Controls.Add(this.lbFilter);
            resources.ApplyResources(this.panelFilter, "panelFilter");
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
            // TripForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gbTrip);
            this.Name = "TripForm";
            this.gbTrip.ResumeLayout(false);
            this.gbTrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTrip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbDeparture;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.Label lbReturn;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.CheckBox cbTravelInsurance;
        private System.Windows.Forms.CheckBox cbTouristTax;
        private System.Windows.Forms.TextBox tbTouristTax;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbTravelInsurance;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
    }
}