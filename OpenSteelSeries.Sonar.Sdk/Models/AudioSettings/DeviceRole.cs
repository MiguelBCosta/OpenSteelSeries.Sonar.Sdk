using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace OpenSteelSeries.Sonar.Sdk.Models.AudioSettings
{
    [JsonConverter(typeof(StringEnumConverter), new object[] { typeof(CamelCaseNamingStrategy) })]
    public enum DeviceRole
    {
        None,
        ChatRender,
        Game,
        ChatCapture,
        Stream,
        Media,
        Aux
    }
}
