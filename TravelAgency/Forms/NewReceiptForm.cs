using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Data.Model;

namespace TravelAgency.Forms
{
    public partial class NewReceiptForm : Form
    {
        private readonly int _offerID;
        private readonly int _travellerID;
        private readonly ResourceManager rm;
 
        public NewReceiptForm(int offerID, string offer, int travellerID, string traveller)
        {
            _offerID = offerID;
            _travellerID = travellerID;
            rm = new ResourceManager("TravelAgency.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());

            InitializeComponent();
            lbOfferInfo.Text = offer;
            lbTravellerInfo.Text = traveller;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbBus.Text.Trim();
            tbSeat.Text.Trim();
            Receipt r = null;
            if(tbBus.Text.Equals("") || tbBus.Text.Equals(""))
            {
                MessageBox.Show(rm.GetString("BusSeat"), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    r = new Receipt()
                    {
                        Offer = new Offer()
                        {
                            Id = _offerID
                        },
                        Traveller = new Traveller()
                        {
                            Id = _travellerID
                        },
                        NumberOfBus = Int32.Parse(tbBus.Text),
                        NumberOfSeat = Int32.Parse(tbSeat.Text)
                    };
                }
                catch
                {
                    MessageBox.Show(rm.GetString("BusSeatError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (r != null)
                {
                    var reserved = Util.Common.DataFactory.Receipts.CheckSeat(r);
                    if (reserved == 0)
                    {
                        try
                        {
                            Util.Common.DataFactory.Receipts.InsertReceipt(r);
                            MessageBox.Show(rm.GetString("AddReceipt"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch
                        {
                            MessageBox.Show(rm.GetString("AddReceiptError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (reserved > 0)
                    {
                        MessageBox.Show(rm.GetString("Seat") + r.NumberOfSeat + rm.GetString("InABus") + r.NumberOfBus + rm.GetString("Reserved"), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(rm.GetString("AddReceiptError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbBus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
