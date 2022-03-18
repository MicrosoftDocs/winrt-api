---
-api-id: E:Windows.UI.Core.CoreWindow.PointerPressed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PointerPressed<Windows.UI.Core.CoreWindow,  Windows.UI.Core.PointerEventArgs>
-->

# Windows.UI.Core.CoreWindow.PointerPressed

## -description

Occurs when a mouse button is clicked, or the digitizer surface has been touched by a finger or pen, within the bounding rectangle of the app.

An interaction session starts when a single contact is detected and ends when that contact, and all subsequent contacts in the same session, are no longer detected.

This event is fired for the first contact detected in the interaction session. Details for all other concurrent contact pointers are exposed through a [PointerPointProperties](../windows.ui.input/pointerpointproperties.md) object (obtained by getting the [Properties](../windows.ui.input/pointerpoint_properties.md) property from a [PointerPoint](../windows.ui.input/pointerpoint.md) object).

## -remarks

## -examples

## -see-also

[Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
