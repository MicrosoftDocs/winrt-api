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

### Notes for previous versions

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 464216-->
> **Windows 8**

Windows 8 had URI validation logic associated with this property's setter. Starting with Windows 8.1 that validation on the property setter is removed. That doesn't mean you get no validation, it means that you get the same final validation you should be using anyway: handling for **ImageOpened** or **ImageFailed** events on the [Image](../windows.ui.xaml.controls/image.md) where the source is applied.

Apps that were compiled for Windows 8 but running on Windows 8.1 use the new Windows 8.1 behavior.

## -examples

## -see-also
[Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes), [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample)
