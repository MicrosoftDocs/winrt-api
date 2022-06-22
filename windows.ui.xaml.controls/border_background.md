---
-api-id: P:Windows.UI.Xaml.Controls.Border.Background
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Background { get;  set; }
-->

# Windows.UI.Xaml.Controls.Border.Background

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) that fills the background (inner area) of the border.



## -xaml-syntax
```xaml
<Border Background="{StaticResource resourceName}"/>
- or -
<Border Background="colorString"/>
- or -
<Border>
  <Border.Background>singleBrush</Border.Background>
</Border>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush that fills the background. The default is **null**, (a null brush) which is evaluated as [Transparent](../windows.ui/colors_transparent.md) for rendering.

## -remarks
The Background value for a [Border](border.md) is visible underneath the inner area if the element that is the [Child](border_child.md) element has transparency or null value brushes for any of its defining area. It is also visible between the border edge and the [Child](border_child.md) content if nonzero values are applied for a [Padding](border_padding.md) value.

## -examples
The following example shows how to set the background of a [Border](border.md) to a solid color using an inline-defined attribute value "Cyan". The XAML parser uses this "Cyan" value to refer to the named color [Colors.Cyan](../windows.ui/colors_cyan.md), and to create the [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) instance that supplies the runtime value.



[!code-xaml[BackgroundCorner](../windows.ui.xaml.controls/code/BorderSample2/csharp/Page.xaml#SnippetBackgroundCorner)]

## -see-also
[Child](border_child.md), [Use brushes](/windows/uwp/graphics/using-brushes)
