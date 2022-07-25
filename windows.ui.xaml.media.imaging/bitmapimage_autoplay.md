---
-api-id: P:Windows.UI.Xaml.Media.Imaging.BitmapImage.AutoPlay
-api-type: winrt property
---

<!-- Property syntax
public bool AutoPlay { get;  set; }
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage.AutoPlay

## -description
Gets or sets a value that indicates whether an animated image should play as soon as it loads.



## -property-value
**true** if an animated image should play as soon as it loads; otherwise, **false**. The default is **true**.

## -remarks
Starting in Windows 10, version 1607, the XAML [Image](../windows.ui.xaml.controls/image.md) element supports animated GIF images. When you use a [BitmapImage](bitmapimage.md) as the image [Source](../windows.ui.xaml.controls/image_source.md), you can access [BitmapImage](bitmapimage.md)  API to control playback of the animated GIF image. For more info, see the 'Animated images' section of the [BitmapImage](bitmapimage.md) class Remarks and the [Animated GIF playback sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlAnimatedGif).

Use the AutoPlay property, which defaults to **true**, to specify whether or not an animated bitmap plays as soon as it loads.

> [!NOTE]
> For most apps, we recommend that you set AutoPlay to **false** if [UISettings.AnimationsEnabled](../windows.ui.viewmanagement/uisettings_animationsenabled.md) is **false**, to support the accessibility needs of users. Do not do this if the content of the animated GIF is important for the usability of your app.

### Compatibility notes

If your app runs on releases of Windows 10 prior to version 1607, you must set this property in code and use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you use it. If you set this property in XAML, you will get a XAML compiler error. For more info, see [Version adaptive code: Use new APIs while maintaining compatibility with previous versions](/windows/uwp/debug-test-perf/version-adaptive-code).

## -examples
This example shows how to use version adaptive code to use this property in an app that runs on all versions of Windows 10. On versions prior to version 1607, the first frame of the GIF is shown, but it is not animated.

```xaml

<Image Loaded="Image_Loaded">
    <Image.Source>
        <BitmapImage x:Name="imageSource"
                     UriSource="Assets/example.gif"/>
    </Image.Source>
</Image>

```

```csharp
// Set the AutoPlay property.
private void Image_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "AutoPlay") == true)
    {
        imageSource.AutoPlay = false;
    }
}
```



## -see-also
