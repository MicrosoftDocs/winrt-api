---
-api-id: P:Windows.UI.Xaml.Documents.Glyphs.Fill
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Fill { get;  set; }
-->

# Windows.UI.Xaml.Documents.Glyphs.Fill

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) that is used to render the glyphs.



## -xaml-syntax
```xaml
<Glyphs Fill="{StaticResource resourceName"/>
- or -
<Glyphs Fill="colorString"/>
- or -
<Glyphs>
  <Glyphs.Fill>singleBrush</Glyphs.Fill>
</Glyphs>
```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush to use to render the glyphs. The default is **null**, which is evaluated as [Transparent](../windows.ui/colors_transparent.md) for rendering.

## -remarks
Because the default is **null**, you almost always should define a value for Fill somehow if you want your [Glyphs](glyphs.md) to render in UI.

## -examples

## -see-also
[Use brushes](/windows/uwp/graphics/using-brushes)
