---
-api-id: P:Windows.UI.Xaml.Shapes.Shape.Fill
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Fill { get;  set; }
-->

# Windows.UI.Xaml.Shapes.Shape.Fill

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) that paints the interior area of the shape.



## -xaml-syntax
```xaml
<shape Fill="{StaticResource resourceName}"/>
- or -
<shape Fill="colorString"/>
- or -
<shape>
  <shape.Fill>singleBrush</shape.Fill>
</shape>
```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
A [Brush](../windows.ui.xaml.media/brush.md) that paints/fills the shape interior. The default is **null**, (a null brush) which is evaluated as [Transparent](../windows.ui/colors_transparent.md) for rendering.
<!--See Remarks.-->

## -remarks

## -examples

## -see-also
[Stroke](shape_stroke.md), [Use brushes](/windows/uwp/graphics/using-brushes)
