using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FuelPrice.Api.Models
{
    public class ApiResponse
    {
        public bool Ok { get; set; }
        public string License { get; set; }
        public string Data { get; set; }
        public string Status { get;set; }

        public List<PetrolStation> Stations { get; set; }

    }
}