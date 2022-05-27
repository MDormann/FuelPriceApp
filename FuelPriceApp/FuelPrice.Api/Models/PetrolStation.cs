﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FuelPrice.Api.Models
{
    public class PetrolStation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Street { get; set; }
        public string Place { get; set; }
        public string HouseNumber { get; set; }
        public int PostCode { get; set; }

        public double Lat { get; set; }
        public double Lng { get; set; }
        public double Dist { get; set; }
        public double Diesel { get; set; }
        public double E5 { get; set; }
        public double E10 { get; set; }
        public bool IsOpen { get; set; }
    }
}