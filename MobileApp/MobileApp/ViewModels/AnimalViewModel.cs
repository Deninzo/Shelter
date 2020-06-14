using System;
using System.Collections.Generic;
using System.Text;
using ShelterHack.Models;

namespace MobileApp.ViewModels
{
    public class AnimalViewModel : BaseViewModel
    {
        public Animal Animal { get; set; }

        public string Title => Animal.Name;

        public AnimalViewModel(Animal animal)
        {
            Animal = animal;
        }
    }
}
