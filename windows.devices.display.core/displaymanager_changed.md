---
-api-id: E:Windows.Devices.Display.Core.DisplayManager.Changed
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler Changed<DisplayManager, DisplayManagerChangedEventArgs>
-->

# Windows.Devices.Display.Core.DisplayManager.Changed

## -description
An event that is raised when system display hardware is added, removed, or modified. This can occur whenever the [DisplayAdapter](displayadapter.md) or [DisplayTarget](displaytarget.md) collections change. Use this event to detect these changes and call [GetCurrentAdapters](displaymanager_getcurrentadapters_478333146.md) and/or [GetCurrentTargets](displaymanager_getcurrenttargets_1359061908.md) to get the updated collections.

## -remarks
[DisplayManager](displaymanager.md) events are not raised until you call [DisplayManager.Start](displaymanager_start_1587696324.md).

## -see-also

## -examples
