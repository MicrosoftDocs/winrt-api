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


<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

## -examples

```cppwinrt
void SetWindow(CoreWindow const & window)
{
    ...
    window.SizeChanged({ this, &App::OnWindowSizeChanged });
}

// Size changed data in WindowSizeChangedEventArgs.
void OnWindowSizeChanged(Windows::UI::Core::CoreWindow const& /* sender */, Windows::UI::Core::WindowSizeChangedEventArgs const& /* args */) {}
```

```cppcx
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

## -see-also
