---
-api-id: E:Windows.Graphics.Display.DisplayInformation.DisplayContentsInvalidated
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.TypedEventHandler DisplayContentsInvalidated<Windows.Graphics.Display.DisplayInformation,  object>
-->

# Windows.Graphics.Display.DisplayInformation.DisplayContentsInvalidated

## -description
Occurs when the display requires redrawing.

## -remarks
This event is static.

Because this event is static, we recommend that you directly access it from the [DisplayInformation](displayinformation.md) object and not from the current physical display info that you get from a call to the [DisplayInformation.GetForCurrentView](displayinformation_getforcurrentview.md) method.

## -examples

## -see-also
