---
-api-id: T:Windows.UI.Xaml.Input.ManipulationModes
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Input.ManipulationModes : uint
-->

# ManipulationModes

## -description

Specifies how a target UI element interprets manipulation events. This enumeration is flagwise, so you can set multiple modes for the [ManipulationMode](../windows.ui.xaml/uielement_manipulationmode.md) property.



## -enum-fields
### -field None:0
Do not present graphic interaction with manipulation events.

### -field TranslateX:1
Permit manipulation actions that translate the target on the X axis.

### -field TranslateY:2
Permit manipulation actions that translate the target on the Y axis.

### -field TranslateRailsX:4
Permit manipulation actions that translate the target on the X axis but using a rails mode.

### -field TranslateRailsY:8
Permit manipulation actions that translate the target on the Y axis but using a rails mode.

### -field Rotate:16
Permit manipulation actions that rotate the target.

### -field Scale:32
Permit manipulation actions that scale the target.

### -field TranslateInertia:64
Apply inertia to translate actions.

### -field RotateInertia:128
Apply inertia to rotate actions.

### -field ScaleInertia:256
Apply inertia to scale actions.

### -field All:65535
Enable all manipulation interaction modes except those supported through [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal)

### -field System:65536
Enable system-driven touch interactions supported through [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal).


## -remarks

> [!NOTE]
> [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal) defines a manipulation as the scrolling or zooming of some part of the application UI.

This enumeration provides the value for the [UIElement.ManipulationMode](../windows.ui.xaml/uielement_manipulationmode.md) property. By setting this property you can enable app code handling for manipulation events such as [ManipulationStarted](../windows.ui.xaml/uielement_manipulationstarted.md). You must set the [ManipulationMode](../windows.ui.xaml/uielement_manipulationmode.md) to a value other than **System** or **None** to enable handling the events from that element. For more info on manipulations, see [Handle pointer input](/windows/uwp/design/input/handle-pointer-input).

Value enforcement for possible combinations is documented in the Remarks for the [UIElement.ManipulationMode](../windows.ui.xaml/uielement_manipulationmode.md) property.

## -examples

## -see-also
[ManipulationMode](../windows.ui.xaml/uielement_manipulationmode.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input)
