using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManPowerManagement.Models;

namespace ManPowerManagement.Infrastructure
{
    public static class MPMExtensionMethod
    {
        public static void DisplayListViewData(ListView aListView, object Data, Dictionary<String, int> aDictionary)
        {
            ArrayList aList = (ArrayList) Data;
            aListView.Clear();
            aListView.MultiSelect = false;
            string columns;
            int width;
            int NoOfColumns = 0;
            foreach (KeyValuePair<String, int> KVP in aDictionary)
            {
                columns = KVP.Key.ToString();
                width = KVP.Value;
                aListView.Columns.Add(columns, width);
                NoOfColumns = NoOfColumns + 1;
            }

            int i = 0;
            while (i < aList.Count)
            {
                Role aPFIncomeFromLapsesAndForfeiture  = new Role();
                aPFIncomeFromLapsesAndForfeiture = (Role) aList[i];
                ListViewItem alistviewItem = new ListViewItem();
                alistviewItem = aListView.Items.Add(aPFIncomeFromLapsesAndForfeiture.Id.ToString());
                alistviewItem.SubItems.Add(aPFIncomeFromLapsesAndForfeiture.RoleName);
                i = i + 1;
            }
        }

    }
}
