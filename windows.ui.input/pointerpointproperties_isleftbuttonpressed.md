---
-api-id: P:Windows.UI.Input.PointerPointProperties.IsLeftButtonPressed
-api-type: winrt property
---

<!-- Property syntax
public bool IsLeftButtonPressed { get; }
-->

# Windows.UI.Input.PointerPointProperties.IsLeftButtonPressed

## -description
Gets a value that indicates whether the pointer input was triggered by the primary action mode of an input device.

## -property-value
True if the primary action mode; otherwise false.

## -remarks
Examples of primary action modes for various input devices:
- A touch pointer when it is in contact with the digitizer surface.
- A pen pointer when the pen tip is in contact with the digitizer surface and no modifying buttons, such as a barrel button (see [IsBarrelButtonPressed](pointerpointproperties_isbarrelbuttonpressed.md)), are pressed. An eraser tip does not set this property either (see [IsEraser](pointerpointproperties_iseraser.md)).
- A mouse pointer when the left mouse button is pressed.

## -examples

## -see-also
[IsRightButtonPressed](pointerpointproperties_isrightbuttonpressed.md), [IsMiddleButtonPressed](pointerpointproperties_ismiddlebuttonpressed.md), [IsXButton1Pressed](pointerpointproperties_isxbutton1pressed.md), [IsXButton2Pressed](pointerpointproperties_isxbutton2pressed.md)

