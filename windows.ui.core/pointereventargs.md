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






```cpp

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



> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275).

## -examples

## -see-also
[Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590)