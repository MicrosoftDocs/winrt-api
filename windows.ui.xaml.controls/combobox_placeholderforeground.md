---
-api-id: P:Windows.UI.Xaml.Controls.ComboBox.PlaceholderForeground
-api-type: winrt property
---

<!-- Property syntax.
public Brush PlaceholderForeground { get;  set; }
-->

# Windows.UI.Xaml.Controls.ComboBox.PlaceholderForeground

## -description

Gets or sets a brush that describes the color of placeholder text.



## -xaml-syntax

```xaml
<ComboBox PlaceholderForeground="{StaticResource resourceName}" .../>
- or -
<ComboBox PlaceholderForeground="colorString" .../>
```

## -xaml-values

<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
</dl>

## -property-value

The brush that describes the color of placeholder text.

## -remarks

## -see-also

## -examples

