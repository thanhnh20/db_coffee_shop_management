using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class FrmStaffProfile : Form
    {
        public FrmStaffDashboard FrmStaffDashboard { get; set; }
        public FrmStaffProfile()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmStaffEditProfile frmStaffEditProfile = new FrmStaffEditProfile();
            frmStaffEditProfile.ShowDialog();
        }
    }
}
