﻿using Newtonsoft.Json;

namespace ConsultaCNPJ.Infraestrutura
{
    public class HelperAPI
    {
        private string _EndPoint;

        public HelperAPI(string EndPoint)
        {
            _EndPoint = EndPoint;
        }

        public async Task<T> MetodoGET<T>(string Route)
        {
            HttpClient httpClient = new();
            var URI = $"{_EndPoint}/{Route}";

            var response = await httpClient.GetAsync(URI);

            string responseContent = await response.Content.ReadAsStringAsync();

            var retorno = JsonConvert.DeserializeObject<T>(responseContent);

            return retorno;
        }
    }
}
