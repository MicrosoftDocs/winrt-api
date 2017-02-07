---
-api-id: T:Windows.UI.Core.WindowSizeChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WindowSizeChangedEventArgs : Windows.UI.Core.ICoreWindowEventArgs, Windows.UI.Core.IWindowSizeChangedEventArgs
-->

# Windows.UI.Core.WindowSizeChangedEventArgs

## -description
Contains the argument returned by a window size change event.

## -remarks
This object is returned by a delegate registered for the [CoreWindow.SizeChanged](corewindow_sizechanged.md) event.



```cpp

// returning window size change events data through WindowSizeChangedEventArgs

void MyCoreWindowEvents::SetWindow( // implementation called by CoreApplication::Run(), provided for context
    _In_ CoreWindow^ window
    )
{
   
    // ...
    window->SizeChanged +=
        ref new TypedEventHandler<CoreWindow^, WindowSizeChangedEventArgs^>(this, &CoreWindowEvents::OnWindowSizeChanged)

    // ...
   
}

```



> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275).

## -examples

## -see-also