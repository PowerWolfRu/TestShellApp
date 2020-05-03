using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    [Serializable]
    public class Admin
    {
        public string AdminLogin { get; set; }
        public string AdminPassword { get; set; }

        public Admin(string alog, string apass)
        {
            AdminLogin = alog;
            AdminPassword = apass;
        }
    }
}
