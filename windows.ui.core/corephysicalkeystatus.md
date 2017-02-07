---
-api-id: T:Windows.UI.Core.CorePhysicalKeyStatus
-api-type: winrt struct
---

<!-- Structure syntax.
public struct CorePhysicalKeyStatus 
-->

# CorePhysicalKeyStatus

## -description
Specifies the set of physical key status items that can be obtained.

## -struct-fields

### -field RepeatCount
The number of times a key was pressed.
    

### -field ScanCode
The scan code for a key that was pressed.
    

### -field IsExtendedKey
Whether the key that was pressed maps to an extended ASCII character.
    

### -field IsMenuKeyDown
Whether the menu key is currently pressed down.
    

### -field WasKeyDown
Whether a key is currently pressed down.
    

### -field IsKeyReleased
Whether a key has moved from a pressed to a released status.
    

## -remarks

## -examples

## -see-also
[Windows.UI.Core](windows_ui_core.md), [AccerleratorKeyEventArgs.KeyStatus](acceleratorkeyeventargs_keystatus.md), [CharacterReceivedEventArgs.KeyStatus](characterreceivedeventargs_keystatus.md), [KeyEventArgs.KeyStatus](keyeventargs_keystatus.md)