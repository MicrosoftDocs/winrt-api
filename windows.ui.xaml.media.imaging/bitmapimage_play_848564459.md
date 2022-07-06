---
-api-id: M:Windows.UI.Xaml.Media.Imaging.BitmapImage.Play
-api-type: winrt method
---

<!-- Method syntax
public void Play()
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage.Play

## -description
Starts the animation of an animated image.



## -remarks
Starting in Windows 10, version 1607, the XAML [Image](../windows.ui.xaml.controls/image.md) element supports animated GIF images. When you use a [BitmapImage](bitmapimage.md) as the image [Source](../windows.ui.xaml.controls/image_source.md), you can access [BitmapImage](bitmapimage.md)  API to control playback of the animated GIF image. For more info, see the 'Animated images' section of the [BitmapImage](bitmapimage.md) class Remarks and the [Animated GIF playback sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlAnimatedGif).

Use the [IsPlaying](bitmapimage_isplaying.md) property along with the Play and [Stop](bitmapimage_stop_1201535524.md) methods to control the playback of an animated bitmap.

### Compatibility notes

If your app runs on releases of Windows 10 prior to version 1607, you must use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this method before you use it. For more info, see [Version adaptive code: Use new APIs while maintaining compatibility with previous versions](/windows/uwp/debug-test-perf/version-adaptive-code).

## -examples
Here's how to use the [ApiInformation.IsMethodPresent](../windows.foundation.metadata/apiinformation_ismethodpresent_1062983651.md) to check for the presence of the Play method before you call it.

```csharp
if (ApiInformation.IsMethodPresent("Windows.UI.Xaml.Media.Imaging.BitmapImage", "Play"))
{
    imageSource.Play();
}
```

This example shows how to use an animated GIF. A button lets the user start or stop the animation. The [IsPlaying](bitmapimage_isplaying.md) property is checked to determine whether the Play or [Stop](bitmapimage_stop_1201535524.md) method is called to toggle playback.

The example uses version adaptive code so it can run on all versions of Windows 10. In this case, the presence of the [IsPlaying](bitmapimage_isplaying.md) property indicates that the Play and [Stop](bitmapimage_stop_1201535524.md) methods are also present, so an additional API check is not needed.

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
