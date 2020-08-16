---
-api-id: T:Windows.UI.Core.PointerEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class PointerEventArgs : Windows.UI.Core.ICoreWindowEventArgs, Windows.UI.Core.IPointerEventArgs
-->

# Windows.UI.Core.PointerEventArgs

## -description
Contains the arguments returned by the last pointer event.

## -remarks
This object is returned by a delegate registered for one of the following events:
+ [CoreWindow.PointerCaptureLost](corewindow_pointercapturelost.md)
+ [CoreWindow.PointerEntered](corewindow_pointerentered.md)
+ [CoreWindow.PointerExited](corewindow_pointerexited.md)
+ [CoreWindow.PointerMoved](corewindow_pointermoved.md)
+ [CoreWindow.PointerPressed](corewindow_pointerpressed.md)
+ [CoreWindow.PointerReleased](corewindow_pointerreleased.md)
+ [CoreWindow.PointerWheelChanged](corewindow_pointerwheelchanged.md)

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://msdn.microsoft.com/en-us/library/windows/apps/hh771042.aspx).

## -examples
```cppwinrt
void SetWindow(CoreWindow const & window)
{
    window.PointerCursor(Windows::UI::Core::CoreCursor{ CoreCursorType::Arrow, 0 });

    window.PointerPressed({ this, &App::OnPointerPressed });
    window.PointerReleased({ this, &App::OnPointerReleased });
    window.PointerMoved({ this, &App::OnPointerMoved });
}

// Pointer event data in PointerEventArgs.
void OnPointerPressed(Windows::UI::Core::CoreWindow const& /* sender */,
    Windows::UI::Core::PointerEventArgs const& /* args */) {}

void OnPointerReleased(Windows::UI::Core::CoreWindow const& /* sender */,
    Windows::UI::Core::PointerEventArgs const& /* args */) {}

void OnPointerMoved(Windows::UI::Core::CoreWindow const& /* sender */,
    Windows::UI::Core::PointerEventArgs const& /* args */) {}
```

```cppcx
// returning pointer events data through PointerEventArgs

void MyCoreWindowEvents::SetWindow( // implementation called by CoreApplication::Run(), provided for context
    _In_ CoreWindow^ window
    )
{
    window->PointerCursor = ref new CoreCursor(CoreCursorType::Arrow, 0);

    // ...
    window->PointerPressed +=
        ref new TypedEventHandler<CoreWindow^, PointerEventArgs^>(this, &CoreWindowEvents::OnPointerPressed);
    window->PointerReleased +=
        ref new TypedEventHandler<CoreWindow^, PointerEventArgs^>(this, &CoreWindowEvents::OnPointerReleased);
    window->PointerMoved +=
        ref new TypedEventHandler<CoreWindow^, PointerEventArgs^>(this, &CoreWindowEvents::OnPointerMoved);

    // ...
}
```

## -see-also
[Input: Manipulations and gestures (C++) sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Gestures%20and%20manipulations%20with%20GestureRecognizer), [Input: Simplified ink  sample](https://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Touch hit testing sample](https://go.microsoft.com/fwlink/p/?linkid=231590)
