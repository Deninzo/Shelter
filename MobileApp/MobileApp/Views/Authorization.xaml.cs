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
            NavigationPage.SetTitleIconImageSource(this, "logo.png");

        }

        private async void InputClick(object sender, EventArgs e)
        {
            var result = await _viewModel.DoLogin();

            if (result != null)
            {
                switch (result.Role.Id)
                {
                    case 1:
                    {
                        await Navigation.PushAsync(new AnimalsView());
                        break;
                    }
                    case 2:
                    {
                        await Navigation.PushAsync(new ContractsPage());
                        App.IsAdmin = false;
                        break;
                    }
                    case 4:
                    {
                        App.IsAdmin = true;
                        await Navigation.PushAsync(new ContractsPage());
                        break;
                    }
                }
            }
            else
            {
                await DisplayAlert("Ошибка входа", "Неверный логин или пароль", "Ok");
            }
        }
    }
}