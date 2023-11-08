using OpenSteelSeries.Sonar.Sdk.Models.AudioSettings;
using OpenSteelSeries.Sonar.Sdk.Models.Volumes;
using System.Threading.Tasks;

namespace OpenSteelSeries.Sonar.Sdk.Interfaces
{
    public interface ISonarClassicVolumeSettingsService : ISonarClient
    {
        Task<VolumeInfo> GetVolumeSettingsAsync();
        Task<VolumeInfo> SetMasterVolumeAsync(float volume);
        Task<VolumeInfo> SetMasterMuteAsync(bool mute);
        Task<VolumeInfo> SetDeviceRoleVolumeAsync(DeviceRole role, float volume);
        Task<VolumeInfo> SetDeviceRoleMuteAsync(DeviceRole role, bool mute);
    }
}
