using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileApp.Services;
using MobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Authorization : ContentPage
    {
        private AuthorizationViewModel _viewModel;
        private readonly HttpService _httpService;
        public Authorization()
        {
            InitializeComponent();

            _httpService = DependencyService.Get<HttpService>();

            BindingContext = _viewModel = new AuthorizationViewModel();
        }

        private async void InputClick(object sender, EventArgs e)
        {
            var result = await _viewModel.DoLogin();

            if (result)
            {
                await Navigation.PushAsync(new NavigationPage(new ItemsPage()));
            }
            else
            {
                await DisplayAlert("Ошибка входа", "Неверный логин или пароль", "Ok");
            }
        }
    }
}