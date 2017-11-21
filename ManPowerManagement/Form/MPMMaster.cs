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
using ManPowerManagement.Configuration;

namespace WindowsFormsApplication1
{
    public partial class MPMMaster : Form
    {
        public MPMMaster()
        {
            InitializeComponent();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //User user = new User();
            //user.MdiParent = this; // Open the user page in the Main page
            //user.Show();
        }

        private void allUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rprt.Load(@"C:\Users\Nilesh\Documents\visual studio 2010\Projects\WindowsFormsApplication5\WindowsFormsApplication5\CrystalReport1.rpt");
            //SqlCommand cmd = new SqlCommand("sp_select", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //sda.Fill(ds, "Newtbl_data");
            //rprt.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = rprt;

       
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoleForm role = new RoleForm {MdiParent = this};
            role.Show();
        }
    }
}
