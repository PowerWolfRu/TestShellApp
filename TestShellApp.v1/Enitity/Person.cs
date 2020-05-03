using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    [Serializable]
    public class Person
    {
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Lname { get; set; }


        public Person(string fname, string sname, string lname)
        {
            Fname = fname;
            Sname = sname;
            Lname = lname;
            
        }
    }
}
