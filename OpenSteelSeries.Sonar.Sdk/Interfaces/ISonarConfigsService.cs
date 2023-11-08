using OpenSteelSeries.Sonar.Sdk.Models.Configs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenSteelSeries.Sonar.Sdk.Interfaces
{
    public interface ISonarConfigsService : ISonarClient
    {
        Task<List<Config>> GetConfigsAsync(VirtualAudioDevice? vad = null);
        Task<Config> CreateConfig(Config config);
        Task<Config> UpdateConfig(Config config);
        Task DeleteConfig(Guid id);
        Task<List<Config>> GetSelectedsConfig();
        Task SelectConfig(Guid id);
    }
}
