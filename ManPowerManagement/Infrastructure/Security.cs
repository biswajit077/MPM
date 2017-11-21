using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManPowerManagement.Models;

namespace ManPowerManagement.Infrastructure
{
    public class Security
    {
        public bool IsSecurityCheckBypassed;
        private User _LoggedInUser;

        public User LoggedInUser
        {
            get { return _LoggedInUser; }
            set { _LoggedInUser = value; }
        }
        public static string GetIPAddress()
        {
            // To get local address
            string localHostName = Dns.GetHostName();
            IPHostEntry ipEnter = Dns.GetHostEntry(localHostName);
            IPAddress[] ipAddress = ipEnter.AddressList;
            string ipAdd = "";
            foreach (IPAddress t in ipAddress)
            {
                ipAdd = ipAdd + t;
            }
            return "[" + localHostName + "] " + ipAdd;
        }

        public enum Actions
        {
            Add,
            Edit,
            Delete,
            NoRestriction,
        }
    }
}
