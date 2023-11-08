using Microsoft.Diagnostics.Runtime;
using System.Diagnostics;
using System.Linq;

namespace OpenSteelSeries.Sonar.Sdk.Utilities
{
    public static class SonarProcessUtility
    {
        public static string PROCESS_NAME = "SteelSeriesSonar";
        public static string FindSonarApiUrl()
        {
            string address;
            Process process = Process.GetProcesses().FirstOrDefault(p => p.ProcessName == PROCESS_NAME);
            using (DataTarget dataTarget = DataTarget.AttachToProcess(process.Id, suspend: false))
            {
                var clrVersion = dataTarget.ClrVersions.FirstOrDefault();
                var runtime = clrVersion.CreateRuntime();
                ClrHeap heap = runtime.Heap;
                var clrObjects = heap.EnumerateObjects();
                var webServer = clrObjects.FirstOrDefault(t => t.Type.Name.EndsWith("WebServer"));
                var WebServerAddressField = webServer.Type.Fields.FirstOrDefault(field => field.Name.Contains("WebServerAddress"));
                webServer.TryReadStringField(WebServerAddressField.Name, null, out address);
            }
            return address;
        }
    }
}
