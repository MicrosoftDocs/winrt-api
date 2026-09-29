---
-api-id: N:Windows.Management.Update
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Windows.Management.Update 
-->

# Windows.Management.Update

## -description
The Windows.Management.Update namespace provides APIs for managing Windows Update operations across Windows devices. It serves several distinct purposes:

* **General update management:** Use classes such as [WindowsUpdateManager](./windowsupdatemanager.md), [WindowsUpdateAdministrator](./windowsupdateadministrator.md), and [WindowsUpdate](./windowsupdate.md) to discover, download, install, and monitor updates on Windows desktop, Server, and IoT devices - covering both Preview and non-Preview builds.
* **Windows Software Update provider platform:** Use [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md), [WindowsSoftwareUpdate](./windowssoftwareupdate.md), [WindowsSoftwareUpdateProviderStatus](./windowssoftwareupdateproviderstatus.md), and the software-update members of [WindowsUpdateManager](./windowsupdatemanager.md) to author and host update providers for your app that integrate with the Windows Update Orchestrator. A provider discovers updates for specific software during a *scan*, then performs *actions* (download, install, deploy, restart) when the orchestrator schedules them — reusing the same scheduling, reboot coordination, and policies as Windows Update.
* **IoT Insider Preview enablement:** Use [PreviewBuildsManager](./previewbuildsmanager.md) and [PreviewBuildsState](./previewbuildsstate.md) to opt IoT devices into Windows Insider Preview builds and retrieve registration state. It's expected that the OEM of the device will create a settings page within the [Windows Device Portal](https://learn.microsoft.com/windows/iot-core/manage-your-device/deviceportal) for device configuration properties.

These API groups coexist in the same namespace but target different scenarios. Choose the correct set based on your device type and update requirements.

## -choosing the right API
Use this guide to select the correct classes:

* **Discover and install updates on desktop/Server/IoT** → [WindowsUpdateManager](./windowsupdatemanager.md) + [WindowsUpdate](./windowsupdate.md)
* **Apply administrative visibility or policy** → [WindowsUpdateAdministrator](./windowsupdateadministrator.md)
* **Monitor update progress without polling** → Subscribe to [WindowsUpdateManager](./windowsupdatemanager.md) events
* **Author a software-update provider for your app** → [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md) + [WindowsSoftwareUpdateProviderStatus](./windowssoftwareupdateproviderstatus.md) + [WindowsSoftwareUpdate](./windowssoftwareupdate.md)
* **Scan for and act on results from software-update providers** → [WindowsUpdateManager.PerformScan](./windowsupdatemanager_performscan_158684574.md) + [GetApplicableSoftwareUpdates](./windowsupdatemanager_getapplicablesoftwareupdates_1879155305.md)
* **Enable Insider Preview on an IoT device** → [PreviewBuildsManager](./previewbuildsmanager.md) + [PreviewBuildsState](./previewbuildsstate.md)

## -examples

### Scan for and enumerate applicable updates

This C# example creates a [WindowsUpdateManager](./windowsupdatemanager.md), starts a scan, and enumerates the applicable updates when the scan completes.

```csharp
using System;
using Windows.Management.Update;

var updateManager = new WindowsUpdateManager("MyClientId");

updateManager.ScanCompleted += (manager, args) =>
{
    foreach (WindowsUpdate update in manager.GetApplicableUpdates())
    {
        Console.WriteLine($"Applicable update: {update.Title}");
    }
};

// Scan as if the user selected "Check for updates".
updateManager.StartScan(userInitiated: true);
```

### Author a software-update provider

The Windows Software Update provider platform lets you plug a custom update source into the Windows Update Orchestrator. A provider is invoked in SYSTEM context once per operation: during a *scan* it builds [WindowsSoftwareUpdate](./windowssoftwareupdate.md) objects and submits them; during an *action* it reports progress and a final result through a [WindowsSoftwareUpdateProviderStatus](./windowssoftwareupdateproviderstatus.md).

The following snippets show that core flow in C#, C++/WinRT, and PowerShell. Complete, buildable provider samples — including the `provider.json` manifest, code-signing, and registration steps — are published in the [microsoft/windows-uop](https://github.com/microsoft/windows-uop) repository.

#### C#

```csharp
using System.Collections.Generic;
using Windows.Management.Update;

// Scan: report the updates this provider offers.
void PerformScan(string providerId, IEnumerable<WindowsSoftwareUpdate> updates)
{
    var status = new WindowsSoftwareUpdateProviderStatus(providerId);
    WindowsSoftwareUpdateResult result = status.SetScanResult(true, 0, 0, updates);
}

// Action: report progress, then the final result.
void PerformAction(string providerId)
{
    var status = new WindowsSoftwareUpdateProviderStatus(providerId);

    for (ulong i = 0; i <= 100; i += 10)
    {
        status.SetActionProgress(i, 100);
    }

    var actionResult = new WindowsSoftwareUpdateProviderActionResult(
        WindowsSoftwareUpdateActionResult.Succeeded,
        WindowsSoftwareUpdateRestartReason.None,
        resultCode: 0,
        extendedError: 0);
    status.SetActionResult(actionResult);
}
```

