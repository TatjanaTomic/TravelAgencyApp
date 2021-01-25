using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Forms
{
    public partial class ManagerForm : Form
    {
        private static readonly Color lightPurple = Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
        private static readonly Color darkPurple = Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
        private static readonly Font regular = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        private static readonly Font bold = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

        public ManagerForm()
        {
            InitializeComponent();
            btnAllOffers.BackColor = darkPurple;
            btnAllOffers.Font = bold;
            pnlOffers.Visible = true;
            FillGridTrips();

        }

        void FillGridTrips()
        {
            dgvTrips.Rows.Clear();
            var trips = Util.Common.DataFactory.Trips.GetTrips();
            foreach (var t in trips)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = t
                };
                row.CreateCells(dgvTrips, t.Offer.Id, t.Offer.Name, t.Date, t.TimeDeparture, t.TimeReturn, t.Offer.Commercialist, t.Offer.DateOfCreation, t.Offer.Price.Id, t.Offer.Price.TotalPrice);
                dgvTrips.Rows.Add(row);
            }
        }

        private void btnAllOffers_Click(object sender, EventArgs e)
        {
            SetButtons();
            btnAllOffers.BackColor = darkPurple;
            btnAllOffers.Font = bold;

            FillGridTrips();
            pnlOffers.Visible = true;
        }

        private void btnTravels_Click(object sender, EventArgs e)
        {
            SetButtons();
            btnTravels.BackColor = darkPurple;
            btnTravels.Font = bold;


        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            SetButtons();
            btnTrips.BackColor = darkPurple;
            btnTrips.Font = bold;

        }

        private void SetButtons()
        {
            btnAllOffers.BackColor = lightPurple;
            btnAllOffers.Font = regular;
            btnTravels.BackColor = lightPurple;
            btnTravels.Font = regular;
            btnTrips.BackColor = lightPurple;
            btnTrips.Font = regular;
        }
    }
}
