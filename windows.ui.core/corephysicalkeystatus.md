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

The number of times a key was pressed.  See [Repeat Count](/windows/win32/inputdev/about-keyboard-input#repeat-count) for more info.

### -field ScanCode

The scan code for a key that was pressed. See [Scan Code](/windows/win32/inputdev/about-keyboard-input#scan-code) for more info.

### -field IsExtendedKey

Whether the key is an extended key, such as the right-hand ALT and CTRL keys that appear on an Enhanced 101/102-key keyboard. See [Extended-Key Flag](/windows/win32/inputdev/about-keyboard-input#extended-key-flag) for more info.

### -field IsMenuKeyDown

Whether the Alt key (represented by the VirtualKey.Menu value) is currently pressed down. See [Context Code](/windows/win32/inputdev/about-keyboard-input#context-code) for more info.

### -field WasKeyDown

Whether a key is currently pressed down. See [Previous Key-State Flag](/windows/win32/inputdev/about-keyboard-input#previous-key-state-flag) for more info.

### -field IsKeyReleased

Whether a key has moved from a pressed to a released status. See [Transition-State Flag](/windows/win32/inputdev/about-keyboard-input#transition-state-flag) for more info.

## -remarks

## -examples

## -see-also

[Windows.UI.Core](windows_ui_core.md), [AccerleratorKeyEventArgs.KeyStatus](acceleratorkeyeventargs_keystatus.md), [CharacterReceivedEventArgs.KeyStatus](characterreceivedeventargs_keystatus.md), [KeyEventArgs.KeyStatus](keyeventargs_keystatus.md), [Keyboard events](/windows/uwp/design/input/keyboard-events)
