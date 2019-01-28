---
-api-id: P:Windows.UI.Text.Core.CoreTextLayoutRequest.LayoutBoundsVisualPixels
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public CoreTextLayoutBounds LayoutBoundsVisualPixels { get; }
-->

# Windows.UI.Text.Core.CoreTextLayoutRequest.LayoutBoundsVisualPixels

## -description

Gets the coordinates of the bounding box for a range of text, or a text input control, relative to viewport of your application.

## -property-value

An object that represents the layout bounds information requested by the text input server. 

The coordinates are in device-independent pixels (DIP), relative to the top left corner of the viewport of your application.

## -remarks

Your application should populate the requested layout properties of this object before returning from the event handler.

Visual pixels are defined as coordinate values relative to the position, scale, and rotation of a specific UI element (such as the application's core window, a XAML island, or other edit control/visible element).

## -see-also

## -examples
