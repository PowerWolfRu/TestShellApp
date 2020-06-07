using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;



namespace TestShellApp.v1
{
    [Serializable]
    public class UserDB : List<User>
    {
        public bool SingIn(string login, string password)
        {
            var user = this.FirstOrDefault(u => u.Login == login);
            if(user == null)
                throw new Exception("Такого пользователя не существует");
            if (user.PasswordHash != password.GetHashCode()) throw new Exception("Неправильный пароль");

            return true;
        }

        public void SingUp(string login, string password)
        {
            if (this.Any(u => u.Login == login))
                throw new Exception("Пользователь с таким именем уже существует");

            Add(new User(login, password));
        }
    }
}
