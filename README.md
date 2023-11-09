# OpenSteelSeries.Sonar.SDK

[![Build Status](https://github.com/MiguelBCosta/OpenSteelSeries.Sonar.Sdk/actions/workflows/publish.yml/badge.svg)](https://github.com/MiguelBCosta/OpenSteelSeries.Sonar.Sdk/actions) \
![Nuget](https://img.shields.io/nuget/v/OpenSteelSeries.Sonar.Sdk?label=OpenSteelSeries.Sonar.Sdk) \
![Nuget](https://img.shields.io/nuget/v/OpenSteelSeries.Sonar.Sdk.DepedencyInjection?label=OpenSteelSeries.Sonar.Sdk.DepedencyInjection)


**Disclaimer:** This project is independently developed and has no affiliation with SteelSeries. The OpenSteelSeries.Sonar.SDK library has been created to provide a communication interface with the SteelSeries Sonar REST API. However, its development is unofficial and not associated with SteelSeries.

**OpenSteelSeries.Sonar.SDK** is an open-source library designed to provide a communication interface with the SteelSeries Sonar REST API. With it, you can:

- [x] Switch between Classic and Streamer operation modes.
- [x] Adjust the volume of each device.
- [x] Mute and unmute your microphone.
- [x] Change the profile of each device.
- [x] Retrieve the status of each of the above functionalities.

**Note:** The use of this library may be affected by updates to SteelSeries Sonar, so it's essential to be aware of this when deciding to implement it in your project.

## RoadMap

**Completed:**
- [x] VolumeSettings Classic
- [x] VolumeSettings Streamer
- [x] Configs
- [x] Mode

**To Do:**
- [ ] Classic Redirections
- [ ] Streamer Redirections
- [ ] Audio Devices
- [ ] Feature Controller
- And other functionalities yet to be mapped

## Documentation

The project is divided into two packages:

1. **OpenSteelSeries.Sonar.SDK**: In this package, the entire communication interface is implemented and can be used individually. For more information, read the [README](OpenSteelSeries.Sonar.Sdk/docs/README.md).

2. **OpenSteelSeries.Sonar.SDK.DependencyInjection**: This package is designed to inject dependencies and facilitate its use. For more information, read the [README](OpenSteelSeries.Sonar.Sdk.DependencyInjection/docs/README.md).

Make sure to explore the documentation for each package to understand how to use them effectively in your project.
