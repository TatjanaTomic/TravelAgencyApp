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
    public partial class NewLoginForm : Form
    {
        public NewLoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = tbUsername.Text.Trim();
            string _password = tbPassword.Text.Trim();

            if (_username != "" && _password != "")
            {
                try
                {
                    var result = Util.Common.DataFactory.Accounts.CheckAccount(_username, _password);

                    if (result.Equals("1"))
                    {
                        new ManagerForm().ShowDialog();
                    }
                    else if (result.Equals("2"))
                    {
                        new CommercialistForm().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Pogresni podaci za pristup sistemu!", "Neuspjesna prijava", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    ClearTextBoxes();
                    MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ClearTextBoxes();
                MessageBox.Show("Unesite korisnicko ime i lozinku za pristup sistemu!", "Neuspjesna prijava", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearTextBoxes()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbUsername.ForeColor = Color.Gray;
            tbPassword.ForeColor = Color.Gray;
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            if ((tbUsername.Text.Equals("Korisnicko ime") || tbUsername.Text.Equals("Username")) && tbPassword.Text.Equals("xxxxxxxx"))
                ClearTextBoxes();
                
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if ((tbUsername.Text.Equals("Korisnicko ime") || tbUsername.Text.Equals("Username")) && tbPassword.Text.Equals("xxxxxxxx"))
                ClearTextBoxes();
        }

        private void pbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if ((tbUsername.Text.Equals("Korisnicko ime") || tbUsername.Text.Equals("Username")) && tbPassword.Text.Equals("xxxxxxxx"))
                ClearTextBoxes();
            tbPassword.UseSystemPasswordChar = false;
        }

        private void pbPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

    }
}