#### C++/WinRT

```cppwinrt
#include <winrt/Windows.Management.Update.h>
#include <winrt/Windows.Foundation.Collections.h>

using namespace winrt::Windows::Management::Update;
using namespace winrt::Windows::Foundation::Collections;

// Scan: report the updates this provider offers.
void PerformScan(winrt::hstring const& providerId, IVector<WindowsSoftwareUpdate> const& updates)
{
    WindowsSoftwareUpdateProviderStatus status{ providerId };
    auto result = status.SetScanResult(true, S_OK, 0, updates);
}

// Action: report progress, then the final result.
void PerformAction(winrt::hstring const& providerId)
{
    WindowsSoftwareUpdateProviderStatus status{ providerId };

    for (uint64_t i = 0; i <= 100; i += 10)
    {
        status.SetActionProgress(i, 100);
    }

    WindowsSoftwareUpdateProviderActionResult actionResult{
        WindowsSoftwareUpdateActionResult::Succeeded,
        WindowsSoftwareUpdateRestartReason::None,
        0,   // resultCode
        0 }; // extendedError
    status.SetActionResult(actionResult);
}
```

#### PowerShell

```powershell
# Scan: report the updates this provider offers.
$providerStatus = [Windows.Management.Update.WindowsSoftwareUpdateProviderStatus]::new($ProviderId)
$statusResult   = $providerStatus.SetScanResult($true, 0, 0, $UpdateCollection)

# Action: report progress, then the final result.
$providerStatus = [Windows.Management.Update.WindowsSoftwareUpdateProviderStatus]::new($ProviderId)
for ($i = 0; $i -le 100; $i += 10) {
    [void]$providerStatus.SetActionProgress($i, 100)
}

$actionResult = [Windows.Management.Update.WindowsSoftwareUpdateProviderActionResult]::new(
    [Windows.Management.Update.WindowsSoftwareUpdateActionResult]::Succeeded,
    [Windows.Management.Update.WindowsSoftwareUpdateRestartReason]::None,
    0,   # resultCode
    0)   # extendedError
[void]$providerStatus.SetActionResult($actionResult)
```

### Determine Insider Preview build status (IoT)

This C# example demonstrates how a user can determine whether their device is receiving preview builds, or whether there are problems preventing the device from getting preview builds.

```csharp
public string GetErrorMessage() 
{ 
    PreviewBuildsManager manager = PreviewBuildsManager.GetDefault(); 
    if (manager != null) 
    { 
        PreviewBuildsState state = manager.GetCurrentState(); 
        if (state.Properties.ContainsKey("ErrorMessage")) 
        { 
            return state.Properties["ErrorMessage"].ToString(); 
        } 
    } 
    return String.Empty; 
} 
```
## -remarks

* Use [WindowsUpdateManager](./windowsupdatemanager.md), [WindowsUpdate](./windowsupdate.md), and [WindowsUpdateAdministrator](./windowsupdateadministrator.md) for general update management on all supported platforms.
* Use [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md), [WindowsSoftwareUpdateProviderStatus](./windowssoftwareupdateproviderstatus.md), [WindowsSoftwareUpdate](./windowssoftwareupdate.md), and the software-update members of [WindowsUpdateManager](./windowsupdatemanager.md) to author and host update providers for your app (the Windows Update Orchestration Platform). For provider authoring, onboarding, signing, and registration guidance — along with complete C#, C++, and PowerShell samples — see the [microsoft/windows-uop](https://github.com/microsoft/windows-uop) repository.
* [PreviewBuildsManager](./previewbuildsmanager.md) and [PreviewBuildsState](./previewbuildsstate.md) are **IoT specific** and do not manage general updates on desktop or Server. It's expected that the OEM of the device will create a settings page within the [Windows Device Portal](/windows/iot-core/manage-your-device/deviceportal) for device configuration properties. Information from [PreviewBuildsState](./previewbuildsstate.md) will be read by the device, then displayed to the user, and then used to register the user's account to the device. After registration, all settings management will be done online through the Windows Insider Program instead of on the device itself.
* Platform availability and API contracts are documented in individual class reference pages.

| API Set      | Supported Windows Build    |
| --------------------------- | :-------------: |
| Preview Builds | 17134 or greater |
| Windows Update Manager | 22621 or greater |
| Windows Update Administrator | 22621 or greater |
| Windows Software Update | 26100 or greater |

## -see-also

[WindowsUpdateManager](./windowsupdatemanager.md), [WindowsUpdate](./windowsupdate.md), [WindowsUpdateAdministrator](./windowsupdateadministrator.md), [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md), [WindowsSoftwareUpdate](./windowssoftwareupdate.md), [WindowsSoftwareUpdateProviderStatus](./windowssoftwareupdateproviderstatus.md), [PreviewBuildsManager](./previewbuildsmanager.md), [microsoft/windows-uop samples](https://github.com/microsoft/windows-uop)
