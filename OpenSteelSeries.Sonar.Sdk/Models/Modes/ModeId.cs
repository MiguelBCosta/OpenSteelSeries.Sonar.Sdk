using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace OpenSteelSeries.Sonar.Sdk.Models.Modes
{
    [JsonConverter(typeof(StringEnumConverter), new object[] { typeof(CamelCaseNamingStrategy) })]
    public enum ModeId
    {
        Classic,
        Stream
    }
}
