using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileApp.ViewModels;
using ShelterHack.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContractsPage : ContentPage
    {
        private ContractsPageViewModel _viewModel;
        public ContractsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ContractsPageViewModel();

        }


        private async void ContractsPage_OnAppearing(object sender, EventArgs e)
        {
            await _viewModel.LoadContracts();
        }

        private async void OnContractSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ContractPage(e.SelectedItem as Contract));
        }

        private void AddNew(object sender, EventArgs e)
        {
        }
    }
}