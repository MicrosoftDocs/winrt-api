---
-api-id: P:Windows.UI.Xaml.Media.Imaging.BitmapImage.IsAnimatedBitmap
-api-type: winrt property
---

<!-- Property syntax
public bool IsAnimatedBitmap { get; }
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage.IsAnimatedBitmap

## -description
Gets a value that indicates whether an image is animated.



## -property-value
**true** if the image is animated; otherwise, **false**.

## -remarks
Starting in Windows 10, version 1607, the XAML [Image](../windows.ui.xaml.controls/image.md) element supports animated GIF images. When you use a [BitmapImage](bitmapimage.md) as the image [Source](../windows.ui.xaml.controls/image_source.md), you can access [BitmapImage](bitmapimage.md)  API to control playback of the animated GIF image. For more info, see the 'Animated images' section of the [BitmapImage](bitmapimage.md) class Remarks and the [Animated GIF playback sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlAnimatedGif).

### Compatibility notes

If your app runs on releases of Windows 10 prior to version 1607, you must use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you use it. For more info, see [Version adaptive code: Use new APIs while maintaining compatibility with previous versions](/windows/uwp/debug-test-perf/version-adaptive-code).

## -examples
This example shows how to use an animated GIF. A button lets the user start or stop the animation. The IsAnimatedBitmap property is checked to determine whether the button is shown or hidden.

The example uses version adaptive code so it can run on all versions of Windows 10. On versions prior to version 1607, the first frame of the GIF is shown, but it is not animated.

```xaml
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <Image>
        <Image.Source>
            <BitmapImage x:Name="imageSource"
                         UriSource="Assets/example.gif"
                         ImageOpened="imageSource_ImageOpened"/>
        </Image.Source>
    </Image>

    <AppBarButton x:Name="playButton"
              Icon="Play"
              Visibility="Collapsed"
              Click="playButton_Click"/>
</Grid>
```

```csharp

// Show the play/stop button if the image is animated.
private void imageSource_ImageOpened(object sender, RoutedEventArgs e)
{
    var bitmapImage = (BitmapImage)sender;
    // At this point you can query whether the image is animated or not.
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "IsAnimatedBitmap") 
        && bitmapImage.IsAnimatedBitmap == true)
    {
        // Enable the play button
        playButton.Visibility = Visibility.Visible;
    }
}
```



## -see-also
