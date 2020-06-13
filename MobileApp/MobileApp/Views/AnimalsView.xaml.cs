using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileApp.ViewModels;
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

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            
        }

        private async void AnimalsView_OnAppearing(object sender, EventArgs e)
        {
            await _viewModel.LoadAnimals();
        }
    }
}