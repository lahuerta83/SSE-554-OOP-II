using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using DogGroomer_MVVM.Model;

namespace DogGroomer_MVVM.ViewModel
{
    using Model;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    class GroomerViewModel
    {
        public ObservableCollection<DogViewModel> NeedsGroom { get; set; }
        public ObservableCollection<DogViewModel> Done { get; set; }

        private Groomer groomer;


        private string groomername;
        public string GroomerName
        {
            get { return groomername; }
            set
            {
                groomername = value;
            }
        }

        public GroomerViewModel(Groomer groomers)
        {
            groomer = groomers;

            NeedsGroom = new ObservableCollection<DogViewModel>();
            Done = new ObservableCollection<DogViewModel>();

            GroomerName = groomer.GroomerName;

            UpdateGroomer();
        }

        private void UpdateGroomer()
        {
            var needsgroom =
                from dog in groomer.Dogs
                where dog.Groomed
                select dog;

            foreach (Dog dog in needsgroom)
                NeedsGroom.Add(new DogViewModel(dog.Name));

            var done =
                from dog in groomer.Dogs
                where dog.Groomed == false
                select dog;

            foreach (Dog dog in done)
                Done.Add(new DogViewModel(dog.Name));
        }
    }
}

