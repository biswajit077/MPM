using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManPowerManagement.Infrastructure;
using ManPowerManagement.Models;

namespace ManPowerManagement
{
    public partial class UserInformation : Form
    {
        public UserInformation()
        {
            InitializeComponent();
        }

        private void UserInformation_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> lstColors = new List<KeyValuePair<string, string>>();
            Array colors = Enum.GetValues(typeof(UserStatus));
            foreach (UserStatus color in colors)
            {
                lstColors.Add(new KeyValuePair<string, string>(color.ToString(), ((int)color).ToString()));
            }
            branchComboBox.DataSource = lstColors;
            branchComboBox.DisplayMember = "Key";
            branchComboBox.ValueMember = "Value";
        }

        private void SetControlMode(string mode)
        {
            if (mode == "Clear")
            {
                //this.ErrorProvider.ClearAllErrorMessages();
            }
            else if (mode == "Modify")
            {

            }
        }

        private void DisplayListData(ListBox aListBox, Object Data, string DisplayMember, string ValueMember)
        {

        }

        //private void DisplayDepartmentCombo()
        //{
        //    ArrayList aList = new ArrayList();
        //    Branch aParameterList  = new Branch();

        //    aList = CType(Utility.GetData("GetDepartmentList", aParameterList), ArrayList);
        //    Utility.DisplayComboData(Me.cboDepartment, aList.Clone, "DepartmentName", "DepartmentID")
        //    aList.Insert(0, New Department)
        //    Utility.DisplayComboData(Me.cboDepartmentForSearch, aList.Clone, "DepartmentName", "DepartmentID")
        //}
        
    }
}
