---
-api-id: P:Windows.UI.Input.PointerPointProperties.IsRightButtonPressed
-api-type: winrt property
---

<!-- Property syntax
public bool IsRightButtonPressed { get; }
-->

# Windows.UI.Input.PointerPointProperties.IsRightButtonPressed

## -description
Gets a value that indicates whether the pointer input was triggered by the secondary action mode (if supported) of an input device.

## -property-value
True if the secondary action mode; otherwise false.

## -remarks
Examples of secondary action modes for various input devices:
- A touch pointer does not set this property.
- A pen pointer when the pen tip is in contact with the digitizer surface and a modifying button, such as a barrel button (see [IsBarrelButtonPressed](pointerpointproperties_isbarrelbuttonpressed.md)), is pressed. An eraser tip does not set this property (see [IsEraser](pointerpointproperties_iseraser.md)).
- A mouse pointer when the right mouse button is pressed.

## -examples

## -see-also
[IsLeftButtonPressed](pointerpointproperties_isleftbuttonpressed.md), [IsMiddleButtonPressed](pointerpointproperties_ismiddlebuttonpressed.md), [IsXButton1Pressed](pointerpointproperties_isxbutton1pressed.md), [IsXButton2Pressed](pointerpointproperties_isxbutton2pressed.md)

