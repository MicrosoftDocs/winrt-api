---
-api-id: P:Windows.UI.Xaml.Controls.SwipeItem.Foreground
-api-type: winrt property
---

<!-- Property syntax.
public Brush Foreground { get;  set; }
-->

# Windows.UI.Xaml.Controls.SwipeItem.Foreground

## -description

Gets or sets the brush that paints the text and icon of the item.

## -xaml-syntax

```xaml
<SwipeItem Foreground="{StaticResource resourceName}"/>
- or -
<SwipeItem Foreground="colorString"/>
```

## -xaml-values

<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
</dl>

## -property-value

The brush that paints the text and icon of the item.

## -remarks

## -see-also

## -examples

