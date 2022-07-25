---
-api-id: P:Windows.UI.Xaml.Documents.TextElement.Foreground
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Foreground { get;  set; }
-->

# Windows.UI.Xaml.Documents.TextElement.Foreground

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) to apply to the content in this element.



## -xaml-syntax
```xaml
<textElementForeground="{StaticResource resourceName}"/>
- or -
<textElementForeground="colorString"/>
- or -
<textElement>
  <textElement.Foreground>singleBrush</textElement.Foreground>
</textElement>
```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush that is applied to the text content. The default is a [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) with [Color](../windows.ui.xaml.media/solidcolorbrush_color.md) value [Black](../windows.ui/colors_black.md).

## -remarks
Setting Foreground has no visible effect for [LineBreak](linebreak.md) or [InlineUIContainer](inlineuicontainer.md) objects.

## -examples

## -see-also
[Quickstart: Displaying text](/previous-versions/windows/apps/hh700392(v=win.10)), [Use brushes](/windows/uwp/graphics/using-brushes)
