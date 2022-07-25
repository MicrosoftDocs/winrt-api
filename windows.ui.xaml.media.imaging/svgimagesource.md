---
-api-id: T:Windows.UI.Xaml.Media.Imaging.SvgImageSource
-api-type: winrt class
---

<!-- Class syntax.
public class SvgImageSource : ImageSource, ImageSource
-->

# Windows.UI.Xaml.Media.Imaging.SvgImageSource

## -description
Provides a source object for properties that use a Scalable Vector Graphics (SVG) source. You can define a SvgImageSource by using a Uniform Resource Identifier (URI) that references a SVG file, or by calling [SetSourceAsync(IRandomAccessStream)](svgimagesource_setsourceasync_1118221574.md) and supplying a stream.



## -remarks
SvgImageSource lets you use a SVG source to be displayed using an [ImageBrush](../windows.ui.xaml.media/imagebrush.md) or directly in an [Image](../windows.ui.xaml.controls/image.md) control. SvgImageSource supports secure static mode from the SVG specification and does not support animations or interactions. 
The Direct2D API supplies the underlying SVG rendering support and for more info on specific SVG element and attribute support, see [SVG Support](/windows/desktop/Direct2D/svg-support). For more info on formats and how to use Uniform Resource Identifier (URI) to access image source files that come from app resources, see [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes).

The SvgImageSource represents an abstraction so that a SVG source can be set asynchronously but still be referenced in XAML markup as a property value, or in code as an object that doesn't use awaitable syntax. When you create a SvgImageSource
object in code, it initially has no valid source. You should then set its source using one of these techniques:

* Use the [SvgImageSource(Uri)](svgimagesource_svgimagesource_843413386.md) constructor rather than the default constructor. Although it's a constructor, you can think of this as having an implicit asynchronous behavior: the SvgImageSource
won't be ready for use until it raises an [Opened](svgimagesource_opened.md) event that indicates a successful async source set operation.
* Set the [UriSource](svgimagesource_urisource.md) property. As with the **Uri** constructor, this action is implicitly asynchronous, and the SvgImageSource won't be ready for use until it raises an [Opened](svgimagesource_opened.md) event.
* Use [SetSourceAsync(IRandomAccessStream)](svgimagesource_setsourceasync_1118221574.md). This method is explicitly asynchronous. The properties where you might use a SvgImageSource, such as [Source](/uwp/api/windows.ui.xaml.controls.image.Source), are designed for this asynchronous behavior, and won't throw exceptions if they are set using a SvgImageSource that doesn't have a complete source yet. Rather than handling exceptions, you should handle [Opened](svgimagesource_opened.md) or [OpenFailed](svgimagesource_openfailed.md) events either on the SvgImageSource directly or on the control that uses the source (if those events are available on the control class).

[Opened](svgimagesource_opened.md) and [OpenFailed](svgimagesource_openfailed.md) are mutually exclusive. One event or the other will always be raised whenever a SvgImageSource
object has its source value set or reset.

### Sizing
Depending on your intended use case, you can specify the size of a SvgImageSource in several different ways:

* Use the [RasterizePixelHeight](svgimagesource_rasterizepixelheight.md) and [RasterizePixelWidth](svgimagesource_rasterizepixelwidth.md) properties to specify an explicit height and width in logical pixels to decode the SVG source at.
* If you don't specify a [RasterizePixelHeight](svgimagesource_rasterizepixelheight.md) or [RasterizePixelWidth](svgimagesource_rasterizepixelwidth.md), then the application's layout will dictate the decode size while still preserving aspect ratio. If no size can be determined from the application's layout, then the SVG source will be decoded to the maximum window size.

### Version compatibility
The SvgImageSource class is not available prior to Windows 10, version 1703. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you 
will not be able to use SvgImageSource. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this class before you use it.


## -examples

Here's an example of how to set the source of an [Image](../windows.ui.xaml.controls/image.md) to a SVG file. Since there is no height or width explicitly specified, the application layout will dictate the appropriate size for the SVG to decode at.

```xaml
<Image Source="Assets/mysvg.svg"/>
```

