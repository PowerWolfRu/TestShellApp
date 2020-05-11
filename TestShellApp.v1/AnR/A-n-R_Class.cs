using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    [Serializable]
    public class A_n_R_Class : List<User>
    {
        

        public bool SingIn(string log, string pass, Status status)
        {
            var user = this.FirstOrDefault(u => u.Login == log);
            var stat = this.FirstOrDefault(u => u.Status == status);
            if (user == null) throw new Exception("Неверный логин");

            if (user.Password != pass) throw new Exception("Неверный пароль");

            return true;
        }

        
    }
}
