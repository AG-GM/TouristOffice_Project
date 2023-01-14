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

namespace TouristOffice
{
    public partial class frmLogOut : Form
    {
        public frmLogOut()
        {
            InitializeComponent();
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            frmDisplayI.frmDI.lblEmailValue.Text = "Login to display \n information here";
            frmDisplayI.frmDI.lblPasswordValue.Text = "Login to display \n information here";
            frmDisplayI.frmDI.lblUserNameValue.Text = "Login to display \n information here";
            frmDisplayI.frmDI.lblPhoneValue.Text = "Login to display \n information here";
            frmHomePage.frmHP.lblUserName.Text = "Guest";
            frmHomePage.frmID = null;
            frmHomePage.frmHP.picPfp.Image = TouristOffice.Properties.Resources.guest;
            frmDisplayI.frmDI.lblRegister.Show();
            frmDisplayI.frmDI.lblLogin.Show();
            frmDisplayI.frmDI.lblLogOut.Hide();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
