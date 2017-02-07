---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputKeyOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputKeyOptions : uint
-->

# InjectedInputKeyOptions

## -description
Specifies the various options, or modifiers, used to simulate input from physical or virtual keyboards through [InjectedInputKeyboardInfo](injectedinputkeyboardinfo.md).

## -enum-fields
### -field None:0
No keystroke modifier. Default.

### -field ExtendedKey:1
The key is an extended key, such as a function key or a key on the numeric keypad.

### -field KeyUp:2
The key is released.

### -field Unicode:4
The key is a Unicode value.

### -field ScanCode:8
The OEM, device-dependent identifier for the key on the keyboard.A keyboard generates two scan codes when the user types a key—one when the user presses the key and another when the user releases the key.


## -remarks

## -examples

## -see-also
[Windows.UI.Input.Preview.Injection enumerations](windows_ui_input_preview_injection_enumerations.md)