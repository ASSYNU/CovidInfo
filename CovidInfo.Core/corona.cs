using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CovidInfo.Core
{
    public class Corona
    {
        // Api Domain   =>  https://disease.sh/v3/covid-19/countries/
        // Docs         =>  https://documenter.getpostman.com/view/11144369/Szf6Z9B3?version=latest

        public CovidSpecificInfo? getCoronaInfo(string  Country = "")
        {
            requests requests = new requests();
            string received = requests.RequestCoronaInfo(Country).Result;
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            CovidSpecificInfo covidSpecificInfo = JsonSerializer.Deserialize<CovidSpecificInfo>(received);
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            return covidSpecificInfo;
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}