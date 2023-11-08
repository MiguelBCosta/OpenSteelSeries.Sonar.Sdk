using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace OpenSteelSeries.Sonar.Sdk.Models.Configs
{
    [JsonConverter(typeof(StringEnumConverter), new object[] { typeof(CamelCaseNamingStrategy) })]
    public enum VirtualAudioDevice
    {
        Game = 1,
        ChatRender,
        ChatCapture,
        Media,
        Aux
    }

}
