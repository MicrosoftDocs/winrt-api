---
-api-id: P:Windows.UI.Xaml.Media.Imaging.BitmapImage.UriSource
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri UriSource { get;  set; }
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage.UriSource

## -description
Gets or sets the Uniform Resource Identifier (URI) of the graphics source file that generated this [BitmapImage](bitmapimage.md).

## -xaml-syntax
```xaml
<BitmapImage UriSource="uri" />
```


## -property-value
An object describing the Uniform Resource Identifier (URI) of the graphics source file that generated this [BitmapImage](bitmapimage.md).

## -remarks
The [BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md) property might be useful for forming the URI if you're applying an image source file to a particular [Image](../windows.ui.xaml.controls/image.md) element.

In low memory situations (most likely on lower-memory phones), it is possible for an exception to be raised with the message "The image is unrecognized" and an HRESULT of 0x88982F60. While this exception ordinarily indicates bad data, if your app is close to its memory limit then the cause of the exception is likely to be low memory. In that case, we recommend that you free memory and try again.

## -examples

## -see-also
[Image and ImageBrush](http://msdn.microsoft.com/library/cea8780c-71a3-4168-a6e8-6361cdfb2faf), [XAML images sample](http://go.microsoft.com/fwlink/p/?linkid=238575)
