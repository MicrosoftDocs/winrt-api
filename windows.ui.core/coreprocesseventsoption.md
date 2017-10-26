---
-api-id: T:Windows.UI.Core.CoreProcessEventsOption
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Core.CoreProcessEventsOption : int
-->

# CoreProcessEventsOption

## -description
Specifies the set of exclusive event-processing options passed to [ProcessEvents](coredispatcher_processevents.md).

## -enum-fields
### -field ProcessOneAndAllPending:0
Dispatch all currently available events in the queue. If no events are pending, wait for the next new event.

### -field ProcessOneIfPresent:1
Dispatch one event if it is currently pending in the queue. If no events are pending, do not wait for a new event to be raised but instead return immediately.

### -field ProcessUntilQuit:2
Wait for new events and dispatch all available events. Continue this behavior until the window is closed or the application calls the [Close](corewindow_close.md) method on the [CoreWindow](corewindow.md) instance.

### -field ProcessAllIfPresent:3
Dispatch all events currently pending in the queue. If no events are pending, do not wait for a new event to be raised but instead return immediately. This option is provided specifically for view provider implementations with [IFrameworkView](../windows.applicationmodel.core/iframeworkview.md), and to be used in UWP app using DirectX with C++.


## -remarks
### Windows Phone 8

**ProcessOneIfPresent** is not supported on Windows Phone.

## -examples

## -see-also
[CoreDispatcher.ProcessEvents](coredispatcher_processevents.md), [CoreWindow](corewindow.md)