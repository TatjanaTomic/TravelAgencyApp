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
using TravelAgency.Data.DataAccess.Exceptions;
using TravelAgency.Data.Model;

namespace TravelAgency.Forms
{
    public partial class ReservationForm : Form
    {
        private readonly Account currentUser;
        private readonly ResourceManager rm;
        public ReservationForm(Account _currentUser)
        {
            rm = new ResourceManager("TravelAgency.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
            currentUser = _currentUser;
            InitializeComponent();
            FillGridReservations();
            FillListBoxOffers();
            FillListBoxTravellers();
            ClearSelectionDgw();
        }

        void FillGridReservations()
        {
            dataGridView.Rows.Clear();
            var activeOffers = Util.Common.DataFactory.Offers.GetActiveOffers("");
            var reservations = Util.Common.DataFactory.Reservations.GetReservations(tbFilter.Text);
            foreach (var r in reservations)
            {
                foreach (var a in activeOffers)
                    if (a.Id == r.Offer.Id)
                    { 
                        DataGridViewRow row = new DataGridViewRow()
                        {
                            Tag = r
                        };
                        row.CreateCells(dataGridView, r.DateOfReservation,
                                                      r.Manager.Id,
                                                      r.Traveller.Id,
                                                      r.Traveller.FirstName,
                                                      r.Traveller.LastName,
                                                      r.Traveller.Jmb,
                                                      r.Offer.Id,
                                                      r.Offer.Name);
                        dataGridView.Rows.Add(row);
                    }
            }
        }

        void FillListBoxOffers()
        {
            listBoxOffers.Items.Clear();
            var offers = Util.Common.DataFactory.Offers.GetActiveOffers(tbFilterOffers.Text);
            foreach (var o in offers)
            {
                listBoxOffers.Items.Add(o);
            }
            listBoxOffers.SelectedIndex = -1;
        }

        void FillListBoxTravellers()
        {
            listBoxTravellers.Items.Clear();
            var travellers = Util.Common.DataFactory.Travellers.GetTravellers(tbFilterTravellers.Text);
            foreach (var t in travellers)
            {
                listBoxTravellers.Items.Add(t);
            }
            listBoxTravellers.SelectedIndex = -1;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGridReservations();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }

        void ClearSelection()
        {
            tbSelectedOffer.Enabled = false;
            tbSelectedOffer.Visible = false;
            tbFilterOffers.Enabled = true;
            tbFilterOffers.Visible = true;
            tbFilterOffers.Text = "";
            tbSelectedTraveller.Enabled = false;
            tbSelectedTraveller.Visible = false;
            tbFilterTravellers.Enabled = true;
            tbFilterTravellers.Visible = true;
            tbFilterTravellers.Text = "";
            listBoxOffers.SelectedIndex = -1;
            listBoxTravellers.SelectedIndex = -1;
        }
        private void tbOffers_TextChanged(object sender, EventArgs e)
        {
            FillListBoxOffers();
            ClearSelectionDgw();
        }

        private void tbTravellers_TextChanged(object sender, EventArgs e)
        {
            FillListBoxTravellers();
        }

        private void ClearSelectionDgw()
        {
            for (int i = 0; i < dataGridView.Rows.Count; ++i)
                dataGridView.Rows[i].Selected = false;
        }

        private void listBoxOffers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxOffers.SelectedIndex != -1)
            {
                tbSelectedOffer.Text = listBoxOffers.SelectedItem.ToString();
                tbFilterOffers.Enabled = false;
                tbFilterOffers.Visible = false;
                tbSelectedOffer.Enabled = true;
                tbSelectedOffer.Visible = true;
            }
        }

