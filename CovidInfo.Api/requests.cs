using System;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;

namespace CovidInfo.Api
{
    public class RequestAPI
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<String> RequestCoronaInfo(string country)
        {
            var restClient = new RestClient("https://disease.sh/v3/covid-19/countries/"+country+"?sort");
            restClient.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = restClient.Execute(request);
            return response.Content;
        }
    }   
}