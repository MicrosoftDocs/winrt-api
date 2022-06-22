---
-api-id: P:Windows.UI.Xaml.Controls.Border.BorderBrush
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush BorderBrush { get;  set; }
-->

# Windows.UI.Xaml.Controls.Border.BorderBrush

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) that is applied to the edge area of the [Border](border.md).



## -xaml-syntax
```xaml
<Border BorderBrush="{StaticResource resourceName}"/>
- or -
<Border BorderBrush="colorString"/>
- or -
<Border>
  <Border.BorderBrush>singleBrush</Border.BorderBrush>
</Border>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush that fills the border. The default is **null**, (a null brush) which is evaluated as [Transparent](../windows.ui/colors_transparent.md) for rendering.

## -remarks
The [BorderThickness](border_borderthickness.md) value must be greater than 0 in order to see the BorderBrush value take effect.

## -examples
This example shows how to set the BorderBrush value to a solid color using an inline-defined attribute value "Blue". The XAML parser uses this "Blue" value to refer to the named color [Colors.Blue](../windows.ui/colors_blue.md), and to create the [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) instance that supplies the runtime value.



[!code-xaml[BorderContainer](../windows.ui.xaml.controls/code/BorderSample2/csharp/Page.xaml#SnippetBorderContainer)]

## -see-also
[Use brushes](/windows/uwp/graphics/using-brushes)
