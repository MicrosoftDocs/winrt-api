---
-api-id: T:Windows.UI.Core.WindowActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WindowActivatedEventArgs : Windows.UI.Core.ICoreWindowEventArgs, Windows.UI.Core.IWindowActivatedEventArgs
-->

# Windows.UI.Core.WindowActivatedEventArgs

## -description
Contains the windows activation state information returned by the [CoreWindow.Activated](corewindow_activated.md) event.

## -remarks
This object is returned by a delegate registered for the [CoreWindow.Activated](corewindow_activated.md) event.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

## -examples
```cppwinrt
void SetWindow(CoreWindow const & window)
{
    ...
    window.Activated({ this, &App::OnActivated });
}

// Activation event data in WindowActivatedEventArgs.
void OnActivated(Windows::UI::Core::CoreWindow const& /* sender */, Windows::UI::Core::WindowActivatedEventArgs const& /* args */) {}
```

```cppcx
// returning window activation events data through WindowActivatedEventArgs
void MyCoreWindowEvents::SetWindow( // implementation called by CoreApplication::Run(), provided for context
    _In_ CoreWindow^ window
    )
{
    // ...
    window->Activated +=
        ref new TypedEventHandler<CoreWindow^, WindowActivatedEventArgs^>(this, &CoreWindowEvents::OnWindowActivated);
    // ...
}
```

## -see-also
[CoreWindow.Activated](corewindow_activated.md)
