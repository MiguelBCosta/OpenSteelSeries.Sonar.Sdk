using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenSteelSeries.Sonar.Sdk.Models.Configs
{
    public class Config
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("virtualAudioDevice")]
        public VirtualAudioDevice VirtualAudioDevice { get; set; }
        [JsonProperty("data")]
        public dynamic Data { get; set; }
        [JsonProperty("schemaVersion")]
        public int SchemaVersion { get; set; }
        [JsonProperty("isSelected")]
        public bool IsSelected { get; set; }
        [JsonProperty("applications")]
        public IEnumerable<Application> Applications { get; set; } = new List<Application>();
    }
}
