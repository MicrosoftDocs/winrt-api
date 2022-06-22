---
-api-id: P:Windows.UI.Xaml.Controls.RichTextBlock.Foreground
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush Foreground { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichTextBlock.Foreground

## -description
Gets or sets the [Brush](../windows.ui.xaml.media/brush.md) to apply to the text contents of the [RichTextBlock](richtextblock.md).



## -xaml-syntax
```xaml
<RichTextBlock Foreground="{StaticResource resourceName}"/>
- or -
<RichTextBlock Foreground="colorString"/>
- or -
<RichTextBlock>
  <RichTextBlock.Foreground>singleBrush</RichTextBlock.Foreground>
</RichTextBlock>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush used to apply to the text contents. The default is a null brush from a pure code perspective, but the default text styles set this to [Black](../windows.ui/colors_black.md) (for **Light** theme) or [White](../windows.ui/colors_white.md) (for **Dark** theme) for a [TextBlock](textblock.md) element in UI.

## -remarks
Set the Foreground property to specify the default brush to use for all text in the [RichTextBlock](richtextblock.md). You can override this value for specific text elements (such as a [Run](../windows.ui.xaml.documents/run.md)) in the [RichTextBlock](richtextblock.md) by setting the [TextElement.Foreground](../windows.ui.xaml.documents/textelement_foreground.md) property.

The default appearance of text and text styles depends heavily on the active theme and other settings. The theme and various styles and behaviors that are using default system settings or user preferences are the source of the effective runtime appearance of [RichTextBlock](richtextblock.md) foreground color of text as well as other text characteristics. You can change these defaults by changing the property values, or by applying a different style to specific [RichTextBlock](richtextblock.md) instances. You can change the foreground value for all default text by overriding the resource named **DefaultTextForegroundThemeBrush** in App.xaml.

## -examples

## -see-also
[TextElement.Foreground](../windows.ui.xaml.documents/textelement_foreground.md), [Use brushes](/windows/uwp/graphics/using-brushes)
