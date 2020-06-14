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
    public partial class AnimalsView : ContentPage
    {
        private AnimalsPageViewModel _viewModel;
        public AnimalsView()
        {
            InitializeComponent();

            BindingContext = _viewModel = new AnimalsPageViewModel();

        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new AnimalPage((e.SelectedItem as Animal)));
        }

        private async void AnimalsView_OnAppearing(object sender, EventArgs e)
        {
            await _viewModel.LoadAnimals();
        }

        async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Authorization(), true);
        }

        private async void MakeReport(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MakeReportPage());
        }
    }
}