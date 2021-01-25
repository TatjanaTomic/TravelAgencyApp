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
    public partial class CommercialistForm : Form
    {
        private static readonly Color lightPurple = Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
        private static readonly Color darkPurple = Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
        private static readonly Font regular = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        private static readonly Font bold = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        
        public CommercialistForm()
        {
            InitializeComponent();
            btnAllOffers.BackColor = darkPurple;
            btnAllOffers.Font = bold;
            FillGridOffers();
            pnlOffers.Visible = true;
            pnlTravels.Visible = false;
        }

        void FillGridOffers()
        {
            dgvOffers.Rows.Clear();
            var offers = Util.Common.DataFactory.Offers.GetOffers();
            foreach (var o in offers)
            {
                DataGridViewRow row = new DataGridViewRow()
                {
                    Tag = o
                };
                row.CreateCells(dgvOffers, o.Id, o.Name, o.DateOfCreation, o.Commercialist.FirstName + " " + o.Commercialist.LastName, o.Price.TotalPrice);
                dgvOffers.Rows.Add(row);
            }
        }

        void FillGridTravels()
        {

        }

        void FillGridTrips()
        {

        }

        private void btnAllOffers_Click(object sender, EventArgs e)
        {
            SetButtons();
            btnAllOffers.BackColor = darkPurple;
            btnAllOffers.Font = bold;

            FillGridOffers();
            pnlOffers.Visible = true;
            pnlTravels.Visible = false;
            //pnlTrips.Visible = false;
        }

        private void btnTravels_Click(object sender, EventArgs e)
        {
            SetButtons();
            btnTravels.BackColor = darkPurple;
            btnTravels.Font = bold;

            FillGridTravels();
            pnlOffers.Visible = false;
            pnlTravels.Visible = true;

        }

        private void btnTrips_Click(object sender, EventArgs e)
        {
            SetButtons();
            btnTrips.BackColor = darkPurple;
            btnTrips.Font = bold;

            FillGridTrips();
            //pnlOffers.Visible = false;
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
