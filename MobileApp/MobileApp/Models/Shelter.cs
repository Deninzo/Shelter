using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShelterHack.Models
{
    public class Shelter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IEnumerable<ShelterEmployee> Employees { get; set; }
        public IEnumerable<Animal> ContainingAnimals { get; set; }
        public IEnumerable<Contract> PreformingContracts { get; set; }
    }
}
