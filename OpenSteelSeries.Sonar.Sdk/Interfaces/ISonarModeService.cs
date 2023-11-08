using OpenSteelSeries.Sonar.Sdk.Models.Modes;
using System.Threading.Tasks;

namespace OpenSteelSeries.Sonar.Sdk.Interfaces
{
    public interface ISonarModeService : ISonarClient
    {
        Task<ModeId> GetModeAsync();
        Task<ModeId> UpdateModeAsync(ModeId modeId);
    }
}
