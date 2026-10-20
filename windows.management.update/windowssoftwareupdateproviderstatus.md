---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateProviderStatus
-api-type: winrt class
---

# Windows.Management.Update.WindowsSoftwareUpdateProviderStatus

<!--
public sealed class WindowsSoftwareUpdateProviderStatus
-->


## -description

The channel a provider uses to report results back to the Windows Update Orchestrator: scan results, action progress, and action results. It also notifies the provider when the orchestrator requests cancellation.

## -remarks

The orchestrator invokes a registered provider's scan or action file in SYSTEM context. The provider creates a **WindowsSoftwareUpdateProviderStatus** for its provider ID, then:

* During a scan, builds [WindowsSoftwareUpdate](./windowssoftwareupdate.md) objects and submits them with [SetScanResult](./windowssoftwareupdateproviderstatus_setscanresult_550695687.md).
* During an action, reports progress with [SetActionProgress](./windowssoftwareupdateproviderstatus_setactionprogress_1704852564.md) and a final outcome with [SetActionResult](./windowssoftwareupdateproviderstatus_setactionresult_217546004.md).

Handle the [CancelRequested](./windowssoftwareupdateproviderstatus_cancelrequested.md) event to stop long-running work promptly when the orchestrator asks the action to cancel.

## -see-also

[WindowsSoftwareUpdate](./windowssoftwareupdate.md), [WindowsSoftwareUpdateProviderActionResult](./windowssoftwareupdateprovideractionresult.md), [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md)

## -examples

An executable or PowerShell provider is invoked once per operation. During a scan it builds its updates and submits them; during an action it reports progress and a final result. This C# example shows both flows.

**Scan:** build updates and submit them.

```csharp
using System.Collections.Generic;
using Windows.Management.Update;

string providerId = "SampleProvider";
var updates = new List<WindowsSoftwareUpdate> { /* ...built during the scan... */ };

var status = new WindowsSoftwareUpdateProviderStatus(providerId);
WindowsSoftwareUpdateResult result = status.SetScanResult(true, 0, 0, updates);
```

**Action:** report progress, then the result.

```csharp
string providerId = "SampleProvider";
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
```

Equivalent C++/WinRT and PowerShell implementations are shown on the [Windows.Management.Update](./windows_management_update.md) namespace page, and complete samples are in the [windows-uop](https://github.com/microsoft/windows-uop) repository.
