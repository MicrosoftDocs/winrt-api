---
-api-id: T:Windows.UI.Xaml.Controls.Image
-api-type: winrt class
---

<!-- Class syntax.
public class Image : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IImage, Windows.UI.Xaml.Controls.IImage2, Windows.UI.Xaml.Controls.IImage3
-->

# Windows.UI.Xaml.Controls.Image

## -description

Represents a control that displays an image. The image source is specified by referring to an image file, using several supported formats. The image source can also be set with a stream. See Remarks for the list of supported image source formats.


## -xaml-syntax

```xaml
<Image .../>
```

## -remarks

### Image file formats

An Image can display these image file formats:

+ Joint Photographic Experts Group (JPEG)
+ Portable Network Graphics (PNG)
+ bitmap (BMP)
+ Graphics Interchange Format (GIF)
+ Tagged Image File Format (TIFF)
+ JPEG XR
+ icons (ICO)
+ Scalable Vector Graphics (SVG)

> [!NOTE]
> Icon files supported on Windows only. Not supported on Windows Phone 8.1

Starting in Windows 10, version 1607, the Image element supports animated Graphics Interchange Format (GIF) images. When you use a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) as the image [Source](image_source.md), you can access [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md)  API to control playback of the animated Graphics Interchange Format (GIF) image. For more info, see the Remarks on the [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) class page.

> [!NOTE]
> Animated Graphics Interchange Format (GIF) support is available when your app is compiled for Windows 10, version 1607 and running on version 1607 (or later). When your app is compiled for or runs on previous versions, the first frame of the Graphics Interchange Format (GIF) is shown, but it is not animated.

Starting in Windows 10, version 1703, the Image element supports static Scalable Vector Graphics (SVG) images through [SvgImageSource](../windows.ui.xaml.media.imaging/svgimagesource.md). **SvgImageSource** supports secure static mode from the SVG specification and does not support animations or interactions. 
Direct2D supplies the underlying SVG rendering support and for more info on specific SVG element and attribute support, see [SVG Support](/windows/desktop/Direct2D/svg-support). To learn more about how to insert a SVG in your app, visit the [SvgImageSource](../windows.ui.xaml.media.imaging/svgimagesource.md) class page.

> [!NOTE]
> Scalable Vector Graphics (SVG) support is available when your app is compiled for Windows 10, version 1703 and running on version 1703 (or later). When your app is compiled for or runs on previous versions, the SVG image will not be shown.

### Setting Image.Source

To set the image source file that an Image displays, you set its [Source](image_source.md) property, either in XAML or in code. Here's a simple example of setting [Source](image_source.md) in XAML:

```xaml
<Image Width="200" Source="Images/myimage.png"/>
```

This usage is setting [Source](image_source.md) by Uniform Resource Identifier (URI), which is a shortcut that's enabled by XAML. Note that the Uniform Resource Identifier (URI) here appears to be a relative Uniform Resource Identifier (URI); supporting partial Uniform Resource Identifier (URI) is another XAML shortcut. The root of this Uniform Resource Identifier (URI) is the base folder for an app project. This is usually the same location that the XAML file containing the Image tag is loaded from. In this example, the image source file is in an Images subfolder within the app's file structure.

Setting the [Source](image_source.md) property is inherently an asynchronous action. Because it's a property, there isn't an awaitable syntax, but for most scenarios you don't need to interact with the asynchronous aspects of image loading. The framework will wait for the image source to be returned, and will start a layout cycle when the image source file is available and decoded.

Setting the source to a Uniform Resource Identifier (URI) value that can't be resolved to a valid image source file doesn't throw an exception. Instead, it fires an [ImageFailed](image_imagefailed.md) event. You can write an [ImageFailed](image_imagefailed.md) handler and attach it to the Image object, and possibly use the [ErrorMessage](../windows.ui.xaml/exceptionroutedeventargs_errormessage.md) in event data to determine the nature of the failure. An error in decoding can also fire [ImageFailed](image_imagefailed.md). If you want to verify that an image source file was loaded correctly, you can handle the [ImageOpened](image_imageopened.md) event on the Image element.

