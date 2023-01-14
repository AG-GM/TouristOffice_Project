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
    public partial class frmDisplayA : Form
    {
        public frmDisplayA()
        {
            InitializeComponent();
        }

        private void btnRoyalJordanian_Click(object sender, EventArgs e)
        {
            frmHomePage.frmHP.pnlAirLines.BackgroundImage = TouristOffice.Properties.Resources.RoyalJordanian;
            frmHomePage.frmHP.cbxAirLines.Text = "Royal Jordanian";
            frmHomePage.frmHP.AirlineDB = 12;
        }

        private void btnAirCairo_Click(object sender, EventArgs e)
        {
            frmHomePage.frmHP.pnlAirLines.BackgroundImage = TouristOffice.Properties.Resources.Air_Cairo;
            frmHomePage.frmHP.cbxAirLines.Text = "Air Cairo";
            frmHomePage.frmHP.AirlineDB = 6;
        }

        private void btnTurkishAirlines_Click(object sender, EventArgs e)
        {
            frmHomePage.frmHP.pnlAirLines.BackgroundImage = TouristOffice.Properties.Resources.Turkish_Airlines;
            frmHomePage.frmHP.cbxAirLines.Text = "Turkish Airlines";
            frmHomePage.frmHP.AirlineDB = 15;
        }

        private void btnFlyEmirates_Click(object sender, EventArgs e)
        {
            frmHomePage.frmHP.pnlAirLines.BackgroundImage = TouristOffice.Properties.Resources.FlyEmirates;
            frmHomePage.frmHP.cbxAirLines.Text = "Fly Emirates";
            frmHomePage.frmHP.AirlineDB = 10;
        }
    }
}
