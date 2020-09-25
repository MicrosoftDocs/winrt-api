---
-api-id: M:Windows.Devices.Display.Core.DisplayState.TryFunctionalize(Windows.Devices.Display.Core.DisplayStateFunctionalizeOptions)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public DisplayStateOperationResult DisplayState.TryFunctionalize(DisplayStateFunctionalizeOptions options)
-->

# Windows.Devices.Display.Core.DisplayState.TryFunctionalize

## -description
Attempts to "functionalize" this [DisplayState](displaystate.md) by trying to evaluate the best modes on all paths given all specified [DisplayPath](displaypath.md) properties as constraints. This method then (optionally, see **Remarks**) updates all **DisplayPath** and [DisplayView](displayview.md) properties with the results of the functionalization. In particular, all **DisplayPath** and **DisplayView** properties set to null will have their values computed and set.

## -parameters
### -param options
The [DisplayStateFunctionalizeOptions](displaystatefunctionalizeoptions.md) to use.

## -returns
A [DisplayStateOperationResult](displaystateoperationresult.md) value detailing the success or failure of the operation.

## -remarks
Use the [ValidateTopologyOnly](displaystatefunctionalizeoptions.md) option to prevent updating all **DisplayPath** properties with the results of the functionalization.

Note that calling [TryApply](displaystate_tryapply_634222246.md) also implicitly functionalizes the state before applying it to the system, but **TryApply** never updates this state's **DisplayPath** properties with the results of the functionalization.

Functionalizing a **DisplayState** can be a fairly expensive operation, since it involves querying display drivers and comparing many possible modes. The operation will usually be cheaper if you set more of your **DisplayPath** properties before calling this method (or calling **TryApply**), since it reduces the amount of work needed to evaluate the "best" mode on a given path.

Using **TryFunctionalize** to determine whether the current state can be functionalized before calling **TryApply** is a good practice, since **TryApply** is always more expensive than **TryFunctionalize**. Once **TryFunctionalize** succeeds, a subsequent call to **TryApply** will be cheaper, since it no longer has to do the work of functionalizing modes.

## -see-also

## -examples