You typically use image source files that you have included as part of your app download package. For large files, there might be a very small delay while the image source file is decoded, if this is the first time the source is used. For more info on app resources and how to package image source files in an app package, see [Defining app resources](/previous-versions/windows/apps/hh965321(v=win.10)).

You can also use image source files that aren't part of the app, for example images from external servers. These images are downloaded by an internal HTTP request, and then decoded. If the image source file is a large file, or if there are connection issues, there might be a delay before an external image can be displayed in an Image element.

### Setting Image.Source using code

If you create an Image object using code, call the default constructor, then set the [Image.Source](image_source.md) property. Setting the [Image.Source](image_source.md) property requires an instance of the [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) class, which you also must construct. If your image source is a file referenced by Uniform Resource Identifier (URI), use the [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage_bitmapimage_843413386.md) constructor that takes a Uniform Resource Identifier (URI) parameter. When you reference local content, you must include the **ms-appx:** scheme in the absolute Uniform Resource Identifier (URI) that you use as the [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage_bitmapimage_843413386.md) constructor parameter. In code, you don't get the processing shortcuts for combining relative Uniform Resource Identifier (URI) parts and the **ms-appx:** scheme that happens automatically if you specify [Source](image_source.md) as a XAML attribute. Instead you must explicitly construct an absolute Uniform Resource Identifier (URI) with the appropriate scheme. You typically use the **ms-appx:** scheme for an image file that's packaged as part of your app.

> [!TIP]
> If you're using C# or Microsoft Visual Basic, you can get the [BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md) property of the Image, and pass that as the *baseUri* parameter for [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true) constructors that combine a Uniform Resource Identifier (URI) base location and a relative path within that location.

Here's an example of setting [Image.Source](image_source.md) in C#. In this example, the Image object was created in XAML but doesn't have a source or any other property values; instead these values are provided at run-time when the Image is loaded from XAML.

```csharp
void Image_Loaded(object sender, RoutedEventArgs e)
{
    Image img = sender as Image; 
    BitmapImage bitmapImage = new BitmapImage();
    img.Width = bitmapImage.DecodePixelWidth = 80; //natural px width of image source
    // don't need to set Height, system maintains aspect ratio, and calculates the other
    // dimension, so long as one dimension measurement is provided
    bitmapImage.UriSource = new Uri(img.BaseUri,"Assets/StoreLogo.png");
    img.Source = bitmapImage;
}
```

### Using a stream source for an Image source

If your image source is a stream, you must write code that sets your Image instance to use the stream. This can't be done in XAML alone. Construct the Image to use, or reference an existing Image instance (which might have been defined in XAML markup, but without a source). Then use the async [SetSourceAsync](../windows.ui.xaml.media.imaging/bitmapsource_setsourceasync_1118221574.md) method of [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) to define the image information from a stream, passing the stream to use as the *streamSource* parameter. Using a stream for an image source is fairly common. For example, if your app enables a user to choose an image file using a [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) control, the object you get that represents the file the user chose can be opened as a stream, but doesn't provide a Uniform Resource Identifier (URI) reference to the file.

In this example, the code is already awaitable because it's waiting for the user to choose a file and it only runs after that happens. The stream to use comes from [StorageFile.OpenAsync](../windows.storage/storagefile_openasync_1542217918.md) after a [StorageFile](../windows.storage/storagefile.md) instance is returned from the async picker actions.

```csharp
FileOpenPicker open = new FileOpenPicker(); 
// Open a stream for the selected file 
StorageFile file = await open.PickSingleFileAsync(); 
// Ensure a file was selected 
if (file != null) 
{ 
    using (IRandomAccessStream fileStream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read)) 
    { 
        // Set the image source to the selected bitmap 
         BitmapImage bitmapImage = new BitmapImage(); 
         bitmapImage.DecodePixelWidth = 600; //match the target Image.Width, not shown
         await bitmapImage.SetSourceAsync(fileStream); 
         Scenario2Image.Source = bitmapImage; 
    } 
}
```

