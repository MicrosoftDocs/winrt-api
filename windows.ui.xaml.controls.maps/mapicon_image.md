---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapIcon.Image
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IRandomAccessStreamReference Image { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapIcon.Image

## -description
Gets or sets the image for the [MapIcon](mapicon.md). Provide an optional custom image to replace the default point of interest (POI) image.

## -property-value
The point of interest (POI) image for the [MapIcon](mapicon.md).

## -remarks
The following line of code displays the [MapIcon](mapicon.md) with a custom image saved in the Assets folder of the project.

`            MapIcon1.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/customicon.png"));`

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](http://msdn.microsoft.com/library/3839e00b-2c1e-4627-a45f-6dda98d7077f)
