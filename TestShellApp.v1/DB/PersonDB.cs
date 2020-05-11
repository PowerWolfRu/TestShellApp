using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    public class PersonDB
    {
        List<Person> people = new List<Person>();
        int autoIncrement = 1;
        
        public List<Person> conrectePeople { get => people; }

        DataContractJsonSerializer json =   
            new DataContractJsonSerializer(typeof(List<Person>));

        public void SavePerson()
        {
            using (FileStream fs = new FileStream("person.json", FileMode.Create, FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(autoIncrement), 0, 4);
                json.WriteObject(fs, people);
            }
        }

        public PersonDB()
        {
            if (!File.Exists("person.json"))
                return;
            using (FileStream fs = new FileStream("person.json", FileMode.Open, FileAccess.Read))
            {
                byte[] temp = new byte[4];
                fs.Read(temp, 0, 4);
                autoIncrement = BitConverter.ToInt32(temp, 0);
                people = (List<Person>)json.ReadObject(fs); 
            }
        }

        public Person AddPerson()
        {
            var peoples = new Person { ID = autoIncrement++ };
            people.Add(peoples);
            return peoples;
        }
    }
}
