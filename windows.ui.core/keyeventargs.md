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
> Apps do not receive this event when an [Input Method Editor (IME)](http://msdn.microsoft.com/library/5fcc73e6-f499-47e6-8e81-0014ca4d241c) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](keyeventargs_handled.md) to **true**.



> **Windows Phone**
> This API is supported in native apps only.

This object is returned by a delegate registered for one of the following events:
+ [CoreWindow.KeyDown](corewindow_keydown.md)
+ [CoreWindow.KeyUp](corewindow_keyup.md)




```cpp

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



> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275).

## -examples

## -see-also
[KeyDown](corewindow_keydown.md), [KeyUp](corewindow_keyup.md)