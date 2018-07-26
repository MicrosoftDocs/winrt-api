---
-api-id: P:Windows.UI.Text.Core.CoreTextLayoutRequest.LayoutBounds
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Text.Core.CoreTextLayoutBounds LayoutBounds { get; }
-->

# Windows.UI.Text.Core.CoreTextLayoutRequest.LayoutBounds

## -description

Gets the screen coordinates of the bounding box for a range of text, or a text input control.

## -property-value

An object that represents the layout bounds information requested by the text input server.

## -remarks

Your application should populate the requested layout properties of this object before returning from the event handler.

Use the [LayoutBoundsVisualPixels](coretextlayoutrequest_layoutboundsvisualpixels.md) method to get the layout properties relative to the viewport of your application.

## -examples

## -see-also
