---
-api-id: E:Windows.Devices.Display.Core.DisplayManager.Disabled
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler Disabled<DisplayManager, DisplayManagerDisabledEventArgs>
-->

# Windows.Devices.Display.Core.DisplayManager.Disabled

## -description
An event raised whenever the current session's display stack is disabled, and when [DisplayManager.Stop](displaymanager_stop_1201535524.md) is called. You can disable the session display stack in several cases, such as switching Terminal Services sessions, or to recover from driver failures. We recommend that subscribers attempt to clean up when **Disabled** is invoked. Most display APIs will fail while the session display stack is disabled.

## -remarks
[DisplayManager](displaymanager.md) events are not raised until you call [DisplayManager.Start](displaymanager_start_1587696324.md).

## -see-also

## -examples
