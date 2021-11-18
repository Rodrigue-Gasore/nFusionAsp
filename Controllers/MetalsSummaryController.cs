using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using nfusionsolutionsChallengeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace nfusionsolutionsChallengeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetalsSummaryController : ControllerBase

    {
        private readonly IConfiguration _config;

        public MetalsSummaryController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet]
        public IEnumerable<MetalsSummaryResponse> Get(string metal, double bidDelta, double askDelta)
        {
            List<MetalsSummaryResponse> metals = new List<MetalsSummaryResponse>();
            var apiKey = _config.GetValue<string>("ApiKey");
            var queryString = new Dictionary<string, string>()
            {
                { "token", apiKey },
                { "metals", "Gold,Silver,Platinum,Palladium" }
            };
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://api.nfusionsolutions.biz/api/v1/Metals/spot/summary/");
                var requestUri = QueryHelpers.AddQueryString("", queryString);
                var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
                using (var response = httpClient.SendAsync(request))
                {
                    string apiResponse = response.Result.Content.ReadAsStringAsync().Result;
                    metals = JsonConvert.DeserializeObject<List<MetalsSummaryResponse>>(apiResponse);
                }
            }
            if (metal!=null && metal!="")
            {
                metals.Add(new MetalsSummaryResponse
                {
                    data = new MetalsData { symbol = metal, ask = askDelta, bid = bidDelta }
                });
            }
            return metals;
        }
    }
}
