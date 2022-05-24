---
-api-id: P:Windows.UI.Xaml.Controls.Canvas.ZIndex
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Controls.Canvas.ZIndex

<!--
see GetZIndex, and SetZIndex
-->

## -description

Gets or sets the Z-order of an element when that element is presented in its parent Canvas layout container.

## -remarks

`Canvas.ZIndex` declares the draw order for the child elements of a [Canvas](canvas.md). This matters when there is overlap between any of the bounds of the child elements. A higher z-order value will draw on top of a lower z-order value. If no value is set, the default is -1. If there is a draw order issue where elements share one or more pixels of layout space in a `Canvas` and the z-index values are the same, then the last element declared in XAML (or the highest index element in the `Children` collection if using code) is the element that draws on top.

You typically use values 0 and greater but negative values are permitted. A negative value, such as -99, places the object even farther from the foreground than any default value. The maximum allowed value is 1,000,000 (one million).

A value is interpreted by the most immediate parent `Canvas` element from where the value is set. The value is used to explicitly define the draw order in cases where child elements overlap.

<ul><li>Type: Int32</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.canvas.zindexproperty">ZIndexProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.canvas.getzindex">GetZIndex</a>, <a href="/uwp/api/windows.ui.xaml.controls.canvas.setzindex">SetZIndex</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
