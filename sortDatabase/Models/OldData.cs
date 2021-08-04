using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sortDatabase.Models
{
    public class OldData
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalNumer { get; set; }
        public Manger Manger { get; set; }
        public int MangerId { get; set; }
    }
}