> [!TIP]
> If you're using C# or Microsoft Visual Basic, streams can use the [System.IO.Stream](/dotnet/api/system.io.stream?view=dotnet-uwp-10.0&preserve-view=true) type that you may be familiar with from previous Microsoft .NET programming experience. You can call the [AsStream](XREF:TODO:M:System.IO.WindowsRuntimeStreamExtensions.AsStream(Windows.Storage.Streams.IRandomAccessStream)) extension method as an instance method on any object of type [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) that you've obtained from a Windows Runtime  API. The previous example used [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) for parameter passing and didn't need to use [AsStream](XREF:TODO:M:System.IO.WindowsRuntimeStreamExtensions.AsStream(Windows.Storage.Streams.IRandomAccessStream)). But if you ever need to manipulate the stream, [AsStream](XREF:TODO:M:System.IO.WindowsRuntimeStreamExtensions.AsStream(Windows.Storage.Streams.IRandomAccessStream)) is there as a utility to convert to a [System.IO.Stream](/dotnet/api/system.io.stream?view=dotnet-uwp-10.0&preserve-view=true) if you need it.

See [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample) for more example code.

### Image files and performance

Large image files can impact performance because they load into memory. If you are referencing an image file where you know that the source file is a large, high resolution image, but your app is displaying it in a UI region that's smaller than the image's natural size, you should set the [DecodePixelWidth](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelwidth.md) property, or [DecodePixelHeight](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelheight.md). The **DecodePixel*** properties enable you to pass information directly to the format-specific codec, and the codec can use this information to decode more efficiently and to a smaller memory footprint. Set [DecodePixelWidth](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelwidth.md) to the same pixel width of the area that you want your app to actually display. In other words, [DecodePixelWidth](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelwidth.md) for the [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) source should be the same value as the [Width](../windows.ui.xaml/frameworkelement_width.md) or [ActualWidth](../windows.ui.xaml/frameworkelement_actualwidth.md) of the Image control that displays that source.

You can either set [DecodePixelWidth](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelwidth.md), or set [DecodePixelHeight](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelheight.md). If you set one of these two properties, the system calculates the matching property to maintain the correct aspect ratio. You can also set both properties, but you typically should use values that maintain that aspect ratio. If you want to change aspect ratios there are better ways to do so, for example using a [TranslateTransform](../windows.ui.xaml.media/translatetransform.md) as a [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md).

To set [DecodePixelWidth](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelwidth.md) (or [DecodePixelHeight](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelheight.md)) in XAML, you must use a slightly more verbose XAML syntax that includes an explicit [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) element as a property element value, like this:

```xaml
<Image>
  <Image.Source>
    <BitmapImage DecodePixelWidth="200" UriSource="images/myimage.png"/>
  </Image.Source>
</Image>

```

[DecodePixelWidth](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelwidth.md) (or [DecodePixelHeight](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelheight.md)) are properties of [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md), so you need an explicit [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) XAML object element in order to set the **DecodePixel*** properties as attributes in XAML.

If you are creating an Image instance in code, you are probably already creating a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) instance as a value to provide for the [Source](image_source.md) property, so just set [DecodePixelWidth](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelwidth.md) (or [DecodePixelHeight](../windows.ui.xaml.media.imaging/bitmapimage_decodepixelheight.md)) on the [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) instance before you set the [UriSource](../windows.ui.xaml.media.imaging/bitmapimage_urisource.md) property. The [DecodePixelType](../windows.ui.xaml.media.imaging/bitmapimage_decodepixeltype.md) property also affects how pixel values are interpreted by the decode operations.

To prevent images from being decoded more than once, assign image source property from Uniform Resource Identifier (URI) rather than using memory streams whenever you can. The XAML framework can associate the same Uniform Resource Identifier (URI) in multiple places with one decoded image, but it cannot do the same for multiple memory streams even if they contain the same data.

You can remove image files from the image cache by setting all associated [Image.Source](image_source.md) values to **null**.

<!--<p  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">If you're specifically trying to show a thumbnail for a file reference / <xref targtype="class_winrt" rid="w_storage.storagefile">StorageFile</xref> instance, you can call <xref targtype="method_overload_winrt" rid="w_storage.storagefile_getthumbnailasync">GetThumbnailAsync</xref>.</p>-->

For more info on the Image class and performance, see [Optimize animations and media](/windows/uwp/debug-test-perf/optimize-animations-and-media).

### Image file encoding and decoding

