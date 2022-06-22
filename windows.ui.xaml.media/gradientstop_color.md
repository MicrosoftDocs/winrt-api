---
-api-id: P:Windows.UI.Xaml.Media.GradientStop.Color
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Color Color { get;  set; }
-->

# Windows.UI.Xaml.Media.GradientStop.Color

## -description
Gets or sets the color of the gradient stop.



## -xaml-syntax
```xaml
<GradientStop Color="colorString" .../>
```


## -xaml-values
<dl><dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. For more information, see the XAML Attribute Usage in Color.</dd>
</dl>
## -property-value
The color of the gradient stop. The default is [Transparent](../windows.ui/colors_transparent.md).

## -remarks

## -examples
This example creates a [LinearGradientBrush](lineargradientbrush.md) with four gradient stops in the implicit [GradientStopCollection](gradientstopcollection.md), which is used to paint a **Rectangle**.



[!code-xaml[Gradient1](../windows.ui.xaml.media/code/Gradients/csharp/Page.xaml#SnippetGradient1)]

## -see-also
