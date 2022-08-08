---
-api-id: T:Windows.UI.Xaml.Media.Animation.ConnectedAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectedAnimation : Windows.UI.Xaml.Media.Animation.IConnectedAnimation, Windows.UI.Xaml.Media.Animation.IConnectedAnimation2
-->

# Windows.UI.Xaml.Media.Animation.ConnectedAnimation

## -description
Represents an animation that simultaneously animates the exit of one element and the entrance of another element.


## -remarks
A ConnectedAnimation instance is returned by the [ConnectedAnimationService.GetAnimation](connectedanimationservice_getanimation_1121981282.md) and [ConnectedAnimationService.PrepareToAnimate](connectedanimationservice_preparetoanimate_910589761.md) methods.

When you call [TryStart](connectedanimation_trystart_323048605.md), the element you pass into the method should have its size defined in layout. This means that either the size of the element should be set in markup, or the content of the element should be fully populated, so that its size can be calculated by the XAML framework. If the layout is part of a [ListView](../windows.ui.xaml.controls/listview.md) or [GridView](../windows.ui.xaml.controls/gridview.md) item with bound properties, you might have to manually update the content to prepare for the animation because bindings can be updated asynchronously.

There is a known limitation where ConnectedAnimation does not work well with theme transitions that have a translation component, including [NavigationThemeTransition](navigationthemetransition.md) and [EntranceThemeTransition](entrancethemetransition.md). We recommend that you remove these transitions, or suppress the navigation using [SuppressNavigationTransitionInfo](suppressnavigationtransitioninfo.md), when you create an experience with ConnectedAnimation.

See the [Connected animation sample](https://github.com/microsoft/WindowsCompositionSamples/tree/master/SampleGallery/Samples/SDK%2014393/ConnectedAnimationSample) for a complete example of ConnectedAnimation.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | IsScaleAnimationEnabled |
| 1703 | 15063 | SetAnimationComponent |
| 1703 | 15063 | TryStart(UIElement,IEnumerable&lt;UIElement&gt;) |
| 1809 | 17763 | Configuration |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Connected animation](/windows/uwp/design/motion/connected-animation).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see Connected Animation in action](winui2gallery:/item/ConnectedAnimation).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

## -see-also

[ConnectedAnimationService](connectedanimationservice.md)
