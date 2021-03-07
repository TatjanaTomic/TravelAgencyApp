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
    public partial class TravelForm : Form
    {
        private readonly Account currentUser;
        private readonly ResourceManager rm; 
        public TravelForm(Account currentUser)
        {
            rm = new ResourceManager("TravelAgency.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGridTravels();
            this.currentUser = currentUser;
        }
        void FillGridTravels()
        {
            dataGridView.Rows.Clear();
            var travels = Util.Common.DataFactory.Travels.GetTravels(tbFilter.Text);
            foreach (var t in travels)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = t
                };
                row.CreateCells(dataGridView, t.Offer.Id,
                                              t.Offer.Name,
                                              t.Departure.ToString().Substring(0, t.Departure.ToString().LastIndexOf(":")),
                                              t.Return.ToString().Substring(0, t.Departure.ToString().LastIndexOf(":")),
                                              t.Offer.Commercialist.Id,
                                              t.Offer.DateOfCreation,
                                              t.Offer.Price.Id,
                                              t.Offer.Price.TransportCost,
                                              t.Offer.Price.Accommodation,
                                              t.Offer.Price.TravelInsurance,
                                              t.Offer.Price.TouristTax,
                                              t.Offer.Price.TotalPrice);
                dataGridView.Rows.Add(row);
            }
            ClearControls();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGridTravels();
        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            addNew = false;
            gbTravel.Enabled = true;
            contextMenu.Items[0].Enabled = false;
            contextMenu.Items[1].Enabled = false;
            try
            {
                var selectedRow = dataGridView.SelectedRows[0];
                tbName.Text = selectedRow.Cells[1].Value.ToString();
                dtpDeparture.Value = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                dtpReturn.Value = DateTime.Parse(selectedRow.Cells[3].Value.ToString());
                tbPrice.Text = selectedRow.Cells[7].Value.ToString();
                tbAccommodation.Text = selectedRow.Cells[8].Value.ToString();
                if (!tbAccommodation.Text.Equals("0,00"))
                {
                    cbAccommodation.Checked = true;
                    tbAccommodation.Enabled = true;
                }
                else
                    tbAccommodation.Text = "";
                tbTravelInsurance.Text = selectedRow.Cells[9].Value.ToString();
                if (!tbTravelInsurance.Text.Equals("0,00"))
                {
                    cbTravelInsurance.Checked = true;
                    tbTravelInsurance.Enabled = true;
                }
                else
                    tbTravelInsurance.Text = "";
                tbTouristTax.Text = selectedRow.Cells[10].Value.ToString();
                if (!tbTouristTax.Text.Equals("0,00"))
                {
                    cbTouristTax.Checked = true;
                    tbTouristTax.Enabled = true;
                }
                else
                    tbTouristTax.Text = "";
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNew = true;
            gbTravel.Enabled = true;
            ClearControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            btnAdd.Enabled = true;
            gbTravel.Enabled = false;
        }

        void ClearControls()
        {
            tbName.Text = "";
            tbPrice.Text = "";
            dtpDeparture.Value = DateTime.Now;
            dtpReturn.Value = DateTime.Now;
            ClearTextBoxes();
            for (int i = 0; i < dataGridView.Rows.Count; ++i)
                dataGridView.Rows[i].Selected = false;
            contextMenu.Items[0].Enabled = false;
            contextMenu.Items[1].Enabled = false;
        }

        void ClearTextBoxes()
        {
            cbAccommodation.Checked = false;
            tbAccommodation.Text = "";
            tbAccommodation.Enabled = false;
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

            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
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

        private void cbAccommodation_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAccommodation.Checked)
                tbAccommodation.Enabled = true;
            else
            {
                tbAccommodation.Text = "";
                tbAccommodation.Enabled = false;
            }
        }

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

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView.SelectedRows[0];
            var name = selectedRow.Cells[1].Value.ToString();
            var result = MessageBox.Show(rm.GetString("DeleteTravel") + name + "?",
                            rm.GetString("DeleteConf"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                int reservations = -1;
                try
                {
                    var _id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                    reservations = Util.Common.DataFactory.Offers.CountReservations(_id);
                }
                catch
                {
                    MessageBox.Show(rm.GetString("DeleteDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (reservations > 0)
                {
                    MessageBox.Show(rm.GetString("String3"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (reservations == 0)
                {
                    try
                    {
                        var _id = Int32.Parse(selectedRow.Cells[0].Value.ToString());
                        var _priceId = Int32.Parse(selectedRow.Cells[6].Value.ToString());
                        Util.Common.DataFactory.Travels.DeleteTravelById(_id, _priceId);

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
                FillGridTravels();
                gbTravel.Enabled = false;
            }
            else
            {
                ClearControls();
                gbTravel.Enabled = false;
            }
        }

        void TrimTextBoxes()
        {
            tbName.Text.Trim();
            tbPrice.Text.Trim();
            tbTravelInsurance.Text.Trim();
            tbTouristTax.Text.Trim();
            tbAccommodation.Text.Trim();
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
                    Travel t = null;
                    try
                    {
                        t = new Travel()
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
                                    Accommodation = cbAccommodation.Checked ? decimal.Parse(tbAccommodation.Text) : 0,
                                    TravelInsurance = cbTravelInsurance.Checked ? decimal.Parse(tbTravelInsurance.Text) : 0,
                                    TouristTax = cbTouristTax.Checked ? decimal.Parse(tbTouristTax.Text) : 0
                                },
                            },
                            Departure = dtpDeparture.Value,
                            Return = dtpReturn.Value
                        };
                    }
                    catch
                    {
                        MessageBox.Show(rm.GetString("String5"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (t != null)
                    {
                        try
                        {
                            Util.Common.DataFactory.Travels.InsertTravel(t);
                            MessageBox.Show(rm.GetString("String6"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show(rm.GetString("String7"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    FillGridTravels();
                    ClearControls();
                    gbTravel.Enabled = false;
                }
                else
                {
                    Travel t = null;
                    try
                    {
                        var selectedRow = dataGridView.SelectedRows[0];
                        t = new Travel()
                        {
                            Offer = new Offer()
                            {
                                Id = (int)selectedRow.Cells[0].Value,
                                Name = tbName.Text,
                                Price = new Price()
                                {
                                    Id = (int)selectedRow.Cells[6].Value,
                                    TransportCost = decimal.Parse(tbPrice.Text),
                                    Accommodation = cbAccommodation.Checked ? decimal.Parse(tbAccommodation.Text) : 0,
                                    TravelInsurance = cbTravelInsurance.Checked ? decimal.Parse(tbTravelInsurance.Text) : 0,
                                    TouristTax = cbTouristTax.Checked ? decimal.Parse(tbTouristTax.Text) : 0
                                },
                            },
                            Departure = dtpDeparture.Value,
                            Return = dtpReturn.Value
                        };
                    }
                    catch
                    {
                        MessageBox.Show(rm.GetString("String5"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (t != null)
                    {
                        try
                        {
                            Util.Common.DataFactory.Travels.UpdateTravel(t);
                            MessageBox.Show(rm.GetString("UpdateData"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show(rm.GetString("UpdateDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    FillGridTravels();
                    ClearControls();
                    gbTravel.Enabled = false;
                }
            }
        }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
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