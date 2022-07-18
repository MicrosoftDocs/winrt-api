---
-api-id: P:Windows.UI.Xaml.Controls.Control.Background
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Background { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.Background

## -description
Gets or sets a brush that provides the background of the control.



## -xaml-syntax
```xaml
<control Background="{StaticResource resourceName}"/>
- or -
<control Background="colorString"/>
- or -
<control>
  <control.Background>singleBrush</control.Background>
</control>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush that provides the background of the control. The default is **null**, (a null brush) which is evaluated as [Transparent](../windows.ui/colors_transparent.md) for rendering.

## -remarks
Each control might apply this property differently based on its visual template. This property only affects a control whose template uses the Background property as an input for the template's UI properties. On other controls, this property has no effect. Typically, a control uses a [{TemplateBinding} markup extension](/windows/uwp/xaml-platform/templatebinding-markup-extension) to bind its Background value to the [Background](panel_background.md) of a [Panel](panel.md) that is the root element of the control template; for example, to `Grid.Background`. For more info about visual templates and control templating, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls) or the reference page for the [Template](control_template.md) property.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as Background, [Foreground](control_foreground.md), and [BorderBrush](control_borderbrush.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -examples

## -see-also
[Use brushes](/windows/uwp/graphics/using-brushes), [Control.BorderBrush](control_borderbrush.md), [Panel.Background](panel_background.md)
