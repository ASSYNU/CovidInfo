using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp;
using RestSharp.Authenticators;


namespace CovidInfo.Core
{
    internal class requests
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<String> RequestCoronaInfo(string country)
        {
            var restClient = new RestClient("https://corona.lmao.ninja/v2/countries/"+country+"?sort");
            restClient.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = restClient.Execute(request);
            return response.Content;
        }
    }
}
