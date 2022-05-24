---
-api-id: T:Windows.Devices.Display.Core.DisplayPresentStatus
-api-type: winrt enum
---

# Windows.Devices.Display.Core.DisplayPresentStatus

<!--
public enum DisplayPresentStatus
-->

## -description

Defines constants that specify a detailed status of the result of the most recent call to [DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md).

## -enum-fields

### -field Success: 0

Specifies that the requested present was successfully queued to the graphics scheduler. If you registered *OnPresentFlipTo*/*OnPresentFlipAway* fences, then they're guaranteed to be signaled.

### -field SourceStatusPreventedPresent: 1

Specifies that you should look at the [DisplayTaskResult.SourceStatus](displaytaskresult_sourcestatus.md) returned from [DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md) to get more detailed error info, since the source prevented the present from being successfully queued.

### -field ScanoutInvalid: 2

Specifies that the [DisplayScanout](displayscanout.md) is invalid; you need to recreate the **DisplayScanout** before trying again.

### -field SourceInvalid: 3

Specifies that the [DisplaySource](displaysource.md) is now invalid; you should recreate the **DisplaySource** before trying again.

### -field DeviceInvalid: 4

Specifies that the [DisplaySource](displaysource.md) is invalid. This can happen if the underlying GPU adapter stopped or was removed from the kernel's perspective. You can try recreating the [DisplayDevice](displaydevice.md).

### -field UnknownFailure: 5

Specifies a failure that doesn't map to any concrete cause; this generally means that you should fail fast.

## -remarks

## -see-also
[DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md)

## -examples
