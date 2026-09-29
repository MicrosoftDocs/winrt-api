---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateActionProgress
-api-type: winrt class
---

# Windows.Management.Update.WindowsSoftwareUpdateActionProgress

<!--
public sealed class WindowsSoftwareUpdateActionProgress
-->


## -description

Describes the progress of the action that's currently being performed on a [WindowsSoftwareUpdate](./windowssoftwareupdate.md).

## -remarks

Progress is expressed as a current value out of a total. A provider reports progress by calling [WindowsSoftwareUpdateProviderStatus.SetActionProgress](./windowssoftwareupdateproviderstatus_setactionprogress_1704852564.md); consumers read the latest progress from [WindowsSoftwareUpdate.ActionProgress](./windowssoftwareupdate_actionprogress.md).

## -see-also

[WindowsSoftwareUpdate](./windowssoftwareupdate.md), [WindowsSoftwareUpdateProviderStatus](./windowssoftwareupdateproviderstatus.md)

## -examples

