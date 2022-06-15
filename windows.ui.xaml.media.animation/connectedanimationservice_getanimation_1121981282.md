---
-api-id: M:Windows.UI.Xaml.Media.Animation.ConnectedAnimationService.GetAnimation(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Media.Animation.ConnectedAnimation GetAnimation(System.String key)
-->

# Windows.UI.Xaml.Media.Animation.ConnectedAnimationService.GetAnimation

## -description
Returns the animation with the specified key.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.Animation.ConnectedAnimationService.GetAnimation](/windows/winui/api/microsoft.ui.xaml.media.animation.connectedanimationservice.getanimation) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param key
The key for the animation.

## -returns
The animation with the specified key; or **null** if no animation has been prepared for that key, or if the animation is no longer active.

## -remarks
A [ConnectedAnimation](connectedanimation.md) is no longer active when:
+ It has been canceled.
+ The animation has completed.
+ The source has expired ([PrepareToAnimate](connectedanimationservice_preparetoanimate_910589761.md) was called and then the animation was not started for ~2 seconds).


## -examples

## -see-also
