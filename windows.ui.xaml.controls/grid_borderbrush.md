---
-api-id: P:Windows.UI.Xaml.Controls.Grid.BorderBrush
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush BorderBrush { get;  set; }
-->

# Windows.UI.Xaml.Controls.Grid.BorderBrush

## -description
Gets or sets a brush that describes the border fill of the panel.



## -xaml-syntax
```xaml
<Grid BorderBrush="{StaticResource resourceName}"/>
- or -
<Grid BorderBrush="colorString"/>
- or -
<Grid>
  <Grid.BorderBrush>singleBrush</Grid.BorderBrush>
</Grid>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
The brush that is used to fill the panel's border. The default is **null**, (a null brush) which is evaluated as [Transparent](../windows.ui/colors_transparent.md) for rendering.

## -remarks
The [BorderThickness](grid_borderthickness.md) value must be greater than 0 in order to see the BorderBrush value take effect.

## -examples

## -see-also
