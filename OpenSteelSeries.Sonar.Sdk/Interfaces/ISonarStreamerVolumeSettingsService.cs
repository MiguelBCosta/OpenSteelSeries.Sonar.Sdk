using OpenSteelSeries.Sonar.Sdk.Models.AudioSettings;
using OpenSteelSeries.Sonar.Sdk.Models.StreamRedirection;
using OpenSteelSeries.Sonar.Sdk.Models.Volumes;
using System.Threading.Tasks;

namespace OpenSteelSeries.Sonar.Sdk.Interfaces
{
    public interface ISonarStreamerVolumeSettingsService : ISonarClient
    {
        Task<VolumeInfo> GetVolumeSettingsAsync();
        Task<VolumeInfo> SetDeviceRoleVolumeAsync(StreamRedirectionId id, DeviceRole role, bool mute);
        Task<VolumeInfo> SetDeviceRoleVolumeAsync(StreamRedirectionId id, DeviceRole role, float volume);
        Task<VolumeInfo> SetMasterMuteAsync(StreamRedirectionId id, bool mute);
        Task<VolumeInfo> SetMasterVolumeAsync(StreamRedirectionId id, float volume);
    }
}