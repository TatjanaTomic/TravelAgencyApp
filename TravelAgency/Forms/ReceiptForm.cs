using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Data.DataAccess.Exceptions;
using TravelAgency.Data.Model;
using System.Resources;

namespace TravelAgency.Forms
{
    public partial class ReceiptForm : Form
    {
        private readonly ResourceManager rm;
        public ReceiptForm()
        {
            rm = new ResourceManager("TravelAgency.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGridReceipts();
        }

        void FillGridReceipts()
        {
            dataGridView.Rows.Clear();
            var receipts = Util.Common.DataFactory.Receipts.GetReceipts(tbFilter.Text);
            foreach (var r in receipts)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = r
                };
                row.CreateCells(dataGridView, r.Id,
                                              r.DateOfCreation,
                                              r.Offer.Id,
                                              r.Offer.Name,
                                              r.Traveller.Id,
                                              r.Traveller.FirstName,
                                              r.Traveller.LastName,
                                              r.Traveller.Jmb,
                                              r.NumberOfBus,
                                              r.NumberOfSeat);
                dataGridView.Rows.Add(row);
            }
            ClearControls();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGridReceipts();
        }

        void ShowData()
        {
            gbReceipt.Enabled = true;
            try
            {
                var selectedRow = dataGridView.SelectedRows[0];
                tbFirstName.Text = selectedRow.Cells[5].Value.ToString();
                tbLastName.Text = selectedRow.Cells[6].Value.ToString();
                tbJMB.Text = selectedRow.Cells[7].Value.ToString();
                tbOffer.Text = selectedRow.Cells[3].Value.ToString();
                tbBus.Text = selectedRow.Cells[8].Value.ToString();
                tbSeat.Text = selectedRow.Cells[9].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            gbReceipt.Enabled = false;
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            contextMenu.Items[0].Enabled = false;
            contextMenu.Items[1].Enabled = false;

            if (e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }
                contextMenu.Items[0].Enabled = true;
                contextMenu.Items[1].Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TrimTextBoxes();
            if (tbBus.Text.Equals("") || tbSeat.Text.Equals(""))
            {
                MessageBox.Show(rm.GetString("BusSeat"), rm.GetString("IncompleteEntry"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Receipt r = null;
                try
                {
                    var selectedRow = dataGridView.SelectedRows[0];

                    r = new Receipt()
                    {
                        Id = (int)selectedRow.Cells[0].Value,
                        Offer = new Offer()
                        {
                            Id = (int)selectedRow.Cells[2].Value
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
                            Util.Common.DataFactory.Receipts.UpdateReceipt(r);
                            MessageBox.Show(rm.GetString("UpdateData"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillGridReceipts();
                            ClearControls();
                            gbReceipt.Enabled = false;
                        }
                        catch
                        {
                            MessageBox.Show(rm.GetString("UpdateDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (reserved > 0)
                    {
                        MessageBox.Show(rm.GetString("Seat") + r.NumberOfSeat + rm.GetString("InABus") + r.NumberOfBus + rm.GetString("Reserved"), "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(rm.GetString("UpdateDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void TrimTextBoxes()
        {
            tbBus.Text.Trim();
            tbSeat.Text.Trim();
        }

        void ClearControls()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbJMB.Text = "";
            tbOffer.Text = "";
            tbSeat.Text = "";
            tbBus.Text = "";
            for (int i = 0; i < dataGridView.Rows.Count; ++i)
                dataGridView.Rows[i].Selected = false;
        }

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView.SelectedRows[0];
            var _offerID = (int)selectedRow.Cells[2].Value;
            var _offer = selectedRow.Cells[3].Value.ToString();
            var _travellerID = (int)selectedRow.Cells[4].Value;
            var _firstName = selectedRow.Cells[5].Value.ToString();
            var _lastName = selectedRow.Cells[6].Value.ToString();
            var _jmb = selectedRow.Cells[7].Value.ToString();
            var result = MessageBox.Show(rm.GetString("DeleteReceiptConf") + "\n" + rm.GetString("Traveller") + _firstName + " " + _lastName + " " + _jmb + "\n" + rm.GetString("Offer") + _offer,
                            rm.GetString("DeleteConf"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                try
                {

                    Util.Common.DataFactory.Receipts.DeleteReceipt(Int32.Parse(selectedRow.Cells[0].Value.ToString()));
                    Util.Common.DataFactory.Reservations.DeleteReservation(_travellerID, _offerID);

                    FillGridReceipts();
                    ClearControls();
                    MessageBox.Show(rm.GetString("DeleteData"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(rm.GetString("DeleteDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillGridReceipts();
                gbReceipt.Enabled = false;
            }
            else
            {
                ClearControls();
                gbReceipt.Enabled = false;
            }
        }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowData();
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
