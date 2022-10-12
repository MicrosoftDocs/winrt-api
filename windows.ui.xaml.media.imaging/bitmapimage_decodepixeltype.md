---
-api-id: P:Windows.UI.Xaml.Media.Imaging.BitmapImage.DecodePixelType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Imaging.DecodePixelType DecodePixelType { get;  set; }
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage.DecodePixelType

## -description
Gets or sets a value that determines how [DecodePixelWidth](bitmapimage_decodepixelwidth.md) and [DecodePixelHeight](bitmapimage_decodepixelheight.md) values are interpreted for decoding operations.



## -property-value
A value of the enumeration. The default is **Physical**.

## -remarks
DecodePixelType can be set to **Logical** or **Physical**. The default value is **Physical**. If DecodePixelType is not set, or set to **Physical**, the image is decoded using [DecodePixelWidth](bitmapimage_decodepixelwidth.md) and [DecodePixelHeight](bitmapimage_decodepixelheight.md) values that represent physical pixels, and the decode operation uses these values directly. If DecodePixelType is set to **Logical**, the image is decoded using [DecodePixelWidth](bitmapimage_decodepixelwidth.md) and [DecodePixelHeight](bitmapimage_decodepixelheight.md) values that represent logical pixels. Internal logic converts the decode width and height based on device resolution info and how logical and physical pixels are factored on the target device.

[Width](../windows.ui.xaml/frameworkelement_width.md) and [Height](../windows.ui.xaml/frameworkelement_height.md) for the [Image](../windows.ui.xaml.controls/image.md) element are specified in logical pixels once the image is rendered, but those logical pixels are influenced by the device resolution. For the [BitmapImage](bitmapimage.md) element that represents the image file source, [DecodePixelWidth](bitmapimage_decodepixelwidth.md) and [DecodePixelHeight](bitmapimage_decodepixelheight.md) are specified in physical pixels, by default. The physical pixel values for provided for the decode operation influences the size of the bitmap that's created in memory. By specifying DecodePixelType as **Logical**, the image is decoded using values that are pre-factored for the logical resolution, and it potentially won't use as much memory. For more info on device resolution and image sources, see [Effective pixels and scaling](/windows/apps/design/basics).

## -examples

## -see-also
