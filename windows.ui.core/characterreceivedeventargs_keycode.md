---
-api-id: P:Windows.UI.Core.CharacterReceivedEventArgs.KeyCode
-api-type: winrt property
---

<!-- Property syntax
public uint KeyCode { get; }
-->

# Windows.UI.Core.CharacterReceivedEventArgs.KeyCode

## -description
Gets the key code of the character received by the input queue.

## -property-value
The character in UTF-16 encoding. Each supplementary character consists of a [surrogate pair](/windows/win32/intl/surrogates-and-supplementary-characters) sent as two separate events.

## -remarks
> **Windows 10**
> Apps do not receive this event when an [Input Method Editor (IME)](/windows/apps/design/input/input-method-editors) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](characterreceivedeventargs_handled.md) to **true**.

> **Windows Phone**
> This API is supported in native apps only.

## -examples

## -see-also
[CharacterReceived](corewindow_characterreceived.md)
