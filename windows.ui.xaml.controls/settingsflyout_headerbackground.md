---
-api-id: P:Windows.UI.Xaml.Controls.SettingsFlyout.HeaderBackground
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush HeaderBackground { get;  set; }
-->

# Windows.UI.Xaml.Controls.SettingsFlyout.HeaderBackground

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) that fills the background of the [SettingsFlyout](settingsflyout.md) header.

## -xaml-syntax
```xaml
<SettingsFlyout HeaderBackground="{StaticResource resourceName}"/>
- or -
<SettingsFlyout HeaderBackground="colorString"/>
- or -
<SettingsFlyout>
  <SettingsFlyout.HeaderBackgroundsingleBrush</SettingsFlyout.HeaderBackground>
</SettingsFlyout>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush that provides the background of the [SettingsFlyout](settingsflyout.md) header. The default is a null brush from a pure code perspective, but the default control template for [SettingsFlyout](settingsflyout.md) applies a theme resource brush (**SettingsFlyoutHeaderBackgroundThemeBrush**) for this in a runtime instance of a [SettingsFlyout](settingsflyout.md) control.

## -remarks

## -examples

## -see-also
[Use brushes](/windows/uwp/graphics/using-brushes)
