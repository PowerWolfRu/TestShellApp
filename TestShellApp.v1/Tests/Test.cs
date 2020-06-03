using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    [DataContract]
    public class Test
    {
        [DataMember]
        public int ID { get; set;}
        [DataMember]
        public string[] Question { get; set; }
        [DataMember]
        public string[] rightAnswer { get; set; }
        [DataMember]
        public string[] wrongAnswer { get; set; }
        [DataMember]
        public string[] _Test { get; set; }
        [DataMember]
        public Category Category { get; set; }
    }
}
