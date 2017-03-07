---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapBillboard.Image
-api-type: winrt property
---

<!-- Property syntax.
public IRandomAccessStreamReference Image { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapBillboard.Image

## -description
Gets or sets the image for the [MapBillboard](mapbillboard.md). Provide an optional custom image to replace the default point of interest (POI) image.

## -property-value
The point of interest (POI) image for the [MapBillboard](mapbillboard.md).

## -remarks
The following line of code displays the [MapBillboard](mapbillboard.md) with a custom image saved in the Assets folder of the project.
```csharp
MapBillboard1.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/customicon.png"));
```

## -see-also

## -examples
