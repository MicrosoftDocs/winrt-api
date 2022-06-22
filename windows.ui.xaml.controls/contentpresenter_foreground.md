---
-api-id: P:Windows.UI.Xaml.Controls.ContentPresenter.Foreground
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Foreground { get;  set; }
-->

# Windows.UI.Xaml.Controls.ContentPresenter.Foreground

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) to apply to the text content handled by the [ContentPresenter](contentpresenter.md).



## -xaml-syntax
```xaml
<ContentPresenter Foreground="{StaticResource resourceName}"/>
- or -
<ContentPresenter Foreground="colorString"/>
- or -
<ContentPresenter>
  <ContentPresenter.Foreground>singleBrush</ContentPresenter.Foreground>
</ContentPresenter>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush used as the foreground brush for the text contents. The default is a null brush from a pure code perspective, but system style defaults set this to [Black](../windows.ui/colors_black.md) (for **Light** theme) or [White](../windows.ui/colors_white.md) (for **Dark** theme).

## -remarks

## -examples

## -see-also
[Use brushes](/windows/uwp/graphics/using-brushes)
