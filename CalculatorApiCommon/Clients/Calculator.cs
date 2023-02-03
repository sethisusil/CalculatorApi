using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApiCommon.Clients
{
    public class Calculator : ICalculator
    {
        HttpClient _httpClient;
        public Calculator(HttpClient httpClient)
        {
            this._httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7062/api/", UriKind.Absolute);
            _httpClient.DefaultRequestHeaders.Add("Authorization", "testAuthorization");

        }

        public async Task<string> Calculate(string expr)
        {
            string result = string.Empty;
            var apiResponse = await _httpClient.GetAsync("Calculator/"+expr);
            if(apiResponse?.IsSuccessStatusCode??false)
            {
                result = await apiResponse.Content.ReadAsStringAsync();
            }
            return result;
        }
    }
}
