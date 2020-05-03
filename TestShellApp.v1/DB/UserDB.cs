using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    public class UserDB : List<User>
    {
        Dictionary<int, User> users;
        Serializer<Dictionary<int, User>> serializer;
        string filepath;
        int AutoIncrement = 1;

        static UserDB instance;

        public static UserDB GetInstance()
        {
            if (instance == null)
                instance = new UserDB();
            return instance;
        }

        private UserDB()
        {
            filepath = "user.bin";
            serializer = new Serializer<Dictionary<int, User>>(filepath);
            users = serializer.Load(ref AutoIncrement);
        }

        public void Save()
        {
            serializer.Save(users, AutoIncrement);
        }

        public void SingUpNewUser(string log, string pass, Status status, int id)
        {
            if (this.Any(u => u.Login == log))
                throw new Exception("Такой логин уже существует");
            Add(new User(log, pass, status, id));
        }

        public User GetUserByID(int id)
        {
            return users[id];
        }
        
        public List<User> GetUserByStatus(Status status)
        {
            return users.Where(s => s.Value.Status == status)?.Select(s => s.Value).ToList();
        }

       public List<User> GetUsers()
       {
            return users.Select(s => s.Value)?.ToList();
       }

        public bool SingIn(string log, string pass)
        {
            var user = this.FirstOrDefault(u => u.Login == log);
            if (user == null) throw new Exception("Неверный логин");

            if (user.Password != pass) throw new Exception("Неверный пароль");

            return true;
        }
        

    }
}