The underlying codec support for image files is supplied by Windows Imaging Component (WIC)  API. For more info on specific image formats as documented for the codecs, see [Native WIC Codecs](/windows/desktop/wic/native-wic-codecs).

The API for Image, [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) and [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md) doesn't include any dedicated methods for encoding and decoding of media formats. All of the decoding operations are built-in as actions that happen when the source is set or reset. This makes the classes easier to use for constructing UI, because they have a default set of supported source file formats and decoding behavior. Classes such as [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) expose some of the decoding options and logic as part of event data for [ImageOpened](../windows.ui.xaml.media.imaging/bitmapimage_imageopened.md) or [ImageFailed](../windows.ui.xaml.media.imaging/bitmapimage_imagefailed.md) events. If you need advanced image file decoding, or image encoding, you should use the API from the [Windows.Graphics.Imaging](../windows.graphics.imaging/windows_graphics_imaging.md) namespace. You might need these API if your app scenario involves image file format conversions, or manipulation of an image where the user can save the result as a file. The encoding API are also supported by the Windows Imaging Component (WIC) component of Windows.

### **Image** width and height

The Image class inherits the [Width](../windows.ui.xaml/frameworkelement_width.md) and [Height](../windows.ui.xaml/frameworkelement_height.md) properties from [FrameworkElement](../windows.ui.xaml/frameworkelement.md), and these properties potentially control the size that your Image control will render when it displays in UI. If you don't set a [Width](../windows.ui.xaml/frameworkelement_width.md) or a [Height](../windows.ui.xaml/frameworkelement_height.md), then the width and height is determined by the natural size of the image source. For example, if you load a bitmap image that is 300 pixels high and 400 pixels wide, as recorded in its source file format, these measurements are used for the width and height when the Image control calculates its natural size. You can check [ActualHeight](../windows.ui.xaml/frameworkelement_actualheight.md) and [ActualWidth](../windows.ui.xaml/frameworkelement_actualwidth.md) at run time after the image renders to get the measurement information. Or, you can handle [ImageOpened](image_imageopened.md) and check image file properties such as [PixelHeight](../windows.ui.xaml.media.imaging/bitmapsource_pixelheight.md) and [PixelWidth](../windows.ui.xaml.media.imaging/bitmapsource_pixelwidth.md) immediately before the image renders.

If you set just one of the [Width](../windows.ui.xaml/frameworkelement_width.md) or [Height](../windows.ui.xaml/frameworkelement_height.md) properties but not both, then the system can use that dimension as guidance and calculate the other one, preserving the aspect ratio. If you're not sure of the source file dimensions, pick the dimension that's the most important to control in your layout scenario and let the system calculate the other dimension, and then the layout behavior of the container will typically adapt the layout to fit.

If you don't set [Width](../windows.ui.xaml/frameworkelement_width.md) and/or [Height](../windows.ui.xaml/frameworkelement_height.md), and leave the image as its natural size, the [Stretch](image_stretch.md) property for the image can control how the image source file will fill the space you specify as [Width](../windows.ui.xaml/frameworkelement_width.md) and [Height](../windows.ui.xaml/frameworkelement_height.md). The default [Stretch](image_stretch.md) value is **Uniform**, which preserves aspect ratio when it fits the image into a layout container. If the container's dimensions don't have the same aspect ratio, then there will be empty space that's still part of Image but isn't showing any image pixels, at least while using the **Uniform** value for [Stretch](image_stretch.md). **UniformToFill** for [Stretch](image_stretch.md) won't leave empty space but might clip the image if dimensions are different. **Fill** for [Stretch](image_stretch.md) won't leave empty space, but might change the aspect ratio. You can experiment with these values to see what's best for image display in your layout scenario. Also, be aware that certain layout containers might size an image that has no specific [Width](../windows.ui.xaml/frameworkelement_width.md) and [Height](../windows.ui.xaml/frameworkelement_height.md) to fill the entire layout space, in which case you can choose to set specific sizes on either the image or the container for it.

### NineGrid

Using the [NineGrid](image_ninegrid.md) technique is another option for sizing images that have a different natural size than your display area, if the image has regions that should not be scaled uniformly. For example you can use a background image that has an inherent border that should only stretch in one dimension, and corners that shouldn't stretch at all, but the image center can stretch to fit the layout requirements in both dimensions. For more info, see [NineGrid](image_ninegrid.md).

### Resource qualification and localization for **Image**

### **Image** source files and scaling

You should create your image sources at several recommended sizes, to ensure that your app looks great when Windows 8 scales it. When specifying a [Source](image_source.md) for an Image, you can use a naming convention for resources that will use the correct resource for device-specific scaling factors. This is determined by the app automatically at run-time. For specifics of the naming conventions to use and more info, see [Quickstart: Using file or image resources](/previous-versions/windows/apps/hh965325(v=win.10)).

For more info on how to design images properly for scaling, see [UX guidelines for layout and scaling](https://developer.microsoft.com/windows/apps/design).

### Using unqualified resources

Unqualified resources is a technique you can use where the basic resource reference refers to a default resource, and the resource management process can find the equivalent localized resource automatically. You can use automatic handling for accessing unqualified resources with current scale and culture qualifiers, or you can use [ResourceManager](../windows.applicationmodel.resources.core/resourcemanager.md) and [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) with qualifiers for culture and scale to obtain the resources directly. For more info see [Resource management system](/windows/uwp/app-resources/resource-management-system).

### FlowDirection for Image

If you set [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) as **RightToLeft** for an Image, the visual content of an Image is flipped horizontally. However, an Image element does not inherit the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) value from any parent element. Typically you only want image-flipping behavior in images that are relevant to layout, but not necessarily to elements that have embedded text or other components that wouldn't make sense flipped for a right-to-left audience. To get image-flip behavior, you must set the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) element on the Image element specifically to **RightToLeft**, or set the [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) property in code-behind. Consider identifying the Image element by [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive), and specifying [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md) values as a Windows Runtime resource, so that your localization experts can change this value later without changing the XAML or code.

### The Image class and accessibility

The Image class is not a true control class in that it is not a descendant class of [Control](control.md). You can't call focus to an Image element, or place an Image element in a tab sequence. For more info on the accessibility aspects of using images and the Image element in your UI, see [Basic accessibility information](/windows/uwp/accessibility/basic-accessibility-information).

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 459121-->

### Windows 8 behavior

For Windows 8, resources can use a resource qualifier pattern to load different resources depending on device-specific scaling. However, resources aren't automatically reloaded if the scaling factor changes while the app is running. In this case apps would have to take care of reloading resources, by handling the [DpiChanged](../windows.graphics.display/displayinformation_dpichanged.md) event (or the deprecated [LogicalDpiChanged](../windows.graphics.display/displayproperties_logicaldpichanged.md) event) and using [ResourceManager](../windows.applicationmodel.resources.core/resourcemanager.md)  API to manually reload the resource that's appropriate for the new scaling factor. Starting with Windows 8.1, any resource that was originally retrieved for your app is automatically re-evaluated if the scaling factor changes while the app is running. In addition, when that resource is the image source for an Image object, then one of the source-load events ([ImageOpened](image_imageopened.md) or [ImageFailed](image_imagefailed.md)) is fired as a result of the system's action of requesting the new resource and then applying it to the Image. The scenario where a run-time scale change might happen is if the user moves your app to a different monitor when more than one is available.

If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it results in [ImageOpened](image_imageopened.md) or [ImageFailed](image_imagefailed.md) events that happen at run-time when the scale change is handled, even in cases where the [Source](image_source.md) is set in XAML. Also, if you did have code that handled [DpiChanged](../windows.graphics.display/displayinformation_dpichanged.md)/[LogicalDpiChanged](../windows.graphics.display/displayproperties_logicaldpichanged.md) and reset the resources, you should examine whether that code is still needed given the new Windows 8.1 automatic reload behavior.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetAlphaMask |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Image](/windows/apps/design/controls/images-imagebrushes).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the Image in action](winui2gallery:/item/Image)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

## -see-also

[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes), [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample), [Optimize animations and media](/windows/uwp/debug-test-perf/optimize-animations-and-media), [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md), [FlowDirection](../windows.ui.xaml/frameworkelement_flowdirection.md), [Windows.Graphics.Imaging](../windows.graphics.imaging/windows_graphics_imaging.md), [Source](image_source.md), [Animated GIF playback (XAML) sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624046)
