---
-api-id: P:Windows.UI.Xaml.Controls.ContentPresenter.Background
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Background { get;  set; }
-->

# Windows.UI.Xaml.Controls.ContentPresenter.Background

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) to apply to the background of content handled by the [ContentPresenter](contentpresenter.md).



## -xaml-syntax
```xaml
<ContentPresenter Background="{StaticResource resourceName}"/>
- or -
<ContentPresenter Background="colorString"/>
- or -
<ContentPresenter>
  <ContentPresenter.Background>singleBrush</ContentPresenter.Background>
</ContentPresenter>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush used as the background brush for the contents. The default is a null brush from a pure code perspective, but system style defaults set this to [White](../windows.ui/colors_white.md) (for **Light** theme) or [Black](../windows.ui/colors_black.md) (for **Dark** theme).

## -remarks

## -examples

## -see-also
