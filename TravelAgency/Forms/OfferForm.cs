using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgency.Data.Model;

namespace TravelAgency.Forms
{
    public partial class OfferForm : Form
    {
        public OfferForm()
        {
            InitializeComponent();
            FillGridTrips();
        }
        void FillGridTrips()
        {
            dataGridView.Rows.Clear();
            var rows = Util.Common.DataFactory.Offers.GetOffers(tbFilter.Text);
            foreach (var r in rows)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = r
                };
                row.CreateCells(dataGridView, r.Item1.Id,
                                              r.Item1.Name,
                                              r.Item1.Price.TotalPrice,
                                              r.Item1.DateOfCreation,
                                              r.Item1.Commercialist.Id,
                                              r.Item1.Commercialist.FirstName,
                                              r.Item1.Commercialist.LastName,
                                              r.Item2,
                                              r.Item3);
                dataGridView.Rows.Add(row);
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            FillGridTrips();
        }
    }
}
