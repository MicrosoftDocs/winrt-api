---
-api-id: P:Windows.UI.Core.PointerEventArgs.CurrentPoint
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Input.PointerPoint CurrentPoint { get; }
-->

# Windows.UI.Core.PointerEventArgs.CurrentPoint

## -description
Gets the pointer data of the last pointer event.

## -property-value
Information about the state and screen position of the pointer.

## -remarks
CurrentPoint corresponds to the last point retrieved by [GetIntermediatePoints](pointereventargs_getintermediatepoints_1956108759.md).

## -examples

```cppwinrt
void OnPointerPressed(Windows::UI::Core::CoreWindow const& /* sender */, Windows::UI::Core::PointerEventArgs const& args)
{
    Windows::UI::Input::PointerPoint currentPoint{ args.CurrentPoint() };
}
```

```cppcx
void MyCoreWindowEvents::GetPointerInfo(
    _In_ PointerEventArgs^ args)
{
    Windows::UI::Input::PointerPoint^ currentPoint = args->CurrentPoint;
}
```

## -see-also
