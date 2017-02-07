---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapInteractionMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.Maps.MapInteractionMode : int
-->

# MapInteractionMode

## -description
Specifies if the map responds to a touch gesture and if the corresponding UI control appears on the map.

## -enum-fields
### -field Auto:0
Map UI control, mouse, keyboard, pen, and touch input are enabled based on the type of device that your app is running on.

### -field Disabled:1
Map UI control and touch input are disabled.

### -field GestureOnly:2
Map responds to touch input only; the corresponding UI control is not visible. Use PointerAndKeyboard, if you want all forms of pointer input.

### -field PointerAndKeyboard:2
Map responds to mouse, pen, touch and keyboard.

### -field ControlOnly:3
Map responds to the UI control only; the corresponding touch input is disabled.

### -field GestureAndControl:4
Map UI control and touch input are enabled. Use PointerKeyboardAndControl, if you want all forms of pointer input; the corresponding UI control is not visible.

### -field PointerKeyboardAndControl:4
Mouse, pen, touch, keyboard, and Map UI control are enabled; the corresponding UI control is not visible.

### -field PointerOnly:5
Map responds to mouse, pen, or touch only.


## -remarks

## -examples

## -see-also