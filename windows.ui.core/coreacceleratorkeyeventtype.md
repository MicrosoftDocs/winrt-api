---
-api-id: T:Windows.UI.Core.CoreAcceleratorKeyEventType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Core.CoreAcceleratorKeyEventType : int
-->

# CoreAcceleratorKeyEventType

## -description
Specifies the set of possible accelerator key events that can invoke a callback.

## -enum-fields
### -field Character:2
A character key is pressed.

### -field DeadCharacter:3
A dead character key is pressed. (A *dead character* key is a key that modifies the next keypress, like an accent character.)

### -field KeyDown:0
A key is pressed down.

### -field KeyUp:1
A key is raised.

### -field SystemCharacter:6
A system character key is pressed.

### -field SystemDeadCharacter:7
A system dead character key is pressed.

### -field SystemKeyDown:4
A system key is pressed down.

### -field SystemKeyUp:5
A system key is raised.

### -field UnicodeCharacter:8
A Unicode character key is pressed.


## -remarks

## -examples

## -see-also
[AcceleratorKeyEventArgs](acceleratorkeyeventargs.md)