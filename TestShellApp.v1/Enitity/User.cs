using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    [Serializable]
    public class User
    {
        public string Login { get; set; }
        public int PasswordHash { get; set; }    
        
        public User(string log, string pass)
        {
            Login = log;
            PasswordHash = pass.GetHashCode();
        }
    }
}
