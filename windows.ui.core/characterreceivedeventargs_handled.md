---
-api-id: P:Windows.UI.Core.CharacterReceivedEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Windows.UI.Core.CharacterReceivedEventArgs.Handled

## -description
Gets or sets whether the character-received event was handled or not.

## -property-value
True if the character received event has been handled; false if it has not.

## -remarks
> **Windows 10**
> Apps do not receive this event when an [Input Method Editor (IME)](http://msdn.microsoft.com/library/5fcc73e6-f499-47e6-8e81-0014ca4d241c) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](characterreceivedeventargs_handled.md) to **true**.

> **Windows Phone**
> This API is supported in native apps only.

## -examples

## -see-also
[CharacterReceived](corewindow_characterreceived.md)