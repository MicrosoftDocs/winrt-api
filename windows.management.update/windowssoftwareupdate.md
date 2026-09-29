---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdate
-api-type: winrt class
---

# Windows.Management.Update.WindowsSoftwareUpdate

<!--
public sealed class WindowsSoftwareUpdate
-->


## -description

Represents a single software update that a provider reports to the Windows Update Orchestrator, including its identity, versions, sizes, the actions required to apply it, and its current state.

## -remarks

A provider constructs **WindowsSoftwareUpdate** objects during a scan and submits them through [WindowsSoftwareUpdateProviderStatus.SetScanResult](./windowssoftwareupdateproviderstatus_setscanresult_550695687.md). A host can enumerate applicable updates with [WindowsUpdateManager.GetApplicableSoftwareUpdates](./windowsupdatemanager_getapplicablesoftwareupdates_1879155305.md).

The information an update carries depends on its [InstallationType](./windowssoftwareupdate_installationtype.md): executable and PowerShell updates supply a [WindowsSoftwareUpdateExecutionInfo](./windowssoftwareupdateexecutioninfo.md); app-package updates supply a [WindowsSoftwareUpdateAppPackageInfo](./windowssoftwareupdateapppackageinfo.md).

Beyond the constructor parameters, additional provider-defined values can be attached and read back through [Properties](./windowssoftwareupdate_properties.md) and [GetPropertyValue](./windowssoftwareupdate_getpropertyvalue_1017420590.md).

## -see-also

[WindowsSoftwareUpdateProviderStatus](./windowssoftwareupdateproviderstatus.md), [WindowsUpdateManager](./windowsupdatemanager.md), [WindowsSoftwareUpdateExecutionInfo](./windowssoftwareupdateexecutioninfo.md), [WindowsSoftwareUpdateInstallationType](./windowssoftwareupdateinstallationtype.md)

## -examples

This C# example constructs a two-phase (download/install) executable software update and reports it from a provider scan.

```csharp
using System;
using Windows.Management.Update;

string providerId = "SampleProvider";
string updateId = "SampleApp.DownloadInstall_5.6.7.8";
string exe = "SampleProvider.exe";

var execution = new WindowsSoftwareUpdateExecutionInfo(
    new WindowsSoftwareUpdateActionInfo(exe, $"download --providerId {providerId} --updateId {updateId}", WindowsSoftwareUpdateActionType.Download),
    new WindowsSoftwareUpdateActionInfo(exe, $"install --providerId {providerId} --updateId {updateId}", WindowsSoftwareUpdateActionType.Install),
    optionalActions: null);

var update = new WindowsSoftwareUpdate(
    providerId,
    WindowsSoftwareUpdateInstallationType.Executable,
    updateId,
    "Sample Download/Install Update (5.6.7.8)",
    "A sample executable update.",
    new Uri("http://contoso.com/updateId=SampleApp.DownloadInstall_5.6.7.8"),
    1024 * 1024,        // download size in bytes
    2 * 1024 * 1024,    // install size in bytes
    new WindowsSoftwareUpdateIdentity(WindowsSoftwareUpdateIdentityType.ProductCode, "{87654321-4321-4321-4321-210987654321}"),
    null,               // source version
    new WindowsSoftwareUpdateVersion(5, 6, 7, 8),
    null,               // app package info (executable update)
    execution,
    new WindowsSoftwareUpdateOptionalInfo(WindowsSoftwareUpdateCategory.Application, null, null, null));
```

For complete, buildable provider samples in C#, C++, and PowerShell, see the [windows-uop](https://github.com/microsoft/windows-uop) repository.
