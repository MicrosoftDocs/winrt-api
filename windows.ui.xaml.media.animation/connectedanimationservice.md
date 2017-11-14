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
To get an instance of [ConnectedAnimationService](connectedanimationservice.md), call the static [GetForCurrentView](connectedanimationservice_getforcurrentview.md) method.

When you call [PrepareToAnimate](connectedanimationservice_preparetoanimate.md), you supply a key to associate with the newly created [ConnectedAnimation](connectedanimation.md) returned by the method. You can later use this key to retrieve the same animation by calling [GetAnimation](connectedanimationservice_getanimation.md). This lets you connect the animation between two different pages without having to manually pass the reference to the [ConnectedAnimation](connectedanimation.md) object between pages.

See the [Connected animation sample](https://github.com/Microsoft/WindowsUIDevLabs/tree/master/SampleGallery/Samples/SDK%2014393/ConnectedAnimationSample) for a complete example of [ConnectedAnimationService](connectedanimationservice.md).

## -examples
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
[Connected animation overview](https://docs.microsoft.com/windows/uwp/design/motion/connected-animation)