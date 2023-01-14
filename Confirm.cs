using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristOffice
{
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();
            lblTotal.Text = frmHomePage.frmHP.TotalTo.ToString();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnYes_Click(object sender, EventArgs e)
        {
            frmHomePage.Confirm = true;
            this.Close();
            MessageBox.Show("Thank you for visiting our office, We hope our service satisfied you!");
        }
    }
}
