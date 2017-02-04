using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGroomer_MVVM.Model
{
    class Groomer
    {
        public string GroomerName { get; private set; }

        private readonly List<Dog> dogs = new List<Dog>();
        public IEnumerable<Dog> Dogs
        {
            get { return new List<Dog>(dogs); }
        }

        public Groomer(string groomerName, IEnumerable<Dog> dog)
        {
            GroomerName = groomerName;
            dogs.AddRange(dog);
        }
    }
}
