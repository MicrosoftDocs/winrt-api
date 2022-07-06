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
