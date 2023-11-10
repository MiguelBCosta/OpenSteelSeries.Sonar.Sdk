using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OpenSteelSeries.Sonar.Sdk.Models.AudioSettings;
using System.Collections.Generic;

namespace OpenSteelSeries.Sonar.Sdk.Models.Volumes
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class VolumeInfo
    {
        public RedirectionVolumes Masters { get; set; } = new RedirectionVolumes();
        public Dictionary<DeviceRole, RedirectionVolumes> Devices { get; } = new Dictionary<DeviceRole, RedirectionVolumes>();
    }
}
