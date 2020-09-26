using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Blazor.SkriftDemo.WASM.Model;

namespace Blazor.SkriftDemo.WASM.Services
{
    public class GetWhereAmIService : IGetWhereAmIService
    {
        private readonly HttpClient _httpClient;

        public GetWhereAmIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WhereAmIResponseModel> GetWhereAmI(string latitude, string longitude)
        {
            var requestUrl = string.Format($"https://api.onwater.io/api/v1/results/{latitude},{longitude}?access_token=ukb6edPsm6gY6TpajZ7j");
            
            return await JsonSerializer.DeserializeAsync<WhereAmIResponseModel>(await _httpClient.GetStreamAsync(requestUrl));
        }
    }
    
}
