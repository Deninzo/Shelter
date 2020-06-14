using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MobileApp.Services;
using ShelterHack.Models;
using Xamarin.Forms;

namespace MobileApp.ViewModels
{
    public class AuthorizationViewModel : BaseViewModel
    {
        public AuthorizationViewModel()
        {
            _httpService = DependencyService.Get<HttpService>();
        }

        private readonly HttpService _httpService;

        private string _login;
        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public async Task<AuthData> DoLogin()
        {
            if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password)) return null;

            return await _httpService.Authorization(Login, Password);
        }
    }
}
