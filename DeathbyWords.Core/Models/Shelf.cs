using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DeathByWords.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DeathbyWords.Services.Models
{
    [DataContract]
    public class Shelf
    {
        [DataMember(Name = "kind")]
        public string Name { get; set; }

        [DataMember]
        public List<Book> items { get; set; }

        //public List<Book> items { get; set; }
 
    }
}