        private void listBoxTravellers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTravellers.SelectedIndex != -1)
            {
                tbSelectedTraveller.Text = listBoxTravellers.SelectedItem.ToString();
                tbFilterTravellers.Enabled = false;
                tbFilterTravellers.Visible = false;
                tbSelectedTraveller.Enabled = true;
                tbSelectedTraveller.Visible = true;
            }
        }

        private void btnClearTraveller_Click(object sender, EventArgs e)
        {
            tbSelectedTraveller.Text = "";
            tbSelectedTraveller.Enabled = false;
            tbSelectedTraveller.Visible = false;
            tbFilterTravellers.Enabled = true;
            tbFilterTravellers.Visible = true;
            tbFilterTravellers.Text = "";
        }

        private void btnClearOffer_Click(object sender, EventArgs e)
        {
            tbSelectedOffer.Text = "";
            tbSelectedOffer.Enabled = false;
            tbSelectedOffer.Visible = false;
            tbFilterOffers.Enabled = true;
            tbFilterOffers.Visible = true;
            tbFilterOffers.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
           if(listBoxTravellers.SelectedIndex != -1 && listBoxOffers.SelectedIndex != -1)
           {
                try
                {
                    var traveller = (Traveller)listBoxTravellers.SelectedItem;
                    var offer = (Offer)listBoxOffers.SelectedItem;
                    Util.Common.DataFactory.Reservations.InsertReservation(currentUser.Employee.Id, traveller.Id, offer.Id);
                    FillGridReservations();
                    MessageBox.Show(rm.GetString("AddReservation"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(rm.GetString("AddReservationError") + "\n" + rm.GetString("String13"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           }
           else
           {
                MessageBox.Show(rm.GetString("TravellerOffer"), rm.GetString("IncompleteEntry"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
            ClearSelection();
        }


        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            contextMenu.Items[0].Enabled = false;

            if (e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
                contextMenu.Items[0].Enabled = true;
            }
        }

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView.SelectedRows[0];
            var firstName = selectedRow.Cells[3].Value.ToString();
            var lastName = selectedRow.Cells[4].Value.ToString();
            var jmb = selectedRow.Cells[5].Value.ToString();
            var offerName = selectedRow.Cells[7].Value.ToString();
            var _travellerID = Int32.Parse(selectedRow.Cells[2].Value.ToString());
            var _offerID = Int32.Parse(selectedRow.Cells[6].Value.ToString());
            string message;

            if (Util.Common.DataFactory.Receipts.CheckIfExists(_offerID, _travellerID) == 1)
                message = rm.GetString("DeleteReservationConf");
            else
                message = rm.GetString("DeleteResConf");

            var result = MessageBox.Show(message  + "\n\n" + rm.GetString("Traveller") 
                                                + firstName + " " + lastName + " " + jmb + 
                                                "\n" + rm.GetString("Offer") + offerName,
                                        rm.GetString("DeleteConf"),
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.Yes))
            {
                try
                {

                    Util.Common.DataFactory.Reservations.DeleteReservation(_travellerID, _offerID);

                    listBoxOffers.SelectedIndex = -1;
                    listBoxTravellers.SelectedIndex = -1;
                    MessageBox.Show(rm.GetString("DeleteData"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show(rm.GetString("DeleteDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                FillGridReservations();
            }
            else
            {

            }
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(rm.GetString("ChooseReservation"), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var selectedRow = dataGridView.SelectedRows[0];
                var firstName = selectedRow.Cells[3].Value.ToString();
                var lastName = selectedRow.Cells[4].Value.ToString();
                var jmb = selectedRow.Cells[5].Value.ToString();
                var offerName = selectedRow.Cells[7].Value.ToString();
                var travellerID = Int32.Parse(selectedRow.Cells[2].Value.ToString());
                var offerID = Int32.Parse(selectedRow.Cells[6].Value.ToString());

                var offers = Util.Common.DataFactory.Offers.GetActiveOffers("");
                var activeFlag = false;
                foreach (var o in offers)
                    if (o.Id == offerID)
                    {
                        activeFlag = true;
                    }

                if (activeFlag)
                {
                    if (Util.Common.DataFactory.Receipts.CheckIfExists(offerID, travellerID) == 1)
                    {
                        MessageBox.Show(rm.GetString("ReceiptError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        new NewReceiptForm(offerID, offerName, travellerID, firstName + " " + lastName + " " + jmb).ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show(rm.GetString("EndedOfferError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
