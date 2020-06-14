using System;
using System.Collections.Generic;
using System.Text;
using ShelterHack.Models;

namespace MobileApp.ViewModels
{
    public class ContractViewModel
    {
        public Contract Contract { get; set; }
        public bool IsShelter { get; set; }
        public bool IsAdmin { get; set; }
        public ContractViewModel(Contract contract)
        {
            Contract = contract;
            IsShelter = !App.IsAdmin;
            IsAdmin = App.IsAdmin;
        }
    }
}
