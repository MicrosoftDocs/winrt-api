---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateProvider
-api-type: winrt class
---

# Windows.Management.Update.WindowsSoftwareUpdateProvider

<!--
public sealed class WindowsSoftwareUpdateProvider
-->


## -description

Represents a Windows Software Update provider package on disk and provides the operations to validate, register, and unregister it with the Windows Update Orchestrator.

## -remarks

A provider is a folder that contains a `provider.json` manifest, the scan and action files it references, and a signing catalog. Construct a **WindowsSoftwareUpdateProvider** from that folder, then call [Register](./windowssoftwareupdateprovider_register_1161340127.md) to make it eligible for software-update scans, or [Unregister](./windowssoftwareupdateprovider_unregister_211933048.md) to remove it.

Registration validates the manifest, verifies payload-file hashes, checks the catalog, and verifies code-signing. Registration and unregistration require administrator privileges.

For the manifest format, signing requirements, and end-to-end onboarding steps, see the provider authoring guide in the [windows-uop](https://github.com/microsoft/windows-uop) repository.

## -see-also

[WindowsSoftwareUpdateProviderStatus](./windowssoftwareupdateproviderstatus.md), [WindowsSoftwareUpdateProviderType](./windowssoftwareupdateprovidertype.md), [WindowsSoftwareUpdateProviderRegistrationType](./windowssoftwareupdateproviderregistrationtype.md), [WindowsUpdateManager](./windowsupdatemanager.md)

## -examples

This C# example loads a provider package from a folder and registers it with the Windows Update Orchestrator.

```csharp
using Windows.Management.Update;

var provider = new WindowsSoftwareUpdateProvider(@"C:\MyProvider");

// Optionally validate the package before registering it.
WindowsSoftwareUpdateResult validation = provider.Validate();
if (validation.Succeeded)
{
    WindowsSoftwareUpdateResult result = provider.Register();
    System.Console.WriteLine($"Register -> Succeeded: {result.Succeeded}, ResultCode: {result.ResultCode}");
}
```

Registration and unregistration require administrator privileges and signed, trusted provider content.
The [windows-uop](https://github.com/microsoft/windows-uop) repository provides PowerShell helpers (`Register-WindowsSoftwareUpdateProvider`, `Test-WindowsSoftwareUpdateProvider`) and a full authoring, signing, and onboarding guide.
