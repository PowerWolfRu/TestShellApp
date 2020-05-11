using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Fname { get; set; }
        [DataMember]
        public string Sname { get; set; }
        [DataMember]
        public string Lname { get; set; }
    }
}
