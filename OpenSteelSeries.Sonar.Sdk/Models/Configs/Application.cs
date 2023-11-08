using Newtonsoft.Json;
using System;

namespace OpenSteelSeries.Sonar.Sdk.Models.Configs
{
    public class Application
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("executablePath")]
        public string ExectuablePath { get; set; }
        [JsonProperty("directory")]
        public string Directory { get; set; }
        [JsonProperty("uniqueIdentifier")]
        public string UniqueIdentifier { get; set; }
    }
}
