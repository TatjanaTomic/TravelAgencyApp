using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Runtime.InteropServices;

namespace TravelAgency.Forms
{
    public partial class ManagerForm : Form
    {
        protected Form activeForm;
        private readonly Data.Model.Account currentUser;
        private readonly CultureInfo culture;
        private static readonly Color lightPurple = Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(125)))), ((int)(((byte)(165)))));
        private static readonly Color darkPurple = Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
        private static readonly Font regular = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        private static readonly Font bold = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

        public ManagerForm(Data.Model.Account currentUser, CultureInfo culture)
        {
            this.currentUser = currentUser;
            this.culture = culture;

            setCulture();
            InitializeComponent();
            SetUserInformation();

            this.Text = string.Empty;
            this.ControlBox = false;



            btnReservation.BackColor = darkPurple;
            btnReservation.Font = bold;
            OpenChildForm(new ReservationForm(currentUser));
        }

        private void setCulture()
        {
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        void SetUserInformation()
        {
            if (currentUser != null)
            {
                lbUser.Text = currentUser.Employee.FirstName + " " + currentUser.Employee.LastName;
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            SetButtons();
            btnReservation.BackColor = darkPurple;
            btnReservation.Font = bold;

            OpenChildForm(new ReservationForm(currentUser));
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            SetButtons();
            btnReceipt.BackColor = darkPurple;
            btnReceipt.Font = bold;

            OpenChildForm(new ReceiptForm());
        }

        private void btnTraveller_Click(object sender, EventArgs e)
        {
            SetButtons();
            btnTraveller.BackColor = darkPurple;
            btnTraveller.Font = bold;

            OpenChildForm(new TravellerForm());
        }

        private void btnBuses_Click(object sender, EventArgs e)
        {
            SetButtons();
            btnBuses.BackColor = darkPurple;
            btnBuses.Font = bold;

            OpenChildForm(new BusForm());
        }

        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SetButtons()
        {
            btnReservation.BackColor = lightPurple;
            btnReservation.Font = regular;
            btnReceipt.BackColor = lightPurple;
            btnReceipt.Font = regular;
            btnTraveller.BackColor = lightPurple;
            btnTraveller.Font = regular;
            btnBuses.BackColor = lightPurple;
            btnBuses.Font = regular;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);  
        }
    }
}
