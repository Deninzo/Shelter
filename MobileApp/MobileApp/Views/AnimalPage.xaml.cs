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
    public partial class AnimalPage : ContentPage
    {
        public AnimalPage(Animal animal)
        {
            InitializeComponent();
            BindingContext = new AnimalViewModel(animal);
        }
    }
}