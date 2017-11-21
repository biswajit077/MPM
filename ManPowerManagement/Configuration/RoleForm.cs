using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManPowerManagement.Infrastructure;
using ManPowerManagement.Models;
using MPMCrypto;

namespace ManPowerManagement.Configuration
{
    public partial class RoleForm : Form
    {
        private readonly MPMEntity _db = new MPMEntity();
        //private bool ClickFlag = false;
        public RoleForm()
        {
            InitializeComponent();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            List<Role> nList = _db.Roles.ToList();
            //ArrayList listData = new ArrayList(nList);
            //DisplayListViewData(this.lstRole, listData, CreateDictionary(listData));
            InitializeListView();
            LoadList(nList);
        }
        // Initialize ListView
        private void InitializeListView()
        {
            lstRole.CheckBoxes = true;
            lstRole.MultiSelect = false;
            // Set the view to show details.
            lstRole.View = View.Details;

            // Allow the user to edit item text.
            lstRole.LabelEdit = false;

            // Allow the user to rearrange columns.
            lstRole.AllowColumnReorder = true;

            // Select the item and subitems when selection is made.
            lstRole.FullRowSelect = true;

            // Display grid lines.
            lstRole.GridLines = false;

            // Sort the items in the list in ascending order.
            lstRole.Sorting = SortOrder.Ascending;

            // Attach Subitems to the ListView
            //lstRole.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstRole.Columns.Add("Role Name", 300, HorizontalAlignment.Left);

            // The ListViewItemSorter property allows you to specify the
            // object that performs the sorting of items in the ListView.
            // You can use the ListViewItemSorter property in combination
            // with the Sort method to perform custom sorting.
            //_lvwItemComparer = new ListViewItemComparer();
            //this.lstRole.ListViewItemSorter = _lvwItemComparer;
        }
        private void LoadList(List<Role> list)
        {
            // Clear the ListView control
            lstRole.Items.Clear();

            // Display items in the ListView control
            for (int i = 0; i < list.Count; i++)
            {
                    // Define the list items
                    ListViewItem lvi = new ListViewItem(list[i].RoleName);
                //ListViewItem lvi = new ListViewItem(list[i].Id.ToString());
                lvi.SubItems.Add(list[i].RoleName.ToString());
                // Add the list items to the ListView
                lstRole.Items.Add(lvi);
            }
        }
        private Dictionary<string, int> CreateDictionary(ArrayList aList)
        {
            Dictionary<string,int> aDictionary = new Dictionary<string, int>();
            if (aList.Count > 0)
            {
                aDictionary.Add("Role Name", 130);
            }
            return aDictionary;
        }

        private void DisplayListViewData(ListView aListView, Object Data, Dictionary<string, int> aDictionary)
        {
            ArrayList aList = new ArrayList();
            aList = (ArrayList) Data;
            aListView.Clear();
            aListView.MultiSelect = false;
            string columns;
            int width;
            int NoOfColumns = 0;
            foreach (KeyValuePair<string, int> KVP in aDictionary)
            {
                columns = KVP.Key.ToString();
                width = KVP.Value;
                aListView.Columns.Add(columns, width);
                NoOfColumns = NoOfColumns + 1;
            }
            int i = 0;
            while (i < aList.Count)
            {
                Role aRole = new Role();
                aRole = (Role) aList[i];
                ListViewItem alistviewItem = new ListViewItem();
                alistviewItem = aListView.Items.Add(aRole.RoleName, aRole.RoleName, i.ToString());
                alistviewItem.Tag = aRole;
                alistviewItem.SubItems.Add(aRole.RoleName.ToString());
                i = i + 1;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            if (!string.IsNullOrEmpty(txtRoleName.Text))
            {
                if (RoleNameExistsOrNot(txtRoleName.Text))
                {
                    Utility.ShowNotice("Role Name Already Exists.");
                }
                else
                {
                    role.RoleName = txtRoleName.Text;
                    _db.Roles.Add(role);
                    ;
                    if (_db.SaveChanges() != 0)
                    {
                        Utility.ShowMessage("Role Name Saved Successfully.");
                        ReloadForm();
                    }
                    else
                    {
                        Utility.ShowError("Please Try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the role name first.");
            }
        }
        private ListViewItem lastItemChecked;
        private void lstRole_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // if we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it
            if (lastItemChecked != null && lastItemChecked.Checked
                && lastItemChecked != lstRole.Items[e.Index])
            {
                // uncheck the last item and store the new one
                lastItemChecked.Checked = false;
            }

            // store current item
            lastItemChecked = lstRole.Items[e.Index];

            this.lstRole.FullRowSelect = true;
            int Index = e.Index;
            ListViewItem LsvItem = this.lstRole.Items[Index];
            Role r = (Role) lstRole.Items[Index].Tag;
            //r = _db.Roles.Find(Int32.Parse(LsvItem.Text));
            r = _db.Roles.FirstOrDefault(x=>x.RoleName.Equals(LsvItem.Text));
            txtRoleName.Text = r.RoleName;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ListViewItem LsvItem = this.lstRole.CheckedItems[0];
            if (LsvItem.Checked)
            {
              Role role =  _db.Roles.FirstOrDefault(x => x.RoleName.Equals(LsvItem.Text));
                if (role != null)
                {
                    if (RoleNameExistsOrNot(txtRoleName.Text))
                    {
                        Utility.ShowNotice("Role Name Already Exists.");
                    }
                    else
                    {
                        role.RoleName = txtRoleName.Text;
                        _db.Roles.AddOrUpdate(role);

                        if (_db.SaveChanges() != 0)
                        {
                            Utility.ShowMessage(LsvItem.Text + " Role Successfully Updated");
                            ReloadForm();
                        }
                        else
                        {
                            Utility.ShowError(LsvItem.Text + " didn't update");
                        }
                    }
                }
            }  
        }

        private void ReloadForm()
        {
            lstRole.Clear();
            txtRoleName.Clear();
            this.RoleForm_Load(Controls.Owner.FindForm(), new EventArgs());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem LsvItem = this.lstRole.CheckedItems[0];
            if (LsvItem.Checked)
            {
                Role role = _db.Roles.FirstOrDefault(x => x.RoleName.Equals(LsvItem.Text));
                if (role != null)
                {
                    role.RoleName = txtRoleName.Text;
                    _db.Roles.Remove(role);

                    if (_db.SaveChanges() != 0)
                    {
                        Utility.ShowMessage(LsvItem.Text + " Role Successfully Removed");                       
                        ReloadForm();
                    }
                    else
                    {
                        Utility.ShowMessage(LsvItem.Text + " Role didn't Removed");
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoleName.Clear();
            txtRoleSearch.Clear();
        }

        private void btnRoleSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRoleSearch.Text))
            {
                List<Role> roles = _db.Roles.Where(x => x.RoleName.Contains(txtRoleSearch.Text)).ToList();
                LoadList(roles);
            }
            else
            {
                Utility.ShowNotice("Please type Role Name in the search box, then try again.");
                ReloadForm();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool RoleNameExistsOrNot(string roleName)
        {
           return _db.Roles.Count(x => x.RoleName.Equals(roleName)) > 0;
        }
    }
}
