using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShelterHack.Models
{
    public class ShelterEmployee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public AuthData AuthData { get; set; }
        public IEnumerable<Animal> HealAnimals { get; set; }
        public Shelter Shelter { get; set; }
    }
}
