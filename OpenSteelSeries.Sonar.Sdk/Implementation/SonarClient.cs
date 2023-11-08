using OpenSteelSeries.Sonar.Sdk.Interfaces;
using OpenSteelSeries.Sonar.Sdk.Utilities;
using System.Net.Http;

namespace OpenSteelSeries.Sonar.Sdk.Implementation
{
    public class SonarClient : ISonarClient
    {
        internal readonly HttpClient _httpClient;
        public SonarClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            TryGetBaseUrl();
        }

        public virtual void TryGetBaseUrl()
        {
            var baseApiUrl = SonarProcessUtility.FindSonarApiUrl();
            if (baseApiUrl != null)
                _httpClient.BaseAddress = new System.Uri(baseApiUrl);
        }
    }
}
