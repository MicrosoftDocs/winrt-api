---
-api-id: T:Windows.UI.Xaml.Input.KeyTipPlacementMode
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum KeyTipPlacementMode : int {
    Auto = 0
    Bottom = 1
    Center = 5
    Hidden = 6
    Left = 3
    Right = 4
    Top = 2
}
-->

# Windows.UI.Xaml.Input.KeyTipPlacementMode

## -description

Defines constants that specify where a keytip is placed in relation to a UIElement.



## -enum-fields

### -field Auto:0
The placement of the keytip is determined by the system.

### -field Bottom:1
The keytip is placed below the element.

### -field Top:2
The keytip is placed above the element.

### -field Left:3
The keytip is placed left of the element.

### -field Right:4
The keytip is placed right of the element.

### -field Center:5
The keytip is centered on the element.

### -field Hidden:6
The keytip is not shown.

## -remarks

Keytips are badges displayed next to controls that support access keys when the user presses the Alt key. Each keytip contains the alphanumeric keys that activate the associated control.

This enumeration is used by the [UIElement.KeyTipPlacementMode](../windows.ui.xaml/uielement_keytipplacementmode.md) property.

## -see-also

[UIElement.KeyTipPlacementMode](../windows.ui.xaml/uielement_keytipplacementmode.md), [Access keys](/windows/uwp/input-and-devices/access-keys), [Access keys](/windows/apps/design/input/access-keys)

## -examples
