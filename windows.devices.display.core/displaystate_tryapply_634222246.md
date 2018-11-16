---
-api-id: M:Windows.Devices.Display.Core.DisplayState.TryApply(Windows.Devices.Display.Core.DisplayStateApplyOptions)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public DisplayStateOperationResult DisplayState.TryApply(DisplayStateApplyOptions options)
-->

# Windows.Devices.Display.Core.DisplayState.TryApply

## -description
Attempts to atomically apply this [DisplayState](displaystate.md) to the relevant hardware. Implicitly, this involves "functionalizing" all paths to determine the best modes matching all [DisplayPath](displaypath.md) and [DisplayView](displayview.md) properties.

## -parameters
### -param options
The [DisplayStateApplyOptions](displaystateapplyoptions.md) to use.

## -returns
A [DisplayStateOperationResult](displaystateoperationresult.md) value detailing the success or failure of the operation.

## -remarks
After applying this [DisplayState](displaystate.md), no properties are updated on this object or any of the [DisplayPath](displaypath.md) nor [DisplayView](displayview.md) objects. You can use [DisplayManager.TryAcquireTargetsAndReadCurrentState](displaymanager_tryacquiretargetsandreadcurrentstate_305775428.md) to read the state that was set by the **TryApply** operation.

## -see-also

## -examples
