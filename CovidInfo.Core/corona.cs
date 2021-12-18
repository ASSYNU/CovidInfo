using System.Text.Json;
using CovidInfo.Api;

namespace CovidInfo.Core
{
    public class Corona
    {
        // Api Domain   =>  https://disease.sh/v3/covid-19/countries/
        // Docs         =>  https://documenter.getpostman.com/view/11144369/Szf6Z9B3?version=latest

        public CovidSpecificInfo? getCoronaInfo(string  country)
        {
            RequestAPI requests = new RequestAPI();
            string received = requests.RequestCoronaInfo(country).Result;
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            CovidSpecificInfo covidSpecificInfo = JsonSerializer.Deserialize<CovidSpecificInfo>(received);
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            return covidSpecificInfo;
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}