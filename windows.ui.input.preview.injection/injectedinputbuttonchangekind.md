---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputButtonChangeKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputButtonChangeKind : int
-->

# InjectedInputButtonChangeKind

## -description
Specifies the changes in state of a button associated with a pointer.

## -enum-fields
### -field None:0
No change in button state. Default.

### -field FirstButtonDown:1
Indicates a primary action is initiated.

A touch pointer has this flag set when it is in contact with the digitizer surface.

A pen pointer has this flag set when it is in contact with the digitizer surface with no buttons pressed.

A mouse pointer sets this flag when the left mouse button is down.

### -field FirstButtonUp:2
Indicates a primary action is complete.

### -field SecondButtonDown:3
Indicates a secondary action is initiated.

A touch pointer does not use this flag.

A pen pointer has this flag set when it is in contact with the digitizer surface with the pen barrel button pressed.

A mouse pointer sets this flag when the right mouse button is down.

### -field SecondButtonUp:4
Indicates a secondary action is complete.

### -field ThirdButtonDown:5
Indicates a third action is initiated.A touch pointer does not use this flag.

A pen pointer does not use this flag.

A mouse pointer sets this flag when the mouse wheel button is down.

### -field ThirdButtonUp:6
Indicates a third action is complete.

### -field FourthButtonDown:7
Indicates a fourth action is initiated.

A touch pointer does not use this flag.

A pen pointer does not use this flag.

A mouse pointer has this flag set when the first extended mouse (XBUTTON1) button is down.

### -field FourthButtonUp:8
Indicates a fourth action is complete.

### -field FifthButtonDown:9
Indicates a fifth action is initiated.

A touch pointer does not use this flag.

A pen pointer does not use this flag.

A mouse pointer has this flag set when the second extended mouse (XBUTTON2) button is down.

### -field FifthButtonUp:10
Indicates a fifth action is complete.


## -remarks

## -examples

## -see-also
[Windows.UI.Input.Preview.Injection enumerations](windows_ui_input_preview_injection_enumerations.md)