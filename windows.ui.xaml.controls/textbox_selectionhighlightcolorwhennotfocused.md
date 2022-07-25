---
-api-id: P:Windows.UI.Xaml.Controls.TextBox.SelectionHighlightColorWhenNotFocused
-api-type: winrt property
---

<!-- Property syntax.
public SolidColorBrush SelectionHighlightColorWhenNotFocused { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBox.SelectionHighlightColorWhenNotFocused

## -description
Gets or sets the brush used to highlight the selected text when the TextBox does not have focus.



## -xaml-syntax
```xaml
<TextBox SelectionHighlightColorWhenNotFocused="{StaticResource resourceName}"/>
- or -
<TextBox SelectionHighlightColorWhenNotFocused="colorString"/>

```

## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
</dl>

## -property-value
The brush used to highlight the selected text when [TextBox](textbox.md) loses focus. The default is a null brush from a pure code perspective, but the default control template for [TextBox](textbox.md) applies a Transparent brush for this in a runtime instance of a [TextBox](textbox.md) control. To disable the SelectionHighlightColorWhenNotFocused, set the brush to Transparent once again.

## -remarks

## -see-also
[SelectionHighlightColor](textbox_selectionhighlightcolor.md)

## -examples


