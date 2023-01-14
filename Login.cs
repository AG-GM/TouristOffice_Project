using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristOffice
{
    public partial class frmLogin : Form
    {
        public string ID;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.ForeColor = Color.Gray;
                txtPassword.Text = "password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.ForeColor = Color.Gray;
                txtEmail.Text = "email";
            }
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void lblCreateAnAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount s = new frmCreateAccount();
            s.ShowDialog();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtSelect.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=TouristOffice1.accdb");
            OleDbCommand command = new OleDbCommand($"Select * from Users where [Email] = '{txtEmail.Text}' and [Password] = '{txtPassword.Text}'", con);
            OleDbDataAdapter ad = new OleDbDataAdapter(command);
            con.Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                ID = reader[0].ToString();
                frmHomePage.frmID = ID;
                frmHomePage.frmHP.lblUserName.Text = reader[1].ToString();
                frmHomePage.frmHP.picPfp.ImageLocation = Uri.EscapeUriString(reader[6].ToString());
                frmDisplayI.frmDI.lblEmailValue.Text = reader[2].ToString();
                frmDisplayI.frmDI.lblPasswordValue.Text = reader[3].ToString();
                frmDisplayI.frmDI.lblUserNameValue.Text = reader[1].ToString();
                frmDisplayI.frmDI.lblPhoneValue.Text = reader[4].ToString();
                this.Close();
                frmDisplayI.frmDI.lblRegister.Hide();
                frmDisplayI.frmDI.lblLogin.Hide();
                frmDisplayI.frmDI.lblLogOut.Show();
            }
            else
            {
                MessageBox.Show("Wrong Email or Password");
            }
            con.Close();
        }
    } 
}