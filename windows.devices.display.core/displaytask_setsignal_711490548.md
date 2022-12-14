---
-api-id: M:Windows.Devices.Display.Core.DisplayTask.SetSignal(Windows.Devices.Display.Core.DisplayTaskSignalKind,Windows.Devices.Display.Core.DisplayFence)
-api-type: winrt method
---

# Windows.Devices.Display.Core.DisplayTask.SetSignal(Windows.Devices.Display.Core.DisplayTaskSignalKind,Windows.Devices.Display.Core.DisplayFence)

<!--
public void SetSignal (Windows.Devices.Display.Core.DisplayTaskSignalKind signalKind, Windows.Devices.Display.Core.DisplayFence fence);
-->

## -description

Creates a fence as part of the presentation pipeline, which will be signaled at a specified point in time by the graphics scheduler. You can **SetSignal** multiple times to provide fences for multiple events for the primary buffer that's part of the current present.

The fence value that is signaled is the value that's returned from [DisplayTaskPool.TryExecuteTask](/uwp/api/windows.devices.display.core.displaytaskpool.tryexecutetask) in the [DisplayTaskResult.PresentId](/uwp/api/windows.devices.display.core.displaytaskresult.presentid) property (it's very probable that it will increase by 1 with each Present).

## -parameters

### -param signalKind

A [DisplayTaskSignalKind](displaytasksignalkind.md) value specfying what kind of fence to use.

**OnPresentFlipAway**. This fence is signaled once the primary buffer it was attached to is no longer being scanned out by the GPU. The most common use of the *FlipAway* fence will be for apps to queue GPU render work on a given primary buffer, and put the render work behind a *FlipAway* fence to make sure that the primary buffer is free to render, and is not being actively scanned out by the GPU. This helps avoid any FBR (front buffer rendering), while still allowing the app to queue multiple render work in advance.

**OnPresentFlipTo**. This fence is signaled once the primary buffer it was attached to becomes the current primary buffer being scanned out by the GPU. The most common use of *FlipTo* fences is for the app to get stats about the presentation pipeline. For example, your app can calculate using this fence the latency between present submission, and present reaching the physical display. Another example is for your app to know which of the presents that the app requested actually made it to the physical display.

### -param fence

A [DisplayFence](displayfence.md) object.

## -remarks

Synchronizing between rendering to, and presentation of, a given set of primary buffers avoids front-buffer rendering.

## -see-also

## -examples
