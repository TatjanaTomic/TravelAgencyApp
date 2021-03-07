using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Data.Model;

namespace TravelAgency.Forms
{
    public partial class TripForm : Form
    {
        private readonly Account currentUser;
        private readonly ResourceManager rm;
        public TripForm(Account currentUser)
        {
            rm = new ResourceManager("TravelAgency.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGridTrips();
            this.currentUser = currentUser;
        }
        void FillGridTrips()
        {
            dataGridView.Rows.Clear();
            var trips = Util.Common.DataFactory.Trips.GetTrips(tbFilter.Text);
            foreach (var t in trips)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = t
                };
                row.CreateCells(dataGridView, t.Offer.Id,
                                              t.Offer.Name,
                                              t.Date.ToString().Substring(0, t.Date.ToString().IndexOf(" ")),
                                              t.TimeDeparture.ToString().Substring(0, 5),
                                              t.TimeReturn.ToString().Substring(0, 5),
                                              t.Offer.Commercialist.Id,
                                              t.Offer.DateOfCreation,
                                              t.Offer.Price.Id,
                                              t.Offer.Price.TransportCost,
                                              t.Offer.Price.TravelInsurance,
                                              t.Offer.Price.TouristTax,
                                              t.Offer.Price.TotalPrice);
                dataGridView.Rows.Add(row);
            }
            ClearControls();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGridTrips();
        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            addNew = false;
            gbTrip.Enabled = true;
            btnAdd.Enabled = false;
            ClearTextBoxes();
            contextMenu.Items[0].Enabled = false;
            contextMenu.Items[1].Enabled = false;
            try
            {
                var selectedRow = dataGridView.SelectedRows[0];
                tbName.Text = selectedRow.Cells[1].Value.ToString();
                dtpDate.Value = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                dtpDeparture.Value = DateTime.Parse(selectedRow.Cells[3].Value.ToString());
                dtpReturn.Value = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
                tbPrice.Text = selectedRow.Cells[8].Value.ToString();
                tbTravelInsurance.Text = selectedRow.Cells[9].Value.ToString();
                if (!tbTravelInsurance.Text.Equals("0,00"))
                {
                    cbTravelInsurance.Checked = true;
                    tbTravelInsurance.Enabled = true;
                }
                else
                {
                    tbTravelInsurance.Text = "";
                }
                tbTouristTax.Text = selectedRow.Cells[10].Value.ToString();
                if (!tbTouristTax.Text.Equals("0,00"))
                {
                    cbTouristTax.Checked = true;
                    tbTouristTax.Enabled = true;
                }
                else
                {
                    tbTouristTax.Text = "";
                }
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNew = true;
            gbTrip.Enabled = true;
            ClearControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            gbTrip.Enabled = false;
            btnAdd.Enabled = true;
        }

        void ClearControls()
        {
            for (int i = 0; i < dataGridView.Rows.Count; ++i)
                dataGridView.Rows[i].Selected = false;
            tbName.Text = "";
            dtpDate.Value = DateTime.Today;
            dtpDeparture.Value = DateTime.Now;
            dtpReturn.Value = DateTime.Now;
            tbPrice.Text = "";
            ClearTextBoxes();
            for (int i = 0; i < dataGridView.Rows.Count; ++i)
                dataGridView.Rows[i].Selected = false;
            contextMenu.Items[0].Enabled = false;
            contextMenu.Items[1].Enabled = false;
        }

        void ClearTextBoxes()
        {
            cbTravelInsurance.Checked = false;
            tbTravelInsurance.Text = "";
            tbTravelInsurance.Enabled = false;
            cbTouristTax.Checked = false;
            tbTouristTax.Text = "";
            tbTouristTax.Enabled = false;
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

        private bool addNew = false;

        private void cbTravelInsurance_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTravelInsurance.Checked)
                tbTravelInsurance.Enabled = true;
            else
            {
                tbTravelInsurance.Text = "";
                tbTravelInsurance.Enabled = false;
            }
        }

