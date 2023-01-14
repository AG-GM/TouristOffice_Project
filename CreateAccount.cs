using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TouristOffice
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPassword.Text == "" || txtPhoneNumber.Text == "" || txtEmail.Text == "" || txtPassConfirm.Text == "" || txtPhoneNumber.Text.Length != 10)
            {
                if (txtPhoneNumber.Text == "")
                {
                    lblPhoneEmpty.Text = "You cant leave this field";
                    lblPhoneEmpty.Show();
                }
                else
                {
                    if (txtPhoneNumber.Text.Length != 10)
                    {
                        lblPhoneEmpty.Text = "Phone number is not 10 digits";
                        lblPhoneEmpty.Show();
                    }
                    else
                    {
                        lblPhoneEmpty.Hide();
                    }
                }
                if (txtEmail.Text == "")
                {
                    lblEmailEmpty.Show();
                }
                else
                {
                    lblEmailEmpty.Hide();
                }
                if (txtName.Text == "")
                {
                    lblNameEmpty.Show();
                }
                else
                {
                    lblNameEmpty.Hide();

                }
                if (txtPassConfirm.Text == "")
                {
                    lblPassConfEmpty.Show();
                }
                else
                {
                    lblPassConfEmpty.Hide();
                }
                if (txtPassword.Text == "")
                {
                    lblPassEmpty.Show();
                }
                else
                {
                    lblPassEmpty.Hide();
                }
            }
            else
            {
                if (txtPassConfirm.Text != txtPassword.Text)
                {
                    MessageBox.Show("The passwords are not the same");
                }
                else
                {
                    string Username = txtName.Text;
                    string Email = txtEmail.Text;
                    string Password = txtPassword.Text;
                    string Phone = txtPhoneNumber.Text;
                    OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=TouristOffice1.accdb");
                    string insertCommand = $"Insert into Users([Username], [Email], [Password], [PhoneNumber]) values('{Username}', '{Email}', '{Password}', '{Phone}')";
                    OleDbCommand command = new OleDbCommand(insertCommand, con);
                    con.Open();
                    command.ExecuteNonQuery();  
                    con.Close();
                    this.Close();
                }
            }
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            lblEmailEmpty.Hide();
            lblNameEmpty.Hide();
            lblPassConfEmpty.Hide();
            lblPassEmpty.Hide();
            lblPhoneEmpty.Hide();
            txtSelect.Select();
        }
       
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
