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
[Handle pointer input](https://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82)
