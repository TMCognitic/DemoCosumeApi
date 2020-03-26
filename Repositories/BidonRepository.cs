using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BidonRepository : IBidonRepository
    {
        static string BaseUri = @"http://localhost:64288/api/";
        HttpClient _httpClient;

        public BidonRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUri);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public IEnumerable<Bidon> Get()
        {
            HttpResponseMessage responseMessage = _httpClient.GetAsync("Bidon").Result;
            responseMessage.EnsureSuccessStatusCode();

            string json = responseMessage.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<Bidon[]>(json);
        }

        public Bidon Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Post(Bidon entity)
        {
            string json = JsonConvert.SerializeObject(entity);

            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            HttpResponseMessage responseMessage = _httpClient.PostAsync("Bidon", httpContent).Result;
            return responseMessage.IsSuccessStatusCode;
        }
    }
}
