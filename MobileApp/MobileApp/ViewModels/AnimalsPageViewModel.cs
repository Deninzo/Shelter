using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MobileApp.Services;
using ShelterHack.Models;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class AnimalsPageViewModel : BaseViewModel
    {
        private readonly HttpService _httpService;
        public ObservableCollection<Animal> Animals { get; set; }

        public AnimalsPageViewModel()
        {
            _httpService = DependencyService.Get<HttpService>();
            Animals = new ObservableCollection<Animal>();
        }

        public async Task LoadAnimals()
        {
            var result = await _httpService.GetAnimals();

            foreach (var animal in result)
            {
                Animals.Add(animal);
            }
        }
    }
}
