---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapControl.Heading
-api-type: winrt property
---

<!-- Property syntax
public double Heading { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.Heading

## -description
Gets or sets the directional heading of the map in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.

## -xaml-syntax
```xaml
<!-- xmlns:Maps="using:Windows.UI.Xaml.Controls.Maps" -->

<Maps:MapControl Heading="heading"/>
- or -
<Maps:MapControl>
    <Maps:MapControl.Heading>heading</Maps:MapControl.Heading>
</Maps:MapControl>

```


## -xaml-values
<dl><dt>heading</dt><dd>headingThe directional heading of the map in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</dd>
</dl>
## -property-value
The directional heading of the map in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.

## -remarks
Heading values greater than 360 degrees are normalized to their equivalent 0-360 degree value.

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
