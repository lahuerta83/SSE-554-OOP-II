using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace DogGroomer_MVVM.ViewModel
{
    class DogViewModel
    {
        public string Name { get; set; }
       

        public DogViewModel(string name)
        {
            Name = name;
          
        }
    }
}
