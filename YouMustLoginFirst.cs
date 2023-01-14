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
    public partial class frmYouMustLoginFirst : Form
    {
        public frmYouMustLoginFirst()
        {
            InitializeComponent();
        }
        
        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
