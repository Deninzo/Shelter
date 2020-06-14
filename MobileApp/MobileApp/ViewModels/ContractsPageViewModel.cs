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
    public class ContractsPageViewModel : BaseViewModel
    {
        public ContractsPageViewModel()
        {
            _httpService = DependencyService.Get<HttpService>();
            Contracts = new ObservableCollection<Contract>();
            IsAdmin = App.IsAdmin;
        }

        private readonly HttpService _httpService;

        public ObservableCollection<Contract> Contracts { get; set; }
        public bool IsAdmin = false;

        public async Task LoadContracts()
        {
            var contracts = await _httpService.GetContracts();

            foreach (var contract in contracts)
            {
                Contracts.Add(contract);
            }
        }
    }
}
