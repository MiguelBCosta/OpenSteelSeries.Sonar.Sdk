using Newtonsoft.Json;
using OpenSteelSeries.Sonar.Sdk.Interfaces;
using OpenSteelSeries.Sonar.Sdk.Models.Configs;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenSteelSeries.Sonar.Sdk.Implementation
{
    public class SonarConfigsService : SonarClient, ISonarConfigsService
    {
        internal const string CONTROLLER_PREFIX = "configs";
        public SonarConfigsService(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<Config> CreateConfig(Config config)
        {
            string jsonData = JsonConvert.SerializeObject(config);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"{CONTROLLER_PREFIX}", content);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            Config result = JsonConvert.DeserializeObject<Config>(jsonContent);
            return result;
        }

        public async Task DeleteConfig(Guid id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"{CONTROLLER_PREFIX}?id={id}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<List<Config>> GetConfigsAsync(VirtualAudioDevice? vad = null)
        {
            string endPoint = $"{CONTROLLER_PREFIX}";
            if (vad.HasValue)
                endPoint += $"vad={vad}";
            HttpResponseMessage response = await _httpClient.GetAsync(endPoint);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            List<Config> result = JsonConvert.DeserializeObject<List<Config>>(jsonContent);
            return result;
        }

        public async Task<List<Config>> GetSelectedsConfig()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{CONTROLLER_PREFIX}/selected");
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            List<Config> result = JsonConvert.DeserializeObject<List<Config>>(jsonContent);
            return result;
        }

        public async Task SelectConfig(Guid id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{CONTROLLER_PREFIX}/{id}/select");
            response.EnsureSuccessStatusCode();
        }

        public async Task<Config> UpdateConfig(Config config)
        {
            string jsonData = JsonConvert.SerializeObject(config);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync($"{CONTROLLER_PREFIX}", content);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            Config result = JsonConvert.DeserializeObject<Config>(jsonContent);
            return result;
        }
    }
}
