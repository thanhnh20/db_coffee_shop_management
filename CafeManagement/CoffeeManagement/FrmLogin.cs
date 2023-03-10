using Library.Model;
using Library.Service;
using Library.Service.ServiceImplement;
using Library.Utils;
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
    public partial class FrmLogin : Form
    {
         
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //Code login
            string username = txtUsername.Text;
            string password = TxtPassword.Text;
            
            var accountInput = new Account()
            {
                Username = username,
                Password = password,
            };
            var resultError = MyHelper.CheckValid(accountInput);
            if(resultError != null)
            {
                foreach (var failcase in resultError)
                {
                    MessageBox.Show(failcase.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                IAccountService accountService = new AccountServiceIml();
                var account = accountService.checkLogin(username, password);
                if (account != null)
                {
                    if (account.RoleId == 0)
                    {
                        FrmAdminDashboard frmAdminDashboard = new FrmAdminDashboard();
                        this.Hide();
                        frmAdminDashboard.ShowDialog();
                    }
                    else if (account.RoleId == 1)
                    {
                        FrmStaffDashboard frmStaffDashboard = new FrmStaffDashboard();
                        this.Hide();
                        frmStaffDashboard.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
            }             
        }
    }
}
