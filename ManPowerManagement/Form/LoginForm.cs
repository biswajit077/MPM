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

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Biswajit Mandal\Desktop\WindowsFormsApplication1\WindowsFormsApplication1\App_Data\Demo.mdf;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select r.RoleName From Users u join Roles r on u.RoleId = r.Id Where UserName = '"+ txtUserName.Text+"'And UserPassword = '" + txtPassword.Text+"'",connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide(); // Hide the Login Page
                MessageBox.Show("Super Admin");
                MPMMaster mpmMaster = new MPMMaster();

                //mpmMaster.Controls["toolStripStatusLabel1"].Text = "Super Admin";
                //((Form) this.MdiParent).Controls["toolStripStatusLabel1"].Text = dt.Rows[0][0].ToString();
                mpmMaster.Show(); // Show the Main Page
            }
            else
            {
                
            }
        }
    }
}
