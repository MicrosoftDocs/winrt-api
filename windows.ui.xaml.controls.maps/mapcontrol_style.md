---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapControl.Style
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Maps.MapStyle Style { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.Style

## -description
Specifies the style of the map - for example, a road map or an aerial map.

## -xaml-syntax
```xaml
<!-- xmlns:Maps="using:Windows.UI.Xaml.Controls.Maps" -->

<Maps:MapControl Style="style" />
- or -
<Maps:MapControl>
    <Maps:MapControl.Style>style</Maps:MapControl.Style>
</Maps:MapControl>

```


## -xaml-values
<dl><dt>style</dt><dd>styleA value from the MapStyle enumeration that specifies the style of the map - for example, a road map or an aerial map.</dd>
</dl>
## -property-value
The style of the map - for example, a road map or an aerial map.

## -remarks
> [!IMPORTANT]
> Aerial styles are not available when the network is disconnected from the internet.

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
