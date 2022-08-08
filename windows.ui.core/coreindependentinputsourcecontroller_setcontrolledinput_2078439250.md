---
-api-id: M:Windows.UI.Core.CoreIndependentInputSourceController.SetControlledInput(Windows.UI.Core.CoreInputDeviceTypes,Windows.UI.Core.CoreIndependentInputFilters,Windows.UI.Core.CoreIndependentInputFilters)
-api-type: winrt method
---

# Windows.UI.Core.CoreIndependentInputSourceController.SetControlledInput(Windows.UI.Core.CoreInputDeviceTypes,Windows.UI.Core.CoreIndependentInputFilters,Windows.UI.Core.CoreIndependentInputFilters)

<!--
public void SetControlledInput (Windows.UI.Core.CoreInputDeviceTypes inputTypes, Windows.UI.Core.CoreIndependentInputFilters required, Windows.UI.Core.CoreIndependentInputFilters excluded);
-->

## -description

Identifies the [CoreInputDeviceTypes](coreinputdevicetypes.md) that should be delivered to the input source associated with the [CoreIndependentInputSourceController](coreindependentinputsourcecontroller.md), based on the specified filters.

## -parameters

### -param inputTypes

The supported input device types.

### -param required

The required filtering criteria for certain input device types.

### -param excluded

The filtering criteria for certain input device types to exclude.

## -remarks

If any filtering criteria are specified, the corresponding input device type must be specified in the *inputTypes* parameter.

Pen-related filtering criteria are only supported in the *excluded* parameter.

The filtering criteria are considered by the system when input is hit tested to determine where it should be routed. In some scenarios, hit testing results in input capture, where subsequent input is delivered to the same target without its own hit test. In these scenarios, the filtering criteria are not considered, as the input destination has already been determined.

For example, if [CoreIndependentInputFilters.MouseButton: 1](/uwp/api/windows.ui.core.coreindependentinputfilters#fields) is set, then the input source will also receive subsequent mouse motion input until the mouse buttons are released (mouse motion while a mouse button is held is captured to the destination of the mouse button).

## -see-also

[SetControlledInput(Windows.UI.Core.CoreInputDeviceTypes)](coreindependentinputsourcecontroller_setcontrolledinput_1474967388.md)

## -examples
