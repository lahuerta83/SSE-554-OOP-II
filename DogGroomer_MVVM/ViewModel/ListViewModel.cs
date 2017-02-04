using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DogGroomer_MVVM.View;
using System.Windows.Threading;

namespace DogGroomer_MVVM.ViewModel
{
    using Model;
    using System.Collections.ObjectModel;

    class ListViewModel
    {
        public GroomerViewModel AmysList { get; set; }
        public GroomerViewModel KaylasList { get; set; }

        public ListViewModel()
        {
            Groomer amylist = new Groomer("Amy's List", AmyDogs());
            AmysList = new GroomerViewModel(amylist);
            Groomer kaylalist = new Groomer("Kayla's List", Kayladogs());
            KaylasList = new GroomerViewModel(kaylalist);
        }

        private IEnumerable<Dog> Kayladogs()
        {
            List<Dog> dogbykayla = new List<Dog>() {
                new Dog("Roscoe", true),
                new Dog("Spot", true),
                new Dog("Fido", false),
                new Dog("Rocky", true),
                new Dog("Shoebox", true),
                new Dog("Spike", false),
                new Dog("Toby", false),
            };
            return dogbykayla;
        }

        private IEnumerable<Dog> AmyDogs()
        {
            List<Dog> dogbyamy = new List<Dog>() {
                new Dog("Allie", true),
                new Dog("Fifi", true),
                new Dog("Luke", true),
                new Dog("Moose", true),
                new Dog("Boomer", false),
                new Dog("Cleo",  false),
                new Dog("Rigbe", false),
            };
            return dogbyamy;
        }
    }
}
