using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace OpenSteelSeries.Sonar.Sdk.Models.StreamRedirection
{
    [JsonConverter(typeof(StringEnumConverter), new object[] { typeof(CamelCaseNamingStrategy) })]
    public enum StreamRedirectionId
    {
        Streaming,
        Monitoring,
        Mic
    }
}
