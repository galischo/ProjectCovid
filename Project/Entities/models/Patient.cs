using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.models;

namespace Entities
{
    public partial class Patient
    {
         
        public int id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String tz { get; set; }
        public String city { get; set; }
        public String street { get; set; }
        public int numStreet { get; set; }
        public DateTime birthDate { get; set; }
        public string phone { get; set; }
        public string phoneNumber { get; set; }
        public DateTime dateRecovery { get; set; }
        public DateTime datePositiveResult { get; set; }
        public ICollection<Corona> coronaDates  { get; set; }


    }
}
