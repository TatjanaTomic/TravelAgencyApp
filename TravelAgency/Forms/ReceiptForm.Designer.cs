
namespace TravelAgency.Forms
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.gbReceipt = new System.Windows.Forms.GroupBox();
            this.tbSeat = new System.Windows.Forms.TextBox();
            this.tbBus = new System.Windows.Forms.TextBox();
            this.tbOffer = new System.Windows.Forms.TextBox();
            this.lbSeat = new System.Windows.Forms.Label();
            this.lbBus = new System.Windows.Forms.Label();
            this.lbOffer = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbJMB = new System.Windows.Forms.TextBox();
            this.lbJMB = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.gbReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReceipt
            // 
            resources.ApplyResources(this.gbReceipt, "gbReceipt");
            this.gbReceipt.BackColor = System.Drawing.Color.LightGray;
            this.gbReceipt.Controls.Add(this.tbSeat);
            this.gbReceipt.Controls.Add(this.tbBus);
            this.gbReceipt.Controls.Add(this.tbOffer);
            this.gbReceipt.Controls.Add(this.lbSeat);
            this.gbReceipt.Controls.Add(this.lbBus);
            this.gbReceipt.Controls.Add(this.lbOffer);
            this.gbReceipt.Controls.Add(this.tbLastName);
            this.gbReceipt.Controls.Add(this.lbLastName);
            this.gbReceipt.Controls.Add(this.btnCancel);
            this.gbReceipt.Controls.Add(this.btnSave);
            this.gbReceipt.Controls.Add(this.tbJMB);
            this.gbReceipt.Controls.Add(this.lbJMB);
            this.gbReceipt.Controls.Add(this.lbFirstName);
            this.gbReceipt.Controls.Add(this.tbFirstName);
            this.gbReceipt.Name = "gbReceipt";
            this.gbReceipt.TabStop = false;
            // 
            // tbSeat
            // 
            resources.ApplyResources(this.tbSeat, "tbSeat");
            this.tbSeat.Name = "tbSeat";
            this.tbSeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBus_KeyPress);
            // 
            // tbBus
            // 
            resources.ApplyResources(this.tbBus, "tbBus");
            this.tbBus.Name = "tbBus";
            this.tbBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBus_KeyPress);
            // 
            // tbOffer
            // 
            resources.ApplyResources(this.tbOffer, "tbOffer");
            this.tbOffer.Name = "tbOffer";
            this.tbOffer.ReadOnly = true;
            // 
            // lbSeat
            // 
            resources.ApplyResources(this.lbSeat, "lbSeat");
            this.lbSeat.Name = "lbSeat";
            // 
            // lbBus
            // 
            resources.ApplyResources(this.lbBus, "lbBus");
            this.lbBus.Name = "lbBus";
            // 
            // lbOffer
            // 
            resources.ApplyResources(this.lbOffer, "lbOffer");
            this.lbOffer.Name = "lbOffer";
            // 
            // tbLastName
            // 
            resources.ApplyResources(this.tbLastName, "tbLastName");
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            // 
            // lbLastName
            // 
            resources.ApplyResources(this.lbLastName, "lbLastName");
            this.lbLastName.Name = "lbLastName";
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
            // tbJMB
            // 
            resources.ApplyResources(this.tbJMB, "tbJMB");
            this.tbJMB.Name = "tbJMB";
            this.tbJMB.ReadOnly = true;
            // 
            // lbJMB
            // 
            resources.ApplyResources(this.lbJMB, "lbJMB");
            this.lbJMB.Name = "lbJMB";
            // 
            // lbFirstName
            // 
            resources.ApplyResources(this.lbFirstName, "lbFirstName");
            this.lbFirstName.Name = "lbFirstName";
            // 
            // tbFirstName
            // 
            resources.ApplyResources(this.tbFirstName, "tbFirstName");
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
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
            this.Column10,
            this.Column7,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column9});
            this.dataGridView.ContextMenuStrip = this.contextMenu;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
            // 
            // Column10
            // 
            resources.ApplyResources(this.Column10, "Column10");
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column7
            // 
            resources.ApplyResources(this.Column7, "Column7");
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
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
            // ReceiptForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.gbReceipt);
            this.Name = "ReceiptForm";
            this.gbReceipt.ResumeLayout(false);
            this.gbReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReceipt;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbJMB;
        private System.Windows.Forms.TextBox tbJMB;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrisiToolStripMenuItem;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.Label lbBus;
        private System.Windows.Forms.Label lbOffer;
        private System.Windows.Forms.TextBox tbSeat;
        private System.Windows.Forms.TextBox tbBus;
        private System.Windows.Forms.TextBox tbOffer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}