---
-api-id: E:Windows.UI.Core.CoreWindow.CharacterReceived
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler CharacterReceived<Windows.UI.Core.CoreWindow,  Windows.UI.Core.CharacterReceivedEventArgs>
-->

# Windows.UI.Core.CoreWindow.CharacterReceived

## -description
Is fired when a new character is received by the input queue.

## -remarks
Apps do not receive this event when an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](characterreceivedeventargs_handled.md) to **true**.

## -examples

## -see-also
[CharacterReceivedEventArgs](characterreceivedeventargs.md)