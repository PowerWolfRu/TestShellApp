using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    [Serializable]
    public class User
    {
        public int ID { get; private set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Status Status { get; set; }

        

        public User(string login, string pass, Status status, int id) 
        {
            ID = id;
            Login = login;
            Password = pass;
            Status = status;
        }
    }
}
