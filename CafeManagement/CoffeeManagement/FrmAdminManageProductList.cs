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
    public partial class FrmAdminManageProductList : Form
    {

        public FrmAdminDashboard FrmAdminDashboard { get; set; }
        public FrmAdminManageProductList()
        {
            InitializeComponent();
        }

        private void BtnAddNewProduct_Click(object sender, EventArgs e)
        {
            FrmAdminInsertNewProduct frm = new FrmAdminInsertNewProduct();
            frm.ShowDialog();
        }
    }
}
