---
-api-id: P:Windows.UI.Xaml.Controls.PasswordBox.SelectionHighlightColor
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.SolidColorBrush SelectionHighlightColor { get;  set; }
-->

# Windows.UI.Xaml.Controls.PasswordBox.SelectionHighlightColor

## -description
Gets or sets the brush used to highlight the selected text.



## -xaml-syntax
```xaml
<PasswordBox SelectionHighlightColor="{StaticResource resourceName}"/>
- or -
<PasswordBox SelectionHighlightColor="colorString"/>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
</dl>
## -property-value
The brush used to highlight the selected text. The default is a null brush from a pure code perspective, but the default control template for [PasswordBox](passwordbox.md) applies a theme resource brush for this in a runtime instance of a [PasswordBox](passwordbox.md) control.

## -remarks
The control template sets the default selection highlight color to the system resource **TextSelectionHighlightColorThemeBrush**. To change the selection highlight color for all editable text controls in your app, you can override the **TextSelectionHighlightColorThemeBrush** system resource in App.xaml. This will affect [PasswordBox](passwordbox.md), [TextBox](textbox.md), and [RichEditBox](richeditbox.md) controls. For more info, see [XAML theme resources](/windows/apps/design/style/xaml-theme-resources).

## -examples

## -see-also
[Use brushes](/windows/uwp/graphics/using-brushes)
