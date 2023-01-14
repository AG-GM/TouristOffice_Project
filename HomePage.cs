using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Transactions;
using System.Xml.Linq;

namespace TouristOffice
{
    public partial class frmHomePage : Form
    {
        public static frmHomePage frmHP;
        public int counter;
        public frmDisplayC C;
        public frmDisplayA A;
        public frmDisplayI I;
        public static string frmID;
        public static bool Confirm;
        public double AirlineDB;
        public double ClassDB;
        public double Distination;
        public double TotalTo;
        
        public frmHomePage()
        {
            InitializeComponent();
            frmHP = this;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(255, 64, 46);
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;

        }
        private void picMax_MouseHover(object sender, EventArgs e)
        {
            picMax.BackColor = Color.FromArgb(91, 113, 164);
        }

        private void picMax_MouseLeave(object sender, EventArgs e)
        {
            picMax.BackColor = Color.Transparent;
        }
        private void picMin_MouseHover(object sender, EventArgs e)
        {
            picMin.BackColor = Color.FromArgb(91, 113, 164);
        }

        private void picMin_MouseLeave(object sender, EventArgs e)
        {
            picMin.BackColor = Color.Transparent;
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            lblEmptyAdult.Hide();
            lblEmptyAirLine.Hide();
            lblEmptyClass.Hide();
            lblEmptyCities.Hide();
            btnAdminPanel.Hide();
            btnCloseAdmin.Hide();
            dgvAdminPanel.Hide();
            lblEmptyInfant.Hide();
            lblEmptyChild.Hide();
            //picPfp.ImageLocation = "https://findicons.com/files/icons/2711/free_icons_for_windows8_metro/512/guest.png";
            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=TouristOffice1.accdb");
            OleDbCommand command = new OleDbCommand($"Select * from UserChoices", con);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdminPanel.DataSource = dt;
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            if (counter == 2 || counter == 3)
            {
                if(counter == 2)
                {
                    A.Close();
                }
                else if (counter == 3)
                {
                    I.Close();
                }
                C = new frmDisplayC() { TopLevel = false, TopMost = true };
                C.FormBorderStyle = FormBorderStyle.None;
                pnlDisplay.Controls.Add(C);
                C.Show();
                C.Dock = DockStyle.Fill;
            }
            else if(counter == 0)
            {
                C = new frmDisplayC() { TopLevel = false, TopMost = true };
                C.FormBorderStyle = FormBorderStyle.None;
                pnlDisplay.Controls.Add(C);
                C.Show();
                C.Dock = DockStyle.Fill;

            }
            counter = 1;
        }

        private void btnAirLines_Click(object sender, EventArgs e)
        {
            
            if (counter == 1 || counter == 3)
            {
                if (counter == 1)
                {
                    C.Close();
                }
                else if (counter == 3)
                {
                    I.Close();
                }
                A = new frmDisplayA() { TopLevel = false, TopMost = true };
                A.FormBorderStyle = FormBorderStyle.None;
                pnlDisplay.Controls.Add(A);
                A.Show();
                A.Dock = DockStyle.Fill;
            }
            else if(counter == 0)
            {
                A = new frmDisplayA() { TopLevel = false, TopMost = true };
                A.FormBorderStyle = FormBorderStyle.None;
                pnlDisplay.Controls.Add(A);
                A.Show();
                A.Dock = DockStyle.Fill;
            }
            counter = 2;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (counter == 1 || counter == 2)
            {
                if (counter == 2)
                {
                    A.Close();
                }
                else if (counter == 1)
                {
                    C.Close();
                }
                I = new frmDisplayI() { TopLevel = false, TopMost = true };
                I.FormBorderStyle = FormBorderStyle.None;
                pnlDisplay.Controls.Add(I);
                I.Show();
                I.Dock = DockStyle.Fill;
            }
            else if (counter == 0)
            {
                I = new frmDisplayI() { TopLevel = false, TopMost = true };
                I.FormBorderStyle = FormBorderStyle.None;
                pnlDisplay.Controls.Add(I);
                I.Show();
                I.Dock = DockStyle.Fill;
            }
            counter = 3;
        }

