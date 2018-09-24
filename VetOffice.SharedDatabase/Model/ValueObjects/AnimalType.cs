﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetOffice.SharedDatabase.Model.ValueObjects
{
    public class AnimalType
    {
        public string Species { get; private set; }
        public string Breed { get; private set; }

        public AnimalType(string species, string breed)
        {
            this.Species = species;
            this.Breed = breed;
        }

        // needed for EF?
        internal AnimalType() { }

    }
}
