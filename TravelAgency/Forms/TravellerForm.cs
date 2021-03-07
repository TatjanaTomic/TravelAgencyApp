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
    public partial class TravellerForm : Form
    {
        private readonly ResourceManager rm; 
        public TravellerForm()
        {
            InitializeComponent();
            rm = new ResourceManager("TravelAgency.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
            FillGridTravellers();
        }

        void FillGridTravellers()
        {
            dataGridView.Rows.Clear();
            var travellers = Util.Common.DataFactory.Travellers.GetTravellers(tbFilter.Text);
            foreach (var t in travellers)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = t
                };
                row.CreateCells(dataGridView, t.Id,
                                              t.FirstName,
                                              t.LastName,
                                              t.Jmb,
                                              t.IdCardNumber,
                                              t.PassportNumber);
                dataGridView.Rows.Add(row);
            }
            ClearControls();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGridTravellers();
        }

        void ShowData()
        {
            btnAdd.Enabled = false;
            addNew = false;
            gbTraveller.Enabled = true;
            cbLK.Checked = false;
            tbLK.Enabled = false;
            cbPassport.Checked = false;
            tbPassport.Enabled = false;
            try
            {
                var selectedRow = dataGridView.SelectedRows[0];
                tbFirstName.Text = selectedRow.Cells[1].Value.ToString();
                tbLastName.Text = selectedRow.Cells[2].Value.ToString();
                tbJMB.Text = selectedRow.Cells[3].Value.ToString();
                tbLK.Text = selectedRow.Cells[4].Value.ToString();
                if (!tbLK.Text.Equals(""))
                {
                    cbLK.Checked = true;
                    tbLK.Enabled = true;
                }
                tbPassport.Text = selectedRow.Cells[5].Value.ToString();
                if (!tbPassport.Text.Equals(""))
                {
                    cbPassport.Checked = true;
                    tbPassport.Enabled = true;
                }
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
            gbTraveller.Enabled = true;
            ClearControls();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            gbTraveller.Enabled = false;
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
            if (tbFirstName.Text.Equals("") || tbLastName.Text.Equals("") || tbJMB.Text.Equals(""))
            {
                MessageBox.Show(rm.GetString("String1"), rm.GetString("IncompleteEntry"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(tbJMB.TextLength < 13 || (cbLK.Checked && tbLK.TextLength < 9) || (cbPassport.Checked && tbPassport.TextLength < 8))
            {
                MessageBox.Show(rm.GetString("String2"), rm.GetString("IncompleteEntry"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if(addNew)
                {
                    try
                    {
                        Util.Common.DataFactory.Travellers.InsertTraveller(new Traveller()
                        {
                            FirstName = tbFirstName.Text,
                            LastName = tbLastName.Text,
                            Jmb = tbJMB.Text,
                            IdCardNumber = cbLK.Checked ? tbLK.Text : null,
                            PassportNumber = cbPassport.Checked ? tbPassport.Text : null
                        });
                        FillGridTravellers();
                        ClearControls();
                        MessageBox.Show(rm.GetString("AddTraveller"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbTraveller.Enabled = false;
                        btnAdd.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show(rm.GetString("AddTravellerError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        var selectedRow = dataGridView.SelectedRows[0];
                        Util.Common.DataFactory.Travellers.UpdateTraveller(new Traveller()
                        {
                            Id = Int32.Parse(selectedRow.Cells[0].Value.ToString()),
                            FirstName = tbFirstName.Text,
                            LastName = tbLastName.Text,
                            Jmb = tbJMB.Text,
                            IdCardNumber = cbLK.Checked ? tbLK.Text : null,
                            PassportNumber = cbPassport.Checked ? tbPassport.Text : null
                        });
                        FillGridTravellers();
                        ClearControls();
                        MessageBox.Show(rm.GetString("UpdateData"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gbTraveller.Enabled = false;
                        btnAdd.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show(rm.GetString("UpdateDataError"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void TrimTextBoxes()
        {
            tbFirstName.Text.Trim();
            tbLastName.Text.Trim();
            tbJMB.Text.Trim();
            tbLK.Text.Trim();
            tbPassport.Text.Trim();
        }

        private void cbLK_CheckedChanged(object sender, EventArgs e)
        {
            if(cbLK.Checked)
            {
                tbLK.Enabled = true;
            }
            else
            {
                tbLK.Text = "";
                tbLK.Enabled = false;
            }
        }

        private void cbPassport_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassport.Checked)
            {
                tbPassport.Enabled = true;
            }
            else
            {
                tbPassport.Text = "";
                tbPassport.Enabled = false;
            }
        }

        void ClearControls()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbJMB.Text = "";
            cbLK.Checked = false;
            tbLK.Text = "";
            tbLK.Enabled = false;
            cbPassport.Checked = false;
            tbPassport.Text = "";
            tbPassport.Enabled = false;
            for (int i = 0; i < dataGridView.Rows.Count; ++i)
                dataGridView.Rows[i].Selected = false;
            contextMenu.Items[0].Enabled = false;
            contextMenu.Items[1].Enabled = false;
        }

        private void obrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView.SelectedRows[0];
            var _firstName = selectedRow.Cells[1].Value.ToString();
            var _lastName = selectedRow.Cells[2].Value.ToString();
            var _jmb = selectedRow.Cells[3].Value.ToString();
            var result = MessageBox.Show(rm.GetString("DeleteTraveller") + _firstName + " " + _lastName + " " + _jmb + "?",
                            rm.GetString("DeleteConf"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                try
                {

                    Util.Common.DataFactory.Travellers.DeleteTravellerById(Int32.Parse(selectedRow.Cells[0].Value.ToString()));

                    FillGridTravellers();
                    ClearControls();
                    MessageBox.Show(rm.GetString("DeleteData"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(rm.GetString("DeleteDataError") + "\n" + rm.GetString("String12"), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillGridTravellers();
                gbTraveller.Enabled = false;
            }
            else
            {
                ClearControls();
                gbTraveller.Enabled = false;
            }
        }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private bool addNew = false;

        private void tbJMB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbLK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
    }
}