        private void cbTouristTax_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTouristTax.Checked)
                tbTouristTax.Enabled = true;
            else
            {
                tbTouristTax.Text = "";
                tbTouristTax.Enabled = false;
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        { 
            TrimTextBoxes();
            if (tbName.Text.Equals("") || tbPrice.Text.Equals(""))
            {
                MessageBox.Show(rm.GetString("String4"), rm.GetString("IncompleteEntry"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (addNew)
                {
                    try
                    {
                        Util.Common.DataFactory.Trips.InsertTrip(new Trip()
                        {
                            Offer = new Offer()
                            {
                                Name = tbName.Text,
                                Commercialist = new Employee()
                                {
                                    Id = currentUser.Employee.Id
                                },
                                Price = new Price()
                                {
                                    TransportCost = decimal.Parse(tbPrice.Text),
                                    TravelInsurance = cbTravelInsurance.Checked ? decimal.Parse(tbTravelInsurance.Text) : 0,
                                    TouristTax = cbTouristTax.Checked ? decimal.Parse(tbTouristTax.Text) : 0
                                },
                            },
                            Date = dtpDate.Value,
                            TimeDeparture = dtpDeparture.Value.TimeOfDay,
                            TimeReturn = dtpReturn.Value.TimeOfDay
                        });
                        FillGridTrips();
                        ClearControls();
                        MessageBox.Show(rm.GetString("String8"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbTrip.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show(rm.GetString("String9"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {

                        var selectedRow = dataGridView.SelectedRows[0];
                        Trip t = (Trip)selectedRow.Tag;
                        Util.Common.DataFactory.Trips.UpdateTrip(new Trip()
                        {
                            Offer = new Offer()
                            {
                                Id = t.Offer.Id,
                                Name = tbName.Text,
                                Price = new Price()
                                {
                                    Id = t.Offer.Price.Id,
                                    TransportCost = decimal.Parse(tbPrice.Text),
                                    TravelInsurance = cbTravelInsurance.Checked ? decimal.Parse(tbTravelInsurance.Text) : 0,
                                    TouristTax = cbTouristTax.Checked ? decimal.Parse(tbTouristTax.Text) : 0
                                },
                            },
                            Date = dtpDate.Value,
                            TimeDeparture = dtpDeparture.Value.TimeOfDay,
                            TimeReturn = dtpReturn.Value.TimeOfDay
                        }) ;
                        FillGridTrips();
                        ClearControls();
                        MessageBox.Show(rm.GetString("UpdateData"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbTrip.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show(rm.GetString("UpdateDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                btnAdd.Enabled = true;
            }
        }
        
        void TrimTextBoxes()
        {
            tbName.Text.Trim();
            tbPrice.Text.Trim();
            tbTravelInsurance.Text.Trim();
            tbTouristTax.Text.Trim();
        }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView.SelectedRows[0];
            Trip t = (Trip)selectedRow.Tag;
            var name = selectedRow.Cells[1].Value.ToString();
            var result = MessageBox.Show(rm.GetString("String10") + name +  "?",
                            rm.GetString("DeleteConf"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                int reservations = -1;
                try
                {
                    reservations = Util.Common.DataFactory.Offers.CountReservations(t.Offer.Id);
                    //var _id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                    //reservations = Util.Common.DataFactory.Offers.CountReservations(_id);
                }
                catch
                {
                    MessageBox.Show(rm.GetString("DeleteDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (reservations > 0)
                {
                    MessageBox.Show(rm.GetString("String11"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (reservations == 0)
                {
                    try
                    {
                        //var _id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                        //var _priceId = Int32.Parse(selectedRow.Cells[7].Value.ToString());
                        //Util.Common.DataFactory.Trips.DeleteTripById(_id, _priceId);

                        Util.Common.DataFactory.Trips.DeleteTripById(t.Offer.Id, t.Offer.Price.Id);

                        ClearControls();
                        MessageBox.Show(rm.GetString("DeleteData"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show(rm.GetString("DeleteDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(rm.GetString("DeleteDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillGridTrips();
                gbTrip.Enabled = false;
            }
            else
            {
                ClearControls();
                gbTrip.Enabled = false;
            }
        }

        private void tbTravelInsurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

            }

            if (!char.IsControl(e.KeyChar))
            {
                var isMatch = Regex.IsMatch((sender as TextBox).Text + e.KeyChar, "^\\d{1,6}(\\,\\d{0,2})?$");

                if (!isMatch)
                    e.Handled = true;
            }
        }
    }
}
