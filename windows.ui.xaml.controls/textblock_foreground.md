---
-api-id: P:Windows.UI.Xaml.Controls.TextBlock.Foreground
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Foreground { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBlock.Foreground

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) to apply to the text contents of the [TextBlock](textblock.md).



## -xaml-syntax
```xaml
<TextBlock Foreground="{StaticResource resourceName}"/>
- or -
<TextBlock Foreground="colorString"/>
- or -
<TextBlock>
  <TextBlock.Foreground>singleBrush</TextBlock.Foreground>
</TextBlock>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush used to apply to the text content. The default is a null brush from a pure code perspective, but the default text styles set this to [Black](../windows.ui/colors_black.md) (for **Light** theme) or [White](../windows.ui/colors_white.md) (for **Dark** theme) for a [TextBlock](textblock.md) element in UI.

## -remarks
[TextBlock](textblock.md) isn't a control so you don't use templates to change its appearance. Instead you can use styles. It's more common (and a better practice) to use named styles for [TextBlock](textblock.md) appearance than it is to set inline attributes for each [TextBlock](textblock.md) instance, particularly if you are using common values in many elements. For more info on styles, see [Quickstart: Styling controls](/previous-versions/windows/apps/hh465498(v=win.10)).


The default appearance of text and text styles depends heavily on the active theme and other settings. The theme and various styles and behaviors that are using default system settings or user preferences are the source of the effective runtime appearance of [TextBlock](textblock.md) foreground color of text as well as other text characteristics. You can change these defaults by changing the property values, or by applying a different style to specific [TextBlock](textblock.md) instances. You can change the foreground value for all default text by overriding the resource named **DefaultTextForegroundThemeBrush** in App.xaml.

## -examples
The following XAML example shows how to set the Foreground property to a solid color using an inline-defined attribute value "Maroon". The XAML parser uses this "Maroon" value to refer to the named color [Colors.Maroon](../windows.ui/colors_maroon.md), and to create the [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) instance that supplies the runtime value.

```xaml
<TextBlock
  FontSize="32"
  FontWeight="Bold"
  Foreground="Maroon">
  Maroon
</TextBlock>
```



## -see-also
[Quickstart: Displaying text](/previous-versions/windows/apps/hh700392(v=win.10)), [Use brushes](/windows/uwp/graphics/using-brushes)
