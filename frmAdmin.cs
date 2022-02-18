using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTSLibrary;

namespace AdminApplication
{
    public partial class frmAdmin : Form
    {
        private PTSAdminFacade facade;
        private int adminId;
        public frmAdmin()
        {
            InitializeComponent();
            facade = new PTSAdminFacade();
            adminId = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                adminId = facade.Authenticate(this.txtUsername.Text, this.txtPassword.Text);
                if(adminId!=0)
                {
                    this.txtUsername.Text = "";
                    this.txtPassword.Text = "";
                    MessageBox.Show("Successfully LoggedIn");
                }
                else
                {
                    MessageBox.Show("Wrong login details");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

      
    }
}
