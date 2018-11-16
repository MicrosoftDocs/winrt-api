---
-api-id: E:Windows.Devices.Display.Core.DisplayManager.PathsFailedOrInvalidated
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler PathsFailedOrInvalidated<DisplayManager, DisplayManagerPathsFailedOrInvalidatedEventArgs>
-->

# Windows.Devices.Display.Core.DisplayManager.PathsFailedOrInvalidated

## -description
An event that is raised whenever a display path is failed or invalidated asynchronously by the system. This can be due to changing hardware bandwidth requirements, or due to driver failures.

Subscribers to this event should call [TryAcquireTargetsAndReadCurrentState](displaymanager_tryacquiretargetsandreadcurrentstate_305775428.md) for targets that they own, and check whether any of the paths in the resulting [DisplayState](displaystate.md) object have their [Status](displaypath_status.md) property set to [FailedAsync](displaypathstatus.md) or **InvalidatedAsync**, and take the recommended action.

## -remarks

## -see-also

## -examples
