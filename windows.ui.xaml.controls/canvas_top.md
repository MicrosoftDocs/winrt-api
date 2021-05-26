---
-api-id: P:Windows.UI.Xaml.Controls.Canvas.Top
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Controls.Canvas.Top

<!--
see GetTop, and SetTop
-->

## -description

Gets or sets the distance between the top of an element and the top of its parent Canvas.

## -remarks

The `Top` value is the vertical offset between the top edge of the parent [Canvas](canvas.md) and where the target element should be placed. You typically specify positive integer numbers. Non-integer `Double` values are allowed but can potentially cause subpixel rendering issues; see [UIElement.UseLayoutRounding](/uwp/api/windows.ui.xaml.uielement.uselayoutrounding).

A `Canvas.Top` value is interpreted by the most immediate parent `Canvas` element from where the value is set. The value is used along with [Canvas.Left](canvas_left.md) to specify the layout characteristics of each child element of a `Canvas`.

<ul><li>Type: Double</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.canvas.topproperty">TopProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.canvas.gettop">GetTop</a>, <a href="/uwp/api/windows.ui.xaml.controls.canvas.settop">SetTop</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
