using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace TouristOffice
{
    public partial class frmDisplayC : Form
    {
        public frmDisplayC()
        {
            InitializeComponent();
        }
        
        private void btnAqaba_Click(object sender, EventArgs e)
        {
            frmHomePage.frmHP.pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.aqaba;
            frmHomePage.frmHP.cbxCities.Text = "Aqaba(Jordan)";
            frmHomePage.frmHP.Distination = 25;
        }

        private void btnAbuDhabi_Click(object sender, EventArgs e)
        {
            frmHomePage.frmHP.pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.Abu_Dhabi;
            frmHomePage.frmHP.cbxCities.Text = "Abu Dhabi(UAE)";
            frmHomePage.frmHP.Distination = 110;
        }

        private void btnAlghero_Click(object sender, EventArgs e)
        {
            frmHomePage.frmHP.pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.Alghero;
            frmHomePage.frmHP.cbxCities.Text = "Alghero(Italy)";
            frmHomePage.frmHP.Distination = 41;
        }
        private void btnAnkara_Click(object sender, EventArgs e)
        {
            frmHomePage.frmHP.pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.Ankara;
            frmHomePage.frmHP.cbxCities.Text = "Ankara(Turkey)";
            frmHomePage.frmHP.Distination = 143;
        }
        private void btnBangkok_Click(object sender, EventArgs e)
        {
            frmHomePage.frmHP.pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.Bangkok;
            frmHomePage.frmHP.cbxCities.Text = "Bangkok(Thailand)";
            frmHomePage.frmHP.Distination = 341;
        }

        private void btnIstanbul_Click(object sender, EventArgs e)
        {
            frmHomePage.frmHP.pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.istanbul;
            frmHomePage.frmHP.cbxCities.Text = "Istanbul(Turkey)";
            frmHomePage.frmHP.Distination = 154;
        }
    }
}
