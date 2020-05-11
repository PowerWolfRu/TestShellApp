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
    public class UserDB
    {
        List<User> users = new List<User>();
        int autoIncrement = 1;
        
        public List<User> conrecteUser { get => users; }

        DataContractJsonSerializer json = 
            new DataContractJsonSerializer(typeof(List<User>));

        public void SaveUser()
        {
            using (FileStream fs = new FileStream("user.json", FileMode.Create, FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(autoIncrement), 0, 4);
                json.WriteObject(fs, users);
            }
        }

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("user.json"))
            {
                string json = r.ReadToEnd();
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                
            }
        }

        public UserDB()
        {
            if (!File.Exists("user.json"))
                return;
            using (FileStream fs = new FileStream("user.json", FileMode.Open, FileAccess.Read))
            {
                byte[] temp = new byte[4];
                fs.Read(temp, 0, 4);
                autoIncrement = BitConverter.ToInt32(temp, 0);
                users = (List<User>)json.ReadObject(fs);
            }
        }

        public User AddUser()
        {
            var user = new User { ID = autoIncrement++};
            users.Add(user);
            return user;
        }
    }
}
