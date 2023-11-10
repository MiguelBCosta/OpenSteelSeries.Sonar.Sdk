using Newtonsoft.Json;
using OpenSteelSeries.Sonar.Sdk.Interfaces;
using OpenSteelSeries.Sonar.Sdk.Models.AudioSettings;
using OpenSteelSeries.Sonar.Sdk.Models.Volumes;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenSteelSeries.Sonar.Sdk.Implementation
{
    public class SonarClassicVolumeSettingsService : SonarClient, ISonarClassicVolumeSettingsService
    {
        internal const string CONTROLLER_PREFIX = "volumeSettings/classic";
        public SonarClassicVolumeSettingsService(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<VolumeInfo> GetVolumeSettingsAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{CONTROLLER_PREFIX}");
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            VolumeInfo result = JsonConvert.DeserializeObject<VolumeInfo>(jsonContent);
            return result;
        }

        public async Task<VolumeInfo> SetDeviceRoleMuteAsync(DeviceRole role, bool mute)
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _httpClient.PutAsync($"{CONTROLLER_PREFIX}/{role}/Mute/{mute}", emptyContent);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            VolumeInfo result = JsonConvert.DeserializeObject<VolumeInfo>(jsonContent);
            return result;
        }

        public async Task<VolumeInfo> SetDeviceRoleVolumeAsync(DeviceRole role, float volume)
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _httpClient.PutAsync($"{CONTROLLER_PREFIX}/{role}/Volume/{volume:F2}", emptyContent);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            VolumeInfo result = JsonConvert.DeserializeObject<VolumeInfo>(jsonContent);
            return result;
        }

        public async Task<VolumeInfo> SetMasterMuteAsync(bool mute)
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _httpClient.PutAsync($"{CONTROLLER_PREFIX}/Master/Mute/{mute}", emptyContent);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            VolumeInfo result = JsonConvert.DeserializeObject<VolumeInfo>(jsonContent);
            return result;
        }

        public async Task<VolumeInfo> SetMasterVolumeAsync(float volume)
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _httpClient.PutAsync($"{CONTROLLER_PREFIX}/Master/Volume/{volume:F2}", emptyContent);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            VolumeInfo result = JsonConvert.DeserializeObject<VolumeInfo>(jsonContent);
            return result;
        }
    }
}
