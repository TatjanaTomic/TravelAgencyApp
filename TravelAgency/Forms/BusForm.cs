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
    public partial class BusForm : Form
    {
        ResourceManager rm;
        public BusForm()
        {
            rm = new ResourceManager("TravelAgency.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
            InitializeComponent();
            FillGridBuses();
        }

        void FillGridBuses()
        {
            dataGridView.Rows.Clear();
            var buses = Util.Common.DataFactory.Buses.GetBuses(tbFilter.Text);
            foreach (var b in buses)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = b
                };
                row.CreateCells(dataGridView, b.LicensePlate,
                                              b.Manufacturer,
                                              b.Model,
                                              b.NumberOfSeats);
                dataGridView.Rows.Add(row);
            }
            ClearControls();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGridBuses();
        }

        void ShowData()
        {
            addNew = false;
            gbBus.Enabled = true;
            btnAdd.Enabled = false;
            try
            {
                var selectedRow = dataGridView.SelectedRows[0];
                tbLicensePlate.Text = selectedRow.Cells[0].Value.ToString();
                tbLicensePlate.Enabled = false;
                tbManufacturer.Text = selectedRow.Cells[1].Value.ToString();
                tbModel.Text = selectedRow.Cells[2].Value.ToString();
                tbNumberOfSeats.Text = selectedRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenu.Items[0].Enabled = false;
            contextMenu.Items[1].Enabled = false;
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNew = true;
            gbBus.Enabled = true;
            tbLicensePlate.Enabled = true;
            ClearControls();
        btnAdd.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            gbBus.Enabled = false;
            btnAdd.Enabled = true;
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
            if (tbLicensePlate.Text.Equals("") || tbManufacturer.Text.Equals("") || tbModel.Text.Equals("") || tbNumberOfSeats.Text.Equals(""))
            {
                MessageBox.Show(rm.GetString("RequiredFields"), rm.GetString("IncompleteEntry"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (addNew)
                {
                    Bus b = null;
                    try
                    {
                        b = new Bus()
                        {
                            LicensePlate = tbLicensePlate.Text,
                            Manufacturer = tbManufacturer.Text,
                            Model = tbModel.Text,
                            NumberOfSeats = Int32.Parse(tbNumberOfSeats.Text),
                        };
                    }
                    catch
                    {
                        MessageBox.Show(rm.GetString("NumberOfSeats"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (b != null)
                    {
                        try
                        {
                            Util.Common.DataFactory.Buses.InsertBus(b);
                            FillGridBuses();
                            ClearControls();
                            MessageBox.Show(rm.GetString("NewBus"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gbBus.Enabled = false;
                            btnAdd.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show(rm.GetString("NewBusError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    Bus b = null;
                    try
                    {
                        var selectedRow = dataGridView.SelectedRows[0];
                        b = new Bus()
                        {
                            LicensePlate = tbLicensePlate.Text,
                            Manufacturer = tbManufacturer.Text,
                            Model = tbModel.Text,
                            NumberOfSeats = Int32.Parse(tbNumberOfSeats.Text),
                        };
                    }
                    catch
                    {
                        MessageBox.Show(rm.GetString("NumberOfSeats"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (b != null)
                    {
                        try
                        {
                            var selectedRow = dataGridView.SelectedRows[0];
                            Util.Common.DataFactory.Buses.UpdateBus(b);
                            FillGridBuses();
                            ClearControls();
                            MessageBox.Show(rm.GetString("UpdateData"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gbBus.Enabled = false;
                            btnAdd.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show(rm.GetString("UpdateDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        void TrimTextBoxes()
        {
            tbLicensePlate.Text.Trim();
            tbManufacturer.Text.Trim();
            tbModel.Text.Trim();
            tbNumberOfSeats.Text.Trim();
        }

        void ClearControls()
        {
            tbLicensePlate.Text = "";
            tbManufacturer.Text = "";
            tbModel.Text = "";
            tbNumberOfSeats.Text = "";
            for (int i = 0; i < dataGridView.Rows.Count; ++i)
                dataGridView.Rows[i].Selected = false;
            contextMenu.Items[0].Enabled = false;
            contextMenu.Items[1].Enabled = false;
        }

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView.SelectedRows[0];
            var _lp = selectedRow.Cells[0].Value.ToString();
            var _manufacturer = selectedRow.Cells[1].Value.ToString();
            var _model = selectedRow.Cells[2].Value.ToString();
            var result = MessageBox.Show(rm.GetString("DeleteBus") + _lp + " " + _manufacturer + " " + _model + "?",
                            rm.GetString("DeleteConf"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                try
                {

                    Util.Common.DataFactory.Buses.DeleteBusByLicensePlate(selectedRow.Cells[0].Value.ToString());
                    ClearControls();
                    MessageBox.Show(rm.GetString("DeleteData"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(rm.GetString("DeleteDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillGridBuses();
                gbBus.Enabled = false;
            }
            else
            {
                tbLicensePlate.Enabled = true;
                ClearControls();
                gbBus.Enabled = false;
            }
        }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private bool addNew = false;

        private void tbNumberOfSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                    e.Handled = true;
                
            }
        }
    }
}
