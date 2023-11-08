using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using OpenSteelSeries.Sonar.Sdk.Models.StreamRedirection;
using System.Collections.Generic;

namespace OpenSteelSeries.Sonar.Sdk.Models.Volumes
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class RedirectionVolumes
    {
        public Dictionary<StreamRedirectionId, VolumeSettings> Stream { get; } = new Dictionary<StreamRedirectionId, VolumeSettings>();
        public VolumeSettings Classic { get; set; } = new VolumeSettings();
    }
}
