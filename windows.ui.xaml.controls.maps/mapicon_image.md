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
The following stream formats are supported:
* PNG - a compressed PNG formatted stream
* JPG - a compressed JPG formatted stream
* SVG - a compressed SVG formatted stream
* BMP - an uncompressed BMP format stream
* Raw RGB bytes. The size of the image is assumed to be square. This is only valid for a stream with an integral square root length. 

## -property-value
The point of interest (POI) image for the [MapIcon](mapicon.md).

## -remarks
The following line of code displays the [MapIcon](mapicon.md) with a custom image saved in the Assets folder of the project.

`            MapIcon1.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/customicon.png"));`

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
