using apiTestProject.Brewery.Response;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace apiTestProject.Brewery
{
    public class BreweryAPI
    {
        private readonly HttpClient restClient = new HttpClient();
        private readonly string URI = "https://api.openbrewerydb.org/v1/breweries/";
        private readonly string Brevery = "b54b16e1-ac3b-4bff-a11f-f7ae9ddc27e0";


        public async Task<GetBreweryResponse> Get_Brewery(string brewery)
        {
            UriBuilder builder = new UriBuilder($"{URI}{brewery}");
            var response = await restClient.GetAsync(builder.Uri);
            var context = await response.Content.ReadAsStringAsync();

            try
            {
                var responseModel = JsonConvert.DeserializeObject<GetBreweryResponse>(context);
                return responseModel;
            }
            catch
            {
                return null;
            }
        }
    }
}
