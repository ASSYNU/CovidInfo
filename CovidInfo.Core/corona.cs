﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CovidInfo.Core
{
    public class corona
    {
        // Api Domain   =>  https://corona.lmao.ninja/v2/countries/Poland
        // Docs         =>  https://documenter.getpostman.com/view/11144369/Szf6Z9B3?version=latest

        public CovidSpecificInfo getCoronaInfo(string Country)
        {
            requests requests = new requests();
            string recived = requests.requestCoronaInfo(Country).Result;
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            CovidSpecificInfo CovidSpecificInfo = JsonSerializer.Deserialize<CovidSpecificInfo>(recived);
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            return CovidSpecificInfo;
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}