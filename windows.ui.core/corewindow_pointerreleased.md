---
-api-id: E:Windows.UI.Core.CoreWindow.PointerReleased
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PointerReleased<Windows.UI.Core.CoreWindow,  Windows.UI.Core.PointerEventArgs>
-->

# Windows.UI.Core.CoreWindow.PointerReleased

## -description

Occurs when a pressed mouse button is released, or a touch or pen contact is lifted from the digitizer surface, within the bounding rectangle of the app (or outside the bounding rectangle, if the pointer is captured).

## -remarks

An interaction session starts when a single contact is detected and ends when that contact, and all subsequent contacts in the same session, are no longer detected.

This event is fired for each contact detected in the interaction session (except for mouse, where this event is fired only when the last mouse button is released).

## -examples

## -see-also

[Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
