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
A [ConnectedAnimation](connectedanimation.md) instance is returned by the [ConnectedAnimationService.GetAnimation](connectedanimationservice_getanimation.md) and [ConnectedAnimationService.PrepareToAnimate](connectedanimationservice_preparetoanimate.md) methods.

When you call [TryStart](connectedanimation_trystart.md), the element you pass into the method should have its size defined in layout. This means that either the size of the element should be set in markup, or the content of the element should be fully populated, so that its size can be calculated by the XAML framework. If the layout is part of a [ListView](../windows.ui.xaml.controls/listview.md) or [GridView](../windows.ui.xaml.controls/gridview.md) item with bound properties, you might have to manually update the content to prepare for the animation because bindings can be updated asynchronously.

There is a known limitation where [ConnectedAnimation](connectedanimation.md) does not work well with theme transitions that have a translation component, including [NavigationThemeTransition](navigationthemetransition.md) and [EntranceThemeTransition](entrancethemetransition.md). We recommend that you remove these transitions, or suppress the navigation using [SuppressNavigationTransitionInfo](suppressnavigationtransitioninfo.md), when you create an experience with [ConnectedAnimation](connectedanimation.md).

See the [Connected animation sample](https://github.com/Microsoft/WindowsUIDevLabs/tree/master/SampleGallery/Samples/SDK%2014393/ConnectedAnimationSample) for a complete example of [ConnectedAnimation](connectedanimation.md).

## -examples

## -see-also
[ConnectedAnimationService](connectedanimationservice.md), [Connected animation overview](https://docs.microsoft.com/windows/uwp/design/motion/connected-animation)