---
-api-id: T:Windows.UI.Core.KeyEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class KeyEventArgs : Windows.UI.Core.ICoreWindowEventArgs, Windows.UI.Core.IKeyEventArgs, Windows.UI.Core.IKeyEventArgs2
-->

# Windows.UI.Core.KeyEventArgs

## -description
Contains the arguments returned by a virtual key event.

## -remarks

> **Windows 10**
> Apps do not receive this event when an [Input Method Editor (IME)](/previous-versions/windows/apps/hh967427(v=win.10)) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](keyeventargs_handled.md) to **true**.

> **Windows Phone**
> This API is supported in native apps only.

This object is returned by a delegate registered for one of the following events:
+ [CoreWindow.KeyDown](corewindow_keydown.md)
+ [CoreWindow.KeyUp](corewindow_keyup.md)

```cppwinrt
void SetWindow(CoreWindow const & window)
{
    ...
    window.KeyDown({ this, &App::OnKeyDown });
    window.KeyUp({ this, &App::OnKeyUp });
}

// Keypress data is in KeyEventArgs.
void OnKeyDown(Windows::UI::Core::CoreWindow const& /* sender */,
    Windows::UI::Core::KeyEventArgs const& /* args */) {}

void OnKeyUp(Windows::UI::Core::CoreWindow const& /* sender */,
    Windows::UI::Core::KeyEventArgs const& /* args */) {}
```

```cppcx
// returning keypress events data through KeyEventArgs
void MyCoreWindowEvents::SetWindow( // implementation called by CoreApplication::Run(), provided for context
    _In_ CoreWindow^ window
    )
{
    // ...
    window->KeyDown +=
        ref new TypedEventHandler<CoreWindow^, KeyEventArgs^>(this, &CoreWindowEvents::OnKeyDown);
    window->KeyUp +=
        ref new TypedEventHandler<CoreWindow^, KeyEventArgs^>(this, &CoreWindowEvents::OnKeyUp);

    // ...
}
```

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | DeviceId |

## -examples

## -see-also
[KeyDown](corewindow_keydown.md), [KeyUp](corewindow_keyup.md)
