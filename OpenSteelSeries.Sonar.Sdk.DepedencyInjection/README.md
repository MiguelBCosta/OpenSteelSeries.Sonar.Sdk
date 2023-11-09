
# OpenSteelSeries.Sonar.SDK.DependencyInjection

**OpenSteelSeries.Sonar.SDK.DependencyInjection** is a library that simplifies the integration of the OpenSteelSeries.Sonar.SDK with the Microsoft Dependency Injection framework. This library streamlines the process of configuring and injecting the necessary services for seamless communication with the SteelSeries Sonar REST API.

## Installation

You can install the `OpenSteelSeries.Sonar.SDK.DependencyInjection` library using either the NuGet Package Manager in Visual Studio or the .NET CLI.

### NuGet Package Manager

1. Open the NuGet Package Manager in Visual Studio.
2. Search for "OpenSteelSeries.Sonar.SDK.DependencyInjection."
3. Select the package and click "Install."

### .NET CLI

Use the following command to install the package via .NET CLI:

```bash
dotnet add package OpenSteelSeries.Sonar.SDK.DependencyInjection
```
## Getting Started

1. Ensure that you have already installed the `OpenSteelSeries.Sonar.SDK` library.

2. In your startup code, you can configure the services by using the `AddOpenSteelSeriesSonaServices` method. This method should be called within the `IServiceCollection` provided by the Microsoft Dependency Injection framework.

   ```csharp
   using OpenSteelSeries.Sonar.Sdk
   using OpenSteelSeries.Sonar.Sdk.DependencyInjection;

   public void ConfigureServices(IServiceCollection services)
   {
       services.AddOpenSteelSeriesSonaServices();
   }
   ```

The `AddOpenSteelSeriesSonaServices` method will set up and register the necessary HttpClient instances and policies for interaction with the SteelSeries Sonar API, allowing you to inject these services into your application's components as needed.

Now, you can easily inject these services into your controllers, services, or other application components to facilitate communication with the SteelSeries Sonar API.

For specific usage details and examples of working with SteelSeries Sonar features, please refer to the [OpenSteelSeries.Sonar.SDK documentation](../OpenSteelSeries.Sonar.SDK/README.md).