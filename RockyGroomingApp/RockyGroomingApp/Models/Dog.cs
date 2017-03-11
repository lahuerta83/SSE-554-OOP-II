using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockyGroomingApp.Models
{
    public class Dog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Appointment { get; set; }
        public string Service { get; set; }
        public string Groomer { get; set; }
    }
}
