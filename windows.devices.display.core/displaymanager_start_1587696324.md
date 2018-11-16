---
-api-id: M:Windows.Devices.Display.Core.DisplayManager.Start
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void DisplayManager.Start()
-->

# Windows.Devices.Display.Core.DisplayManager.Start

## -description
Starts listening for all [DisplayManager](displaymanager.md) events atomically. [DisplayManager](displaymanager.md) events are not raised until you call **Start**.

## -remarks
All callers of **Start** are required to have subscribed to [Enabled](displaymanager_enabled.md), [Disabled](displaymanager_disabled.md), [Changed](displaymanager_changed.md), and [PathsFailedOrInvalidated](displaymanager_pathsfailedorinvalidated.md). **Start** fails if there are no subscribers to any of those events.

## -see-also

## -examples
