---
-api-id: E:Windows.Devices.Display.Core.DisplayManager.Enabled
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler Enabled<DisplayManager, DisplayManagerEnabledEventArgs>
-->

# Windows.Devices.Display.Core.DisplayManager.Enabled

## -description
An event raised whenever the current session's display stack is enabled, and when [DisplayManager.Start](displaymanager_start_1587696324.md) is called. You can re-enable the session display stack in several cases, such as switching Terminal Services sessions, or to recover from driver failures. We recommend that subscribers re-enumerate all targets and state in this call, since the system display stack could be left in any state before this event is raised.

## -remarks
[DisplayManager](displaymanager.md) events are not raised until you call [DisplayManager.Start](displaymanager_start_1587696324.md).

## -see-also

## -examples
