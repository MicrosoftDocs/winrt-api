---
-api-id: P:Windows.UI.Xaml.Shapes.Shape.Stroke
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Stroke { get;  set; }
-->

# Windows.UI.Xaml.Shapes.Shape.Stroke

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) that specifies how the [Shape](shape.md) outline is painted.



## -xaml-syntax

```xaml
<shape Stroke="{StaticResource resourceName}"/>
- or -
<shape Stroke="colorString"/>
- or -
<shape>
  <shape.Stroke>singleBrush</shape.Stroke>
</shape>
```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
A [Brush](../windows.ui.xaml.media/brush.md) that specifies how the [Shape](shape.md) outline is painted. The default is null.

## -remarks

## -examples

## -see-also
[Fill](shape_fill.md), [Use brushes](/windows/uwp/graphics/using-brushes)
