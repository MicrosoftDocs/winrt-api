---
-api-id: M:Windows.UI.Xaml.DependencyObject.GetAnimationBaseValue(Windows.UI.Xaml.DependencyProperty)
-api-type: winrt method
---

<!-- Method syntax
public object GetAnimationBaseValue(Windows.UI.Xaml.DependencyProperty dp)
-->

# Windows.UI.Xaml.DependencyObject.GetAnimationBaseValue

## -description
Returns any base value established for a dependency property, which would apply in cases where an animation is not active.

## -parameters
### -param dp
The identifier for the desired dependency property.

## -returns
The returned base value.

## -remarks
Use [GetAnimationBaseValue](dependencyobject_getanimationbasevalue_1072186849.md) to get values that might currently be animated but you want to know the value before the animation ran. Note that animations with **HoldEnd** behavior might not have this same value. For more info on the **HoldEnd** concept, see [Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).

Animations that are used for visual states don't have **HoldEnd** behavior but do apply an animated value applied while the state is active. For more info, see [Storyboarded animations for visual states](https://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4).

## -examples

## -see-also
[ReadLocalValue](dependencyobject_readlocalvalue_275037327.md), [Timeline](../windows.ui.xaml.media.animation/timeline.md), [Timeline.FillBehavior](../windows.ui.xaml.media.animation/timeline_fillbehavior.md), [Dependency properties overview](https://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e), [Animations overview](https://msdn.microsoft.com/library/0c8dee75-fb7b-4e59-81e3-55f8d65cd982), [Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Storyboarded animations for visual states](https://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4)
