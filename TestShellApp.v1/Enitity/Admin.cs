using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    [DataContract]
    public class Admin
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string SecondName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}
