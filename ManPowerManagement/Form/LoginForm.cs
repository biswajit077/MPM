using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManPowerManagement.Infrastructure;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        private readonly MPMEntity _db;
        public LoginForm()
        {
            InitializeComponent();
            _db = new MPMEntity();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int row = _db.Users.Count(x => x.UserName.Equals(txtUserName.Text.Trim()) & x.UserPassword.Equals(MPMCrypto.Crypto.ComputeHash(txtPassword.Text.Trim(), "SHA256", null)));
            if (row > 0 )
            {
                this.Hide(); 
                MPMMaster mpmMaster = new MPMMaster();
                mpmMaster.Show(); // Show the Main Page
            }
            else
            {
                Utility.ShowMessage("User Name or User Password Not valide, Please try again.");
            }
        }
    }
}
