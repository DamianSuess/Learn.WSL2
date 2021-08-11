# WSL2 Debugging with Visual Studio

Is now included in Visual Studio 2019

Previously, you had to download the extension which was in "preview" only. The link is provided as a reference to the documentation.

* [Old Tool](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.Dot-Net-Core-Debugging-With-Wsl2)

## Prerequisites

First things first, you must be running at least VS 2019 (latest update) and enable WSL 2 on your Windows 10 box.

* [Visual Studio 2019 v16.6](https://aka.ms/vs)
* [.NET Core Tools](https://get.dot.net)
* [WSL 2](https://aka.ms/wsl)

## Install Linux Distro

Next, be sure to install a Linux distro from the Microsoft store.

1. [WSL 2 distribution](https://aka.ms/wslstore)
   * Download your favorite distro.
   * I've only tested with **Ubuntu 20.04 LTS** (~450 MB).
2. After downloading, launch the distro
3. Configure your Username and Password.

## Prerequisites for Distros

1. Install .NET on your WSL distro via,[.NET Core runtime](https://aka.ms/WslDotNet)
1. [Curl](https://curl.haxx.se/)

## Configure WSL 2

### Sample Profile
```json
"WSL 2": {
  "commandName": "WSL2",
  "launchBrowser": true,
  "launchUrl": "https://localhost:5001",
  "environmentVariables": {
    "ASPNETCORE_URLS": "https://localhost:5001;http://localhost:5000",
    "ASPNETCORE_ENVIRONMENT": "Development"
  },
  "distributionName": ""
}
```

### Supported Launch Profiles
| Setting | Use | Default |
|---------|-----|---------|
| commandName | Must be WSL2 | WSL2
| distributionName | Name of the distribution to run in, or "" to use the default distribution. | ""
| executablePath | Path to run | dotnet
| commandLineArgs | Arguments to pass to executablePath | The projects output assembly.
| workingDirectory | The directory in which to start executablePath | For ASP.NET Core web apps, the project folder; for .NET Core console Apps, the output folder.
| environmentVariables | List of environment variables to set for executablePath. | null
| launchBrowser | Whether or not to launch a browser. | false
| launchUrl | Url to use for launching a browser. | null
