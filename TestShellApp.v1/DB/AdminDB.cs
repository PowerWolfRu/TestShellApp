using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    public class AdminDB
    {
        Admin admin = new Admin();

        public Admin admin_info { get => admin; }

        DataContractJsonSerializer json =
            new DataContractJsonSerializer(typeof(List<Admin>));

        public void SaveAdmin()
        {
            using(FileStream fs = new FileStream("admin.json", FileMode.Create, FileAccess.Write))
            {
                json.WriteObject(fs, admin);
            }
        }


        public AdminDB()
        {
            if (!File.Exists("admin.json"))
                return;
            using(FileStream fs = new FileStream("admin.json", FileMode.Open, FileAccess.Read))
            {
                admin = (Admin)json.ReadObject(fs);
            }
        }
    }
}
