---
-api-id: T:Windows.System.VirtualKeyModifiers
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.VirtualKeyModifiers : uint
-->

# VirtualKeyModifiers

## -description
Specifies the virtual key used to modify another keypress. For example, the Ctrl key when pressed in conjunction with another key, as in Ctrl+C.

## -enum-fields
### -field None:0
No virtual key modifier.

### -field Control:1
The Ctrl virtual key.

### -field Menu:2
The Alt virtual key.

### -field Shift:4
The Shift virtual key.

### -field Windows:8
The Windows virtual key.

## -remarks
This enum is used with the [Modifiers](../windows.ui.xaml.input/keyboardaccelerator_modifiers.md) property of a [KeyboardAccelerator](../windows.ui.xaml.input/keyboardaccelerator.md) object. For more information, including code examples, see [Keyboard Accelerators](/windows/uwp/design/input/keyboard-accelerators).

## -examples

## -see-also
[Keyboard Accelerators](/windows/uwp/design/input/keyboard-accelerators), [Windows.System.VirtualKey](virtualkey.md)
