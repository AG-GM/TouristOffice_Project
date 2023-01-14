using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TouristOffice
{
    public partial class frmDisplayI : Form
    {
        public static frmDisplayI frmDI;
        public frmDisplayI()
        {
            InitializeComponent();
            frmDI = this;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frmLogin s = new frmLogin();
            s.ShowDialog();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmCreateAccount s = new frmCreateAccount();
            s.ShowDialog();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            frmLogOut s = new frmLogOut();
            s.ShowDialog();
        }

        private void frmDisplayI_Load(object sender, EventArgs e)
        {
            txtConfNewPass.Hide();
            txtOldPass.Hide();
            txtNewPass.Hide();
            txtPfp.Hide();
            txtUserName.Hide();
            txtPhone.Hide();
            txtEmail.Hide();
            lblSaveEmail.Hide();
            lblSavePhone.Hide();
            lblSavePass.Hide();
            lblSaveUser.Hide();
            lblSavePhp.Hide();
            lblLogOut.Hide();

            if (frmHomePage.frmID != null)
            {
                OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=TouristOffice1.accdb");
                OleDbCommand command = new OleDbCommand($"Select * from Users where ID = {frmHomePage.frmID}", con);
                con.Open();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    lblEmailValue.Text = reader[2].ToString();
                    lblPasswordValue.Text = reader[3].ToString();
                    lblUserNameValue.Text = reader[1].ToString();
                    lblPhoneValue.Text = reader[4].ToString();
                }
                con.Close();
                lblLogOut.Show();
                lblLogin.Hide();
                lblRegister.Hide();
            }
            else
            {
                lblLogin.Show();
                lblRegister.Show();
                 lblEmailValue.Text = "Login to display \n information here";
            lblPasswordValue.Text = "Login to display \n information here";
            lblUserNameValue.Text = "Login to display \n information here";
            lblPhoneValue.Text = "Login to display \n information here";

            }
        }

        private void txtPfp_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPfp.Text == "NEW picture link")
            {
                txtPfp.Text = "";
                txtPfp.ForeColor = Color.Black;
            }
        }

        private void txtPfp_Leave(object sender, EventArgs e)
        {
            if (txtPfp.Text == "")
            {
                txtPfp.ForeColor = Color.Gray;
                txtPfp.Text = "NEW picture link";
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.ForeColor = Color.Gray;
                txtUserName.Text = "NEW username";
            }
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "NEW username")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtOldPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtOldPass.Text == "Old password")
            {
                txtOldPass.Text = "";
                txtOldPass.ForeColor = Color.Black;
            }
        }

        private void txtOldPass_Leave(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "")
            {
                txtOldPass.ForeColor = Color.Gray;
                txtOldPass.Text = "Old password";
            }
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                txtNewPass.ForeColor = Color.Gray;
                txtNewPass.Text = "NEW password";
            }
        }

        private void txtNewPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNewPass.Text == "NEW password")
            {
                txtNewPass.Text = "";
                txtNewPass.ForeColor = Color.Black;
            }
        }

        private void txtConfNewPass_Leave(object sender, EventArgs e)
        {
            if (txtConfNewPass.Text == "")
            {
                txtConfNewPass.ForeColor = Color.Gray;
                txtConfNewPass.Text = "Confirm password";
            }
        }

        private void txtConfNewPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtConfNewPass.Text == "Confirm password")
            {
                txtConfNewPass.Text = "";
                txtConfNewPass.ForeColor = Color.Black;
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.ForeColor = Color.Gray;
                txtPhone.Text = "NEW number";
            }
        }

        private void txtPhone_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPhone.Text == "NEW number")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }

        private void lblChangePicture_Click(object sender, EventArgs e)
        {
            txtPfp.Show();
            lblSavePhp.Show();

        }

        private void lblChangeUser_Click(object sender, EventArgs e)
        {
            lblUserNameValue.Hide();
            txtUserName.Show();
            lblSaveUser.Show();
        }

        private void lblChangeEmail_Click(object sender, EventArgs e)
        {
            lblEmailValue.Hide();
            txtEmail.Show();
            lblSaveEmail.Show();
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            txtConfNewPass.Show();
            txtNewPass.Show();
            txtOldPass.Show();
            lblPasswordValue.Hide();
        }

        private void lblChangePhone_Click(object sender, EventArgs e)
        {
            lblPhoneValue.Hide();
            txtPhone.Show();
            lblSavePhone.Show();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.ForeColor = Color.Gray;
                txtEmail.Text = "NEW email";
            }
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "NEW email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void lblSavePhp_Click(object sender, EventArgs e)
        {
            txtPfp.Hide();
            lblSavePhp.Hide();
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=TouristOffice1.accdb");
            string insertCommand = $"UPDATE Users SET [ProfilePicture] = '{txtPfp.Text}' WHERE [ID] = {frmHomePage.frmID}";
            OleDbCommand command = new OleDbCommand(insertCommand, con);
            MessageBox.Show(txtPfp.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            frmHomePage.frmHP.picPfp.ImageLocation = Uri.EscapeUriString(txtPfp.Text);
        }

        private void lblSaveUser_Click(object sender, EventArgs e)
        {
            lblUserNameValue.Show();
            txtUserName.Hide();
            lblSaveUser.Hide();
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=TouristOffice1.accdb");
            string insertCommand = $"UPDATE Users SET [Username] = '{txtUserName.Text}' WHERE [ID] = {frmHomePage.frmID}";
            OleDbCommand command = new OleDbCommand(insertCommand, con);
            MessageBox.Show(txtPfp.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        private void lblSaveEmail_Click(object sender, EventArgs e)
        {
            lblEmailValue.Show();
            txtEmail.Hide();
            lblSaveEmail.Hide();
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=TouristOffice1.accdb");
            string insertCommand = $"UPDATE Users SET [Email] = '{txtEmail.Text}' WHERE [ID] = {frmHomePage.frmID}";
            OleDbCommand command = new OleDbCommand(insertCommand, con);
            MessageBox.Show(txtPfp.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        private void lblSavePass_Click(object sender, EventArgs e)
        {
            txtConfNewPass.Hide();
            txtNewPass.Hide();
            txtOldPass.Hide();
            lblSavePass.Hide();
            lblPasswordValue.Show();
            if (txtNewPass.Text == txtConfNewPass.Text && txtOldPass.Text == lblPasswordValue.Text)
            {
                OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=TouristOffice1.accdb");
                string insertCommand = $"UPDATE Users SET [Password] = '{txtNewPass.Text}' WHERE [ID] = {frmHomePage.frmID}";
                OleDbCommand command = new OleDbCommand(insertCommand, con);
                MessageBox.Show(txtPfp.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
            else if(txtNewPass.Text != txtConfNewPass.Text)
            {
                MessageBox.Show("Wrong confirmation password");
            }
            else if (txtOldPass.Text != lblPasswordValue.Text)
            {
                MessageBox.Show("Wrong original password");
            }
        }

        private void lblSavePhone_Click(object sender, EventArgs e)
        {
            lblPhoneValue.Show();
            txtPhone.Hide();
            lblSavePhone.Hide();
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=TouristOffice1.accdb");
            string insertCommand = $"UPDATE Users SET [PhoneNumber] = '{txtPhone.Text}' WHERE [ID] = {frmHomePage.frmID}";
            OleDbCommand command = new OleDbCommand(insertCommand, con);
            MessageBox.Show(txtPfp.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        private void lblPasswordValue_TextChanged(object sender, EventArgs e)
        {
            lblPasswordValue.Text = "*************";
        }
    }
}
