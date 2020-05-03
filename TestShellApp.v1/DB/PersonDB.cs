using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    public class PersonDB
    {
        List<Person> person;
        Serializer<List<Person>> serializer;

        string filepath;
        int AutoIncrement = 1;

        static PersonDB instance;

        public static PersonDB GetInstance()
        {
            if (instance == null)
                instance = new PersonDB();
            return instance;
        }

        private PersonDB()
        {
            filepath = "person.bin";
            serializer = new Serializer<List<Person>>(filepath);
            person = serializer.Load(ref AutoIncrement);
        }

        public Person CreatePerson(string fname, string sname, string lname)
        {
            var persons = new Person(fname, sname, lname);
            person.Add(persons);
            return persons;
        }
        
        public void Save()
        {
            serializer.Save(person, AutoIncrement);
        }

        public List<Person> GetPerson()
        {
            return person.Select(s => s)?.ToList();
        }
    }
}
