---
-api-id: T:Windows.UI.Core.CharacterReceivedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class CharacterReceivedEventArgs : Windows.UI.Core.ICharacterReceivedEventArgs, Windows.UI.Core.ICoreWindowEventArgs
-->

# Windows.UI.Core.CharacterReceivedEventArgs

## -description
Provides the arguments returned by the event raised when a character is received by the input queue.

## -remarks

> **Windows 10**
> Apps do not receive this event when an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](acceleratorkeyeventargs_handled.md) to **true**.

> **Windows Phone**
> This API is supported in native apps only.

This object is returned by a delegate registered for the following event:
+ [CoreWindow.CharacterReceived](corewindow_characterreceived.md)

```cppwinrt
void SetWindow(CoreWindow const& window)
{
    ...
    window.CharacterReceived({this, &App::OnCharacterReceived });
}

// Character received event data in CharacterReceivedEventArgs.
void OnCharacterReceived(
    Windows::UI::Core::CoreWindow const& /* sender */,
    Windows::UI::Core::CharacterReceivedEventArgs const& /* args */)
{
}
```

```cppcx
// returning character received events data through CharacterReceivedEventArgs

void MyCoreWindowEvents::SetWindow( // implementation called by CoreApplication::Run(), provided for context
    _In_ CoreWindow^ window
    )
{
    // ...
    window->CharacterReceived +=
        ref new TypedEventHandler<CoreWindow^, CharacterReceivedEventArgs^>(this, &CoreWindowEvents::OnCharacterReceived);
    // ...
}
```

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

## -examples

## -see-also
[CharacterReceived](corewindow_characterreceived.md)
