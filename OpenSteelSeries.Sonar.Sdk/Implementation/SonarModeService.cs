using Newtonsoft.Json;
using OpenSteelSeries.Sonar.Sdk.Interfaces;
using OpenSteelSeries.Sonar.Sdk.Models.Modes;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenSteelSeries.Sonar.Sdk.Implementation
{
    public class SonarModeService : SonarClient, ISonarModeService
    {
        internal const string CONTROLLER_PREFIX = "mode";
        public SonarModeService(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<ModeId> GetModeAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{CONTROLLER_PREFIX}");
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            ModeId result = JsonConvert.DeserializeObject<ModeId>(jsonContent);
            return result;
        }

        public async Task<ModeId> UpdateModeAsync(ModeId modeId)
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _httpClient.PutAsync($"{CONTROLLER_PREFIX}/{modeId}", emptyContent);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            ModeId result = JsonConvert.DeserializeObject<ModeId>(jsonContent);
            return result;
        }
    }
}
