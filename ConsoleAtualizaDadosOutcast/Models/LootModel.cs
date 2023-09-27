using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace StatsOutcast.Models
{
    [DataContract]
    public class LootModel
    {
        public DateTime Data { get; set; }
        public String Boss { get; set; }
        [DataMember(Name = "label")]
        public String Item { get; set; }
        public String LootCompleto { get; set; }
        [DataMember(Name = "y")]
        public int Quantidade { get; set; }
       
    }
}
