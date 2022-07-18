---
-api-id: P:Windows.UI.Xaml.Controls.Control.Foreground
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Foreground { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.Foreground

## -description
Gets or sets a brush that describes the foreground color.



## -xaml-syntax
```xaml
<control Foreground="{StaticResource resourceName}"/>
- or -
<control Foreground="colorString"/>
- or -
<control>
  <control.Foreground>singleBrush</control.Foreground>
</control>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush that paints the foreground of the control. The default value is a [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) with color of [Black](../windows.ui/colors_black.md).

## -remarks
Each control might apply this property differently based on its visual template. This property only affects a control whose template uses the Foreground property as a parameter. On other controls, this property has no effect. Typically, a [ContentControl](contentcontrol.md) derived control uses a [{TemplateBinding} markup extension](/windows/uwp/xaml-platform/templatebinding-markup-extension) to bind its Foreground value to the [Foreground](contentpresenter_foreground.md) of a [ContentPresenter](contentpresenter.md) within the control template. The same color/brush might also be used for values of other decorative elements in the template (glyphs, icons, control surfaces) or to composite part properties such as the individual [ComboBox](combobox.md) elements of the [TimePicker](timepicker.md) control. For more info about visual templates and control templating, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) or the reference page for the [Template](control_template.md) property.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md), Foreground, and [BorderBrush](control_borderbrush.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -examples

## -see-also
[Use brushes](/windows/uwp/graphics/using-brushes)
