using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGroomer_MVVM
{
    class Dog
    {
        public string Name { get; private set; }
        public bool Groomed { get; private set; }

        public Dog(string name, bool groomed)
        {
            Name = name;
            Groomed = groomed;
        }

       
    }
}
