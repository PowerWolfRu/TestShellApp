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
        Person person = new Person();

        public Person person_info { get => person; }

        DataContractJsonSerializer json = 
            new DataContractJsonSerializer(typeof(List<Person>));

        public void SavePerson()
        {
            using(FileStream fs = new FileStream("person.json", FileMode.Create, FileAccess.Write))
            {
                json.WriteObject(fs, person);
            }
        }

        public PersonDB()
        {
            if (!File.Exists("person.json"))
                return;
            using(FileStream fs = new FileStream("person.json", FileMode.Open, FileAccess.Read))
            {
                person = (Person)json.ReadObject(fs);
            }
        }
    }
}
