---
-api-id: P:Windows.UI.Xaml.Media.Imaging.BitmapImage.IsPlaying
-api-type: winrt property
---

<!-- Property syntax
public bool IsPlaying { get; }
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage.IsPlaying

## -description
Gets a value that indicates whether an animated image is playing.



## -property-value
**true** if the animated image is playing; otherwise, **false**.

## -remarks
Starting in Windows 10, version 1607, the XAML [Image](../windows.ui.xaml.controls/image.md) element supports animated GIF images. When you use a [BitmapImage](bitmapimage.md) as the image [Source](../windows.ui.xaml.controls/image_source.md), you can access [BitmapImage](bitmapimage.md)  API to control playback of the animated GIF image. For more info, see the 'Animated images' section of the [BitmapImage](bitmapimage.md) class Remarks and the [Animated GIF playback sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlAnimatedGif).

Use the IsPlaying property along with the [Play](bitmapimage_play_848564459.md) and [Stop](bitmapimage_stop_1201535524.md) methods to control the playback of an animated bitmap.

### Compatibility notes

If your app runs on releases of Windows 10 prior to version 1607, you must use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you use it. For more info, see [Version adaptive code: Use new APIs while maintaining compatibility with previous versions](/windows/uwp/debug-test-perf/version-adaptive-code).

## -examples
This example shows how to use an animated GIF. A button lets the user start or stop the animation. The IsPlaying property is checked to determine whether the [Play](bitmapimage_play_848564459.md) or [Stop](bitmapimage_stop_1201535524.md) method is called to toggle playback.

The example uses version adaptive code so it can run on all versions of Windows 10. On versions prior to version 1607, the first frame of the GIF is shown, but it is not animated.

```xaml
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <Image>
        <Image.Source>
            <BitmapImage x:Name="imageSource"
                         UriSource="Assets/example.gif"/>
        </Image.Source>
    </Image>

    <AppBarButton x:Name="playButton"
              Icon="Play"
              Click="playButton_Click"/>
</Grid>
```

```csharp

// Play or stop the animated bitmap.
void playButton_Click(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "IsPlaying") 
        && imageSource.IsPlaying == true)
    {
        playButton.Icon = new SymbolIcon(Symbol.Play);
        imageSource.Stop();
    }
    else
    {
        playButton.Icon = new SymbolIcon(Symbol.Stop);
        imageSource.Play();
    }   
}
```



## -see-also
