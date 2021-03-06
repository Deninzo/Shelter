﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShelterHack.DTO
{
    public class AnimalDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string TagNumber { get; set; }
        public string Description { get; set; }
        public DateTime ArrivedInShelter { get; set; }
        public string ShelterContainer { get; set; }
        public string Photo { get; set; }
        public string Catcher { get; set; }
        public string Breed { get; set; }
    }
}
