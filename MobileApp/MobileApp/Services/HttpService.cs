using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ShelterHack.Models;
using Xamarin.Forms;

namespace MobileApp.Services
{
    public class HttpService
    {
        HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("http://192.168.0.102:41062/api/")
        };


        public async Task<bool> Authorization(string login, string password)
        {
            var result = await _client.GetAsync($"authdatas/auth?login={login}&password={password}");
            return result.IsSuccessStatusCode;
        }

        public async Task<List<Animal>> GetAnimals()
        {
            var result = await _client.GetAsync("animals");
            if (!result.IsSuccessStatusCode)
                return null;

            var stringResult = await result.Content.ReadAsStringAsync();

            var animals = JsonConvert.DeserializeObject<List<Animal>>(stringResult);
            return animals;
        }
    }
}
