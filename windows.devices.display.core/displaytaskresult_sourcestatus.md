---
-api-id: P:Windows.Devices.Display.Core.DisplayTaskResult.SourceStatus
-api-type: winrt property
---

# Windows.Devices.Display.Core.DisplayTaskResult.SourceStatus

<!--
public Windows.Devices.Display.Core.DisplaySourceStatus SourceStatus { get; }
-->

## -description

Gets the current status of the [DisplaySource](displaysource.md) immediately before [DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md) returns.

## -property-value

A [DisplaySourceStatus](displaysourcestatus.md) representing the current status of the [DisplaySource](displaysource.md) immediately before [DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md) returns.

## -remarks
You can also obtain a [DisplaySourceStatus](displaysourcestatus.md) (representing the status of a display source) by accessing the standalone [DisplaySource.Status](displaysource_status.md) property.

Status is returned for [DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md) in order to provide a complete picture of the system state that potentially affected the last-requested present.

When [DisplayTaskResult.PresentStatus](displaytaskresult_presentstatus.md) returns a value pointing to a **DisplaySource**, the **SourceStatus** property is useful for determining different error conditions hit by **TryExecuteTask** due to **DisplaySource**. Your DirectDisplay client should also register for the [DisplaySource.StatusChanged](displaysource_statuschanged.md) event. That's because the status of a **DisplaySource** can also change asynchronously to **TryExecuteTask**, and it will give you an indication about when to retry **TryExecuteTask**.

One common usage of **SourceStatus** is when **TryExecuteTask** returns **SourceStatusPreventedPresent** in **PresentStatus**. In that case if the **SourceStatus** is **PoweredOff**, then that specifies a scenario where the most recent present was not queued in the graphics scheduler since the physical display path is considered powered off from the kernel's perspective. You should then look out for the **DisplaySourceStatus** change event, and check when the display is powered on again, and then resume calling **TryExecuteTask**.

## -see-also
[DisplaySource](displaysource.md), [DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md)

## -examples
