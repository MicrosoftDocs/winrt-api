---
-api-id: N:Windows.Management.Update
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Windows.Management.Update 
-->

# Windows.Management.Update

## -description
The Windows.Management.Update namespace provides APIs for managing Windows Update operations across Windows devices. It serves two distinct purposes:

* **General update management:** Use classes such as [WindowsUpdateManager](./windowsupdatemanager.md), [WindowsUpdateAdministrator](./windowsupdateadministrator), and [WindowsUpdate](./windowsupdate.md) to discover, download, install, and monitor updates on Windows desktop, Server, and IoT devices - covering both Preview and non-Preview builds.
* **IoT Insider Preview enablement:** Use [PreviewBuildsManager](./previewbuildsmanager.md) and [PreviewBuildsState](./previewbuildsstate.md) to opt IoT devices into Windows Insider Preview builds and retrieve registration state. It's expected that the OEM of the device will create a settings page within the [Windows Device Portal](https://learn.microsoft.com/windows/iot-core/manage-your-device/deviceportal) for device configuration properties.

These API groups coexist in the same namespace but target different scenarios. Choose the correct set based on your device type and update requirements.

## -choosing the right API
Use this guide to select the correct classes:

* **Discover and install updates on desktop/Server/IoT** → [WindowsUpdateManager](./windowsupdatemanager.md) + [WindowsUpdate](./windowsupdate.md)
* **Apply administrative visibility or policy** → [WindowsUpdateAdministrator](./windowsupdateadministrator)
* **Monitor update progress without polling** → Subscribe to [WindowsUpdateManager](./windowsupdatemanager.md) events
* **Enable Insider Preview on an IoT device** → [PreviewBuildsManager](./previewbuildsmanager.md) + [PreviewBuildsState](./previewbuildsstate.md)

## -examples

This C# example queries for applicable updates and starts installation.

```csharp
var updateManager = WindowsUpdateManager.GetDefault();
var updates = await updateManager.GetApplicableUpdatesAsync();
foreach (var update in updates)
{
    Console.WriteLine($"Found update: {update.Title}");
}
await updateManager.StartInstallAsync(updates);
```

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

* Use [WindowsUpdateManager](./windowsupdatemanager.md), [WindowsUpdate](./windowsupdate.md), and [WindowsUpdateAdministrator](./windowsupdateadministrator) for general update management on all supported platforms.
* [PreviewBuildsManager](./previewbuildsmanager.md) and [PreviewBuildsState](./previewbuildsstate.md) are **IoT specific** and do not manage general updates on desktop or Server. It's expected that the OEM of the device will create a settings page within the [Windows Device Portal](/windows/iot-core/manage-your-device/deviceportal) for device configuration properties. Information from [PreviewBuildsState](./previewbuildsstate.md) will be read by the device, then displayed to the user, and then used to register the user's account to the device. After registration, all settings management will be done online through the Windows Insider Program instead of on the device itself.
* Platform availability and API contracts are documented in individual class reference pages.

| API Set      | Supported Windows Build    |
| --------------------------- | :-------------: |
| Preview Builds | 17134 or greater |
| Windows Update Manager | 22621 or greater |
| Windows Update Administrator | 22621 or greater |
| Windows Software Update | 26100 or greater |

## -see-also

