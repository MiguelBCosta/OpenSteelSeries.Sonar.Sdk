using Newtonsoft.Json;
using OpenSteelSeries.Sonar.Sdk.Interfaces;
using OpenSteelSeries.Sonar.Sdk.Models.AudioSettings;
using OpenSteelSeries.Sonar.Sdk.Models.StreamRedirection;
using OpenSteelSeries.Sonar.Sdk.Models.Volumes;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenSteelSeries.Sonar.Sdk.Implementation
{
    public class SonarStreamerVolumeSettingsService : SonarClient, ISonarStreamerVolumeSettingsService
    {
        internal const string CONTROLLER_PREFIX = "volumeSettings/streamer";
        public SonarStreamerVolumeSettingsService(HttpClient httpClient) : base(httpClient)
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

        public async Task<VolumeInfo> SetMasterVolumeAsync(StreamRedirectionId id, float volume)
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _httpClient.PutAsync($"{CONTROLLER_PREFIX}/{id}/master/volume/{volume}", emptyContent);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            VolumeInfo result = JsonConvert.DeserializeObject<VolumeInfo>(jsonContent);
            return result;
        }

        public async Task<VolumeInfo> SetMasterMuteAsync(StreamRedirectionId id, bool mute)
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _httpClient.PutAsync($"{CONTROLLER_PREFIX}/{id}/master/isMuted/{mute}", emptyContent);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            VolumeInfo result = JsonConvert.DeserializeObject<VolumeInfo>(jsonContent);
            return result;
        }

        public async Task<VolumeInfo> SetDeviceRoleVolumeAsync(StreamRedirectionId id, DeviceRole role, float volume)
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _httpClient.PutAsync($"{CONTROLLER_PREFIX}/{id}/{role}/volume/{volume}", emptyContent);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            VolumeInfo result = JsonConvert.DeserializeObject<VolumeInfo>(jsonContent);
            return result;
        }

        public async Task<VolumeInfo> SetDeviceRoleVolumeAsync(StreamRedirectionId id, DeviceRole role, bool mute)
        {
            HttpContent emptyContent = new StringContent(string.Empty);
            HttpResponseMessage response = await _httpClient.PutAsync($"{CONTROLLER_PREFIX}/{id}/{role}/isMuted/{mute}", emptyContent);
            response.EnsureSuccessStatusCode();
            string jsonContent = await response.Content.ReadAsStringAsync();
            VolumeInfo result = JsonConvert.DeserializeObject<VolumeInfo>(jsonContent);
            return result;
        }
    }
}
