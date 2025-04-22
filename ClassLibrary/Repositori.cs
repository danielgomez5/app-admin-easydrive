using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Repositori
    {
        static HttpClient httpClient;

        static readonly string ErrorMessage = "Error en l'API.";
        static readonly string contentType = "application/json";

        public static void CreateHttpClient()
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:7126/api/")
            };
            httpClient.DefaultRequestHeaders.Add("Accept", contentType);
        }

        public static void ClearHttpClient()
        {
            if (httpClient != null)
            {
                httpClient.Dispose();
                httpClient = null;
            }
        }

        public static async Task<object> MakeRequest(string url, string method, object JSONcontent, Type responseType)
        {
            HttpResponseMessage response;

            if (method == "DELETE")
            {
                response = httpClient.DeleteAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    return null;
                }
                else
                {
                    throw new Exception(ErrorMessage);
                }
            }
            else if (method == "GET")
            {
                response = httpClient.GetAsync(url).Result;
            }
            else if (method == "POST" || method == "PUT")
            {
                var objectJson = JsonConvert.SerializeObject(JSONcontent);
                var content = new StringContent(objectJson, Encoding.UTF8, contentType);


                if (method == "POST")
                {
                    response = httpClient.PostAsync(url, content).Result;
                }
                else
                {
                    response = httpClient.PutAsync(url, content).Result;
                }
            }
            else
            {
                return null;
            }

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject(json, responseType);
                return result;
            }
            else
            {
                throw new Exception(ErrorMessage);
            }
        }
    }
}