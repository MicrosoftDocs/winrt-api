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
[Handle pointer input](https://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82)
