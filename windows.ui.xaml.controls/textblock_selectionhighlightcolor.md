---
-api-id: P:Windows.UI.Xaml.Controls.TextBlock.SelectionHighlightColor
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax
public Windows.UI.Xaml.Media.SolidColorBrush SelectionHighlightColor { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBlock.SelectionHighlightColor

## -description

Gets or sets the brush used to highlight the selected text.



## -xaml-syntax

```xaml
<TextBlock SelectionHighlightColor="{StaticResource resourceName}"/>
- or -
<TextBlock SelectionHighlightColor="colorString"/>

```

## -xaml-values

<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
</dl>
## -property-value
The brush used to highlight the selected text. The default is a null brush from a pure code perspective, but the system uses base text styles to supply a runtime value for apps (unless you specifically override that style). The practical default is a brush using the theme resource **TextSelectionHighlightThemeColor**.

## -remarks

> [!IMPORTANT]
> If using a keyboard for text selection within a TextBlock, the user must first activate *Caret Browsing* (with the app in the foreground, press F7).

## -examples

## -see-also

[Use brushes](/windows/uwp/graphics/using-brushes)
