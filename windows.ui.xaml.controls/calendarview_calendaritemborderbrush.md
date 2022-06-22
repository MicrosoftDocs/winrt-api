---
-api-id: P:Windows.UI.Xaml.Controls.CalendarView.CalendarItemBorderBrush
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush CalendarItemBorderBrush { get;  set; }
-->

# Windows.UI.Xaml.Controls.CalendarView.CalendarItemBorderBrush

## -description
Gets or sets a brush that provides the border of a calendar item.



## -xaml-syntax
```xaml
<CalendarView CalendarItemBorderBrush="{StaticResource resourceName}"/>
- or -
<CalendarView CalendarItemBorderBrush="colorString"/>
- or -
<CalendarView>
  CalendarView.CalendarItemBorderBrush>singleBrush</CalendarView.CalendarItemBorderBrush>
</CalendarView>

```


## -xaml-values
<dl><dt>resourceName</dt><dd>resourceNameThe resource name (x:Key attribute value) of an existing XAML resource that defines a brush. This is the recommended way to specify Brush values in XAML if you have any intention of using the same colors or brushes in more than one part of your UI. See Remarks in Brush or ResourceDictionary and XAML resource references.</dd>
<dt>colorString</dt><dd>colorStringThe Color for a SolidColorBrush expressed as an attribute string. This can be a named color, an RGB value, or an ScRGB value. RGB or ScRGB may also specify alpha information. See the XAML Values section in Color.</dd>
<dt>singleBrush</dt><dd>singleBrushWithin opening and closing property elements, exactly one object element for an object that derives from Brush. This is typically one of the following classes: LinearGradientBrush, ImageBrush, SolidColorBrush.</dd>
</dl>
## -property-value
A brush that provides the border of a calendar item.

## -remarks

## -examples

## -see-also
