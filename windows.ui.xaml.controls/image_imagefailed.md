---
-api-id: E:Windows.UI.Xaml.Controls.Image.ImageFailed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.ExceptionRoutedEventHandler ImageFailed
-->

# Windows.UI.Xaml.Controls.Image.ImageFailed

## -description
Occurs when there is an error associated with image retrieval or format.


## -xaml-syntax
```xaml
<Image ImageFailed="eventhandler"/>
```


## -remarks
Conditions in which this event can occur include:


+ File not found
+ Invalid (unrecognized or unsupported) file format
+ Unknown file format decoding error after upload
+ Qualified resource reload by the system
You might be able to use the [ErrorMessage](../windows.ui.xaml/exceptionroutedeventargs_errormessage.md) in event data to determine the nature of the failure.

ImageFailed and [ImageOpened](image_imageopened.md) are mutually exclusive. One event or the other will always fire whenever an [Image](image.md) has a [Source](image_source.md) value set or reset.

One scenario for handling ImageFailed is to set the [UriSource](../windows.ui.xaml.media.imaging/bitmapimage_urisource.md) of the underlying [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) source to a different local image file. This can serve as a fallback value to display instead of empty space. For example, if you are trying to display an external image where it's possible that the source is no longer there, or for when the user has no Internet connection, you could set the [UriSource](../windows.ui.xaml.media.imaging/bitmapimage_urisource.md) to reference a local fallback or placeholder image that's part of your app package and is always guaranteed to be available.

When the Image element isn’t in the live visual tree, the Image element will not fire [ImageOpened](image_imageopened.md) or ImageFailed events.  If you need to receive these events while the element isn’t in the live tree, use the BitmapImage.[ImageOpened](../windows.ui.xaml.media.imaging/bitmapimage_imageopened.md)/[ImageFailed](../windows.ui.xaml.media.imaging/bitmapimage_imagefailed.md) events.


```csharp
private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e) {
    Image img = sender as Image;
    BitmapImage fallbackImage = new BitmapImage(new Uri("ms-appx:///Images/fallback.png"));
    img.Width = 100; //set to known width of this source's natural size
     //might instead want image to stretch to fill, depends on scenario
    img.Source = fallbackImage;
}
```




<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 459121-->
### Windows 8 behavior

For Windows 8, resources can use a resource qualifier pattern to load different resources depending on device-specific scaling. However, resources aren't automatically reloaded if the scaling factor changes while the app is running. In this case apps would have to take care of reloading resources, by handling the [DpiChanged](../windows.graphics.display/displayinformation_dpichanged.md) event (or the deprecated [LogicalDpiChanged](../windows.graphics.display/displayproperties_logicaldpichanged.md) event) and using [ResourceManager](../windows.applicationmodel.resources.core/resourcemanager.md)  API to manually reload the resource that's appropriate for the new scaling factor. Starting with Windows 8.1, any resource that was originally retrieved for your app is automatically re-evaluated if the scaling factor changes while the app is running. In addition, when that resource is the image source for an [Image](image.md) object, then one of the source-load events ([ImageOpened](image_imageopened.md) or ImageFailed) is fired as a result of the system's action of requesting the new resource and then applying it to the [Image](image.md). The scenario where a run-time scale change might happen is if the user moves your app to a different monitor when more than one is available.


<!--Hopefully the behavior is to NOT throw ImageFailed and show no image if there was a good image for one scaling but not a qualified one for another. That would be Bad. Investigate later.-->
If you migrate your app code from Windows 8 to Windows 8.1 you may want to account for this behavior change, because it results in [ImageOpened](image_imageopened.md) or ImageFailed events that happen at run-time when the scale change is handled, even in cases where the [Source](image_source.md) is set in XAML. Also, if you did have code that handled [DpiChanged](../windows.graphics.display/displayinformation_dpichanged.md)/[LogicalDpiChanged](../windows.graphics.display/displayproperties_logicaldpichanged.md) and reset the resources, you should examine whether that code is still needed given the new Windows 8.1 automatic reload behavior.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
