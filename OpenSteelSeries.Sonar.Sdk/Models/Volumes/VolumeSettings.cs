using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace OpenSteelSeries.Sonar.Sdk.Models.Volumes
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class VolumeSettings
    {
        public float Volume { get; set; }
        public bool Muted { get; set; }
    }
}
