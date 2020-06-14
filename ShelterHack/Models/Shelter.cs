using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShelterHack.Models
{
    public class Shelter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [JsonIgnore]
        public IEnumerable<ShelterEmployee> Employees { get; set; }
        [JsonIgnore]
        public IEnumerable<Animal> ContainingAnimals { get; set; }
        [JsonIgnore]
        public IEnumerable<Contract> PreformingContracts { get; set; }
    }
}
