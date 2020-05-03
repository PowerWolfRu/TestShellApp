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
        User users;

        public bool SingIn(string log, string pass)
        {
            var user = this.FirstOrDefault(u => u.Login == log);
            if (user == null) throw new Exception("Неверный логин");

            if (user.Password != pass) throw new Exception("Неверный пароль");

            return true;
        }

        public void SingUpNewUser(string log, string pass,Status status, int id)
        {
            if (this.Any(u => u.Login == log))
                throw new Exception("Такой логин уже существует");
            
            Add(new User(log, pass, status, id));
        }
        

        
    }
}
