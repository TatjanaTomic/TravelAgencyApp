
namespace TravelAgency.Forms
{
    partial class NewReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReceiptForm));
            this.lbOffer = new System.Windows.Forms.Label();
            this.lbPutnik = new System.Windows.Forms.Label();
            this.lbOfferInfo = new System.Windows.Forms.Label();
            this.lbTravellerInfo = new System.Windows.Forms.Label();
            this.lbSeatNumber = new System.Windows.Forms.Label();
            this.lbBusNumber = new System.Windows.Forms.Label();
            this.tbBus = new System.Windows.Forms.TextBox();
            this.tbSeat = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOffer
            // 
            resources.ApplyResources(this.lbOffer, "lbOffer");
            this.lbOffer.Name = "lbOffer";
            // 
            // lbPutnik
            // 
            resources.ApplyResources(this.lbPutnik, "lbPutnik");
            this.lbPutnik.Name = "lbPutnik";
            // 
            // lbOfferInfo
            // 
            resources.ApplyResources(this.lbOfferInfo, "lbOfferInfo");
            this.lbOfferInfo.Name = "lbOfferInfo";
            // 
            // lbTravellerInfo
            // 
            resources.ApplyResources(this.lbTravellerInfo, "lbTravellerInfo");
            this.lbTravellerInfo.Name = "lbTravellerInfo";
            // 
            // lbSeatNumber
            // 
            resources.ApplyResources(this.lbSeatNumber, "lbSeatNumber");
            this.lbSeatNumber.Name = "lbSeatNumber";
            // 
            // lbBusNumber
            // 
            resources.ApplyResources(this.lbBusNumber, "lbBusNumber");
            this.lbBusNumber.Name = "lbBusNumber";
            // 
            // tbBus
            // 
            resources.ApplyResources(this.tbBus, "tbBus");
            this.tbBus.Name = "tbBus";
            this.tbBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBus_KeyPress);
            // 
            // tbSeat
            // 
            resources.ApplyResources(this.tbSeat, "tbSeat");
            this.tbSeat.Name = "tbSeat";
            this.tbSeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBus_KeyPress);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // NewReceiptForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbSeat);
            this.Controls.Add(this.tbBus);
            this.Controls.Add(this.lbSeatNumber);
            this.Controls.Add(this.lbBusNumber);
            this.Controls.Add(this.lbTravellerInfo);
            this.Controls.Add(this.lbOfferInfo);
            this.Controls.Add(this.lbPutnik);
            this.Controls.Add(this.lbOffer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewReceiptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOffer;
        private System.Windows.Forms.Label lbPutnik;
        private System.Windows.Forms.Label lbOfferInfo;
        private System.Windows.Forms.Label lbTravellerInfo;
        private System.Windows.Forms.Label lbSeatNumber;
        private System.Windows.Forms.Label lbBusNumber;
        private System.Windows.Forms.TextBox tbBus;
        private System.Windows.Forms.TextBox tbSeat;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}