---
-api-id: P:Windows.UI.Xaml.Media.ImageBrush.ImageSource
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.ImageSource ImageSource { get;  set; }
-->

# Windows.UI.Xaml.Media.ImageBrush.ImageSource

## -description
Gets or sets the image source displayed by this [ImageBrush](imagebrush.md). In code you set this with an [ImageSource](imagesource.md) subclass instance, in XAML you set this with a URI to an image source file.



## -xaml-syntax
```xaml
<ImageBrush ImageSource="imageUri"/>
```


## -xaml-values
<dl><dt>imageUri</dt><dd>imageUriA URI that references an image file.</dd>
</dl>
## -property-value
An object representing the image source, to be displayed by this [ImageBrush](imagebrush.md) when it's applied to content.

## -remarks
Setting an image source from an image source file or stream is inherently an asynchronous action. Setting the source to a Uniform Resource Identifier (URI) value that cannot be resolved to a valid image source file does not throw an error. Instead, it fires an [ImageFailed](imagebrush_imagefailed.md) event on the [ImageBrush](imagebrush.md). If you want to verify that an image source file did load correctly, you can handle [ImageOpened](imagebrush_imageopened.md) for verification, plus [ImageFailed](imagebrush_imagefailed.md) as a way to provide a fallback image source or recompose your UI.

### Setting ImageSource in XAML

You can set this property in XAML, but in this case you are setting the ImageSource attribute value as a string representing a Uniform Resource Identifier (URI). This behavior relies on underlying type conversion that processes the string as a Uniform Resource Identifier (URI), and calls the internal equivalent of the [BitmapImage(Uri)](../windows.ui.xaml.media.imaging/bitmapimage_bitmapimage_843413386.md) constructor.

The [ImageFailed](imagebrush_imagefailed.md) event can occur if the initial ImageSource attribute value in XAML does not specify a valid source. You can use a relative path to reference an image that you package with the app, or an absolute Uniform Resource Identifier (URI) to reference an image from a server. If you are using an image source that's packaged as part of your app, it's common to use either the **ms-appx** or **ms-resource** schemes.

### Setting ImageSource in code

If you define an [ImageBrush](imagebrush.md) using code, ImageBrush.ImageSource requires a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) (not a Uniform Resource Identifier (URI)) in code. If your source is a stream, use the [SetSourceAsync](../windows.ui.xaml.media.imaging/bitmapsource_setsourceasync_1118221574.md) method to initialize the value. If your source is a Uniform Resource Identifier (URI) referencing a file, which includes content in your app that uses the **ms-appx** or **ms-resource** schemes, use the [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage_bitmapimage_843413386.md) constructor that takes a Uniform Resource Identifier (URI). You might also consider handling the [ImageOpened](imagebrush_imageopened.md) event if there are any timing issues with retrieving or decoding the image source, where you might need alternate content to display until the image source is available. See [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample) for example code.

If you need to compose a URI in relation to another object in the UI to help scope the resource request, you can sometimes use the [FrameworkElement.BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md) property as called on another object in the UI. This provides a base URI that is where the XAML page comes from within the app's project structure.

> [!NOTE]
> You can use automatic handling for accessing unqualified resources with current scale and culture qualifiers, or you can use [ResourceManager](../windows.applicationmodel.resources.core/resourcemanager.md) and [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) with qualifiers for culture and scale to obtain the resources directly. For more info see [Resource management system](/windows/uwp/app-resources/resource-management-system).

### Image sources and scaling

You should create your image sources at several recommended sizes, to ensure that your app looks great when Windows 8 scales it. When specifying an ImageSource for an [ImageBrush](imagebrush.md), you can use a naming convention that will automatically reference the correct resource for the current scaling. For specifics of the naming convention and more info, see [Quickstart: Using file or image resources](/previous-versions/windows/apps/hh965325(v=win.10)).

For more info on how to design for scaling, see [UX guidelines for layout and scaling](https://developer.microsoft.com/windows/apps/design).

For more info on app resources and how to package image sources in an app, see [Defining app resources](/previous-versions/windows/apps/hh965321(v=win.10)).

### Notes for previous versions

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 462561-->
> **Windows 8**

Windows 8 had an issue with ImageSource resolution from a XAML attribute URI value, if the [ImageBrush](imagebrush.md) is part of a XAML style or template that's applied to a control. The control usage would sometimes use a component-specific base URI rather than the appropriate base URI for the style or template, which usually comes from the app. The issue is fixed starting with Windows 8.1; the base URI is correctly determined for app resources or component resources depending on the scope that needs the base URI. Apps that were compiled for Windows 8 might have used workarounds for this behavior, by putting their image source files in the "wrong" place, where the XAML URI would resolve and the app would show the images. If you are migrating XAML from Windows 8 to Windows 8.1 you should test any [ImageBrush](imagebrush.md) usages in a style or template from your XAML and verify that the image resolution in your app is working with Windows 8.1. If you have a problem, you should move your image source files within the package so that they're in the correct resource scope for the new behavior.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage_bitmapimage_843413386.md), [Image](../windows.ui.xaml.controls/image.md), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes)