        private void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCities.Text == "Istanbul(Turkey)")
            {
                pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.istanbul;
            }
            else if(cbxCities.Text == "Bangkok(Thailand)")
            {
                pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.Bangkok;
            }
            else if (cbxCities.Text == "Ankara(Turkey)")
            {
                pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.Ankara;
            }
            else if (cbxCities.Text == "Alghero(Italy)")
            {
                pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.Alghero;
            }
            else if (cbxCities.Text == "Abu Dhabi(UAE)")
            {
                pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.Abu_Dhabi;
            }
            else if (cbxCities.Text == "Aqaba(Jordan)")
            {
                pnlBackGroundDisplay.BackgroundImage = TouristOffice.Properties.Resources.aqaba;
            }
        }

        private void cbxAirLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxAirLines.Text == "Royal Jordanian")
            {
                pnlAirLines.BackgroundImage = TouristOffice.Properties.Resources.RoyalJordanian;

            }
            else if (cbxAirLines.Text == "Air Cairo")
            {
                pnlAirLines.BackgroundImage = TouristOffice.Properties.Resources.Air_Cairo;

            }
            else if (cbxAirLines.Text == "Turkish Airlines")
            {
                pnlAirLines.BackgroundImage = TouristOffice.Properties.Resources.Turkish_Airlines;

            }
            else if (cbxAirLines.Text == "Fly Emirates")
            {
                pnlAirLines.BackgroundImage = TouristOffice.Properties.Resources.FlyEmirates;

            }
        }

        private void cbxAdult_TextChanged(object sender, EventArgs e)
        {

            if (cbxAdult.Text != "")
            {
                cbxAdult.Text = "";
            }
        }

        private void cbxChild_TextChanged(object sender, EventArgs e)
        {
            
            if (cbxChild.Text != "")
            {
                cbxChild.Text = "";
            }
        }

        private void cbxInfant_TextChanged(object sender, EventArgs e)
        {
            if (cbxInfant.Text != "")
            {
                cbxInfant.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbxAdult.Text == "" || cbxAirLines.Text == "" || cbxCities.Text == "" || cbxClass.Text == "" || cbxChild.Text == "" || cbxInfant.Text == "")
            {
                if (cbxAdult.Text == "")
                {
                    lblEmptyAdult.Show();
                }
                else
                {
                    lblEmptyAdult.Hide();
                }
                if (cbxAirLines.Text == "")
                {
                    lblEmptyAirLine.Show();
                }
                else
                {
                    lblEmptyAirLine.Hide();
                }
                if (cbxCities.Text == "")
                {
                    lblEmptyCities.Show();
                }
                else
                {
                    lblEmptyCities.Hide();
                }
                if (cbxClass.Text == "")
                {
                    lblEmptyClass.Show();
                }
                else
                {
                    lblEmptyClass.Hide();
                }
                if (cbxChild.Text == "")
                {
                    lblEmptyChild.Show();
                }
                else
                {
                    lblEmptyChild.Hide();
                }
                if (cbxInfant.Text == "")
                {
                    lblEmptyInfant.Show();
                }
                else
                {
                    lblEmptyInfant.Hide();
                }
            }
            else if (lblUserName.Text == "Admin")
            {
                MessageBox.Show("You cant continue with this action in an admin account");
            }
            else if (lblUserName.Text != "Guest")
            {
                double TotalDB = ((Distination + ClassDB + AirlineDB) * double.Parse(cbxAdult.Text)) + (((Distination + ClassDB + AirlineDB) / 2) * double.Parse(cbxChild.Text)) + (((Distination + ClassDB + AirlineDB) / 4) * double.Parse(cbxInfant.Text));
                TotalTo = TotalDB;
                frmConfirm s = new frmConfirm();
                s.ShowDialog();
                if (Confirm == true)
                {
                    string Transaction_owner = frmID;
                    string Cities = cbxCities.Text;
                    string Adult = cbxAdult.Text;
                    string Child = cbxChild.Text;
                    string Infant = cbxInfant.Text;
                    string Class = cbxClass.Text;
                    string AirLines = cbxAirLines.Text;
                    OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=TouristOffice1.accdb");
                    string insertCommand = $"Insert into UserChoices([Transaction owner], [Cities], [Adult], [Child], [Infant], [Class], [AirLine], [Total]) values('{Transaction_owner}', '{Cities}', '{Adult}', '{Child}', '{Infant}', '{Class}', '{AirLines}', '{TotalDB.ToString()}')";
                    OleDbCommand command = new OleDbCommand(insertCommand, con);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            else
            {
                frmYouMustLoginFirst s = new frmYouMustLoginFirst();
                s.ShowDialog();
            }
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            lblAdult.Hide();
            lblChild.Hide();
            lblInfant.Hide();
            lblClass.Hide();
            lblCities.Hide();
            lblAirLine.Hide();
            cbxAdult.Hide();
            cbxAirLines.Hide();
            cbxChild.Hide();
            cbxCities.Hide();
            cbxClass.Hide();
            cbxInfant.Hide();
            btnSubmit.Hide();
            btnCloseAdmin.Show();
            dgvAdminPanel.Show();
            dgvAdminPanel.ForeColor = Color.Black;
        }

        private void cbxCities_TextChanged(object sender, EventArgs e)
        {
            if (cbxCities.Text == "Aqaba(Jordan)")
            {
                Distination = 25;
            }
            else if (cbxCities.Text == "Abu Dhabi(UAE)")
            {
                Distination = 110;
            }
            else if (cbxCities.Text == "Alghero(Italy)")
            {
                Distination = 41;
            }
            else if (cbxCities.Text == "Ankara(Turkey)")
            {
                Distination = 143;
            }
            else if (cbxCities.Text == "Bangkok(Thailand)")
            {
                Distination = 341;
            }
            else if (cbxCities.Text == "Istanbul(Turkey)")
            {
                Distination = 154;
            }
        }

        private void cbxClass_TextChanged(object sender, EventArgs e)
        {
            if (cbxClass.Text == "First")
            {
                ClassDB = Distination * 3;
            }
            else if (cbxClass.Text == "Business")
            {
                ClassDB = Distination * 2;
            }
            else if (cbxClass.Text == "Premium Economy")
            {
                ClassDB = Distination * 0.3;
            }
            if (cbxClass.Text == "None.")
            {
                cbxClass.Text = null;
            }
            else if (cbxClass.Text != "")
            {
                cbxClass.Text = "";
            }
        }

        private void cbxAirLines_TextChanged(object sender, EventArgs e)
        {
            if (cbxAirLines.Text == "Royal Jordanian")
            {
                AirlineDB = 12;
            }
            else if (cbxAirLines.Text == "Air Cairo")
            {
                AirlineDB = 6;
            }
            else if (cbxAirLines.Text == "Turkish Airlines")
            {
                AirlineDB = 15;
            }
            else if (cbxAirLines.Text == "Fly Emirates")
            {
                AirlineDB = 10;
            }
        }

        private void lblUserName_TextChanged(object sender, EventArgs e)
        {
            if(lblUserName.Text == "Admin")
            {
                btnAdminPanel.Show();
            }
        }

        private void btnCloseAdmin_Click(object sender, EventArgs e)
        {
            lblAdult.Show();
            lblChild.Show();
            lblInfant.Show();
            lblClass.Show();
            lblCities.Show();
            lblAirLine.Show();
            cbxAdult.Show();
            cbxAirLines.Show();
            cbxChild.Show();
            cbxCities.Show();
            cbxClass.Show();
            cbxInfant.Show();
            btnSubmit.Show();
            btnCloseAdmin.Hide();
            dgvAdminPanel.Hide();
            btnAdminPanel.Show();
        }
    }
}