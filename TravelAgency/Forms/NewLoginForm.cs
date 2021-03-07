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

namespace TravelAgency.Forms
{
    public partial class NewLoginForm : Form
    {
        readonly CultureInfo culture;
        ResourceManager rm;

        public NewLoginForm(CultureInfo culture)
        {
            this.culture = culture;
            setCulture();

            InitializeComponent();
        }

        private void setCulture()
        {
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            rm = new ResourceManager("TravelAgency.Resources.Strings", System.Reflection.Assembly.GetExecutingAssembly());
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
                        Data.Model.Account currentUser = Util.Common.DataFactory.Accounts.GetAccountByUsername(_username);
                        new ManagerForm(currentUser, Thread.CurrentThread.CurrentCulture).ShowDialog();
                    }
                    else if (result.Equals("2"))
                    {
                        Data.Model.Account currentUser = Util.Common.DataFactory.Accounts.GetAccountByUsername(_username);
                        new CommercialistForm(currentUser, Thread.CurrentThread.CurrentCulture).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(rm.GetString("WrongLoginData"), rm.GetString("FailedLogin"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(rm.GetString("EnterData"), rm.GetString("FailedLogin"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearTextBoxes();
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            if ((tbUsername.Text.Equals("Korisničko ime") || tbUsername.Text.Equals("Username")) && tbPassword.Text.Equals("xxxxxxxx"))
                ClearTextBoxes();
                
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if ((tbUsername.Text.Equals("Korisničko ime") || tbUsername.Text.Equals("Username")) && tbPassword.Text.Equals("xxxxxxxx"))
                ClearTextBoxes();
        }

        private void pbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if ((tbUsername.Text.Equals("Korisničko ime") || tbUsername.Text.Equals("Username")) && tbPassword.Text.Equals("xxxxxxxx"))
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new NewLoginForm(new CultureInfo("sr"));
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new NewLoginForm(new CultureInfo("en"));
            f.ShowDialog();
            this.Close();
        }

        private void ClearTextBoxes()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbUsername.ForeColor = Color.Gray;
            tbPassword.ForeColor = Color.Gray;
        }

        private void NewLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
