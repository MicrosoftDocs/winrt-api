---
-api-id: T:Windows.UI.Xaml.Media.Animation.ConnectedAnimationService
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectedAnimationService : Windows.UI.Xaml.Media.Animation.IConnectedAnimationService
-->

# Windows.UI.Xaml.Media.Animation.ConnectedAnimationService

## -description
Represents a service that provides properties and methods to display a [ConnectedAnimation](connectedanimation.md).


## -remarks
To get an instance of ConnectedAnimationService, call the static [GetForCurrentView](connectedanimationservice_getforcurrentview_1363600702.md) method.

When you call [PrepareToAnimate](connectedanimationservice_preparetoanimate_910589761.md), you supply a key to associate with the newly created [ConnectedAnimation](connectedanimation.md) returned by the method. You can later use this key to retrieve the same animation by calling [GetAnimation](connectedanimationservice_getanimation_1121981282.md). This lets you connect the animation between two different pages without having to manually pass the reference to the [ConnectedAnimation](connectedanimation.md) object between pages.

See the [Connected animation sample](https://github.com/microsoft/WindowsCompositionSamples/tree/master/SampleGallery/Samples/SDK%2014393/ConnectedAnimationSample) for a complete example of ConnectedAnimationService.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Connected animation](/windows/uwp/design/motion/connected-animation).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see Connected Animation in action](winui2gallery:/item/ConnectedAnimation).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

This example shows how to animate an image between two pages during a navigation.

SourcePage.xaml/SourcePage.xaml.cs

```xaml
<Image x:Name="SourceImage"
       Width="200"
       Height="200"
       Stretch="Fill"
       Source="Assets/StoreLogo.png" />
```

```csharp
private void NavigateToDestinationPage()
{
    ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("image", SourceImage);
    Frame.Navigate(typeof(DestinationPage));
}
```

DestinationPage.xaml/DestinationPage.xaml.cs

```xaml
<Image x:Name="DestinationImage"
       Width="400"
       Height="400"
       Stretch="Fill"
       Source="Assets/StoreLogo.png" />
```

```csharp
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    base.OnNavigatedTo(e);

    ConnectedAnimation imageAnimation = 
        ConnectedAnimationService.GetForCurrentView().GetAnimation("image");
    if (imageAnimation != null)
    {
        imageAnimation.TryStart(DestinationImage);
    }
}
```



## -see-also
[Connected animation overview](/windows/uwp/design/motion/connected-animation)
