using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public Status Status { get; set; }
        
    }
}
