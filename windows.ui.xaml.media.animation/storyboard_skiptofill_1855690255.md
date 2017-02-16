---
-api-id: M:Windows.UI.Xaml.Media.Animation.Storyboard.SkipToFill
-api-type: winrt method
---

<!-- Method syntax
public void SkipToFill()
-->

# Windows.UI.Xaml.Media.Animation.Storyboard.SkipToFill

## -description
Advances the current time of the storyboard's clock to the end of its active period.

## -remarks
If you call this method on an animation that doesn't have a [FillBehavior](timeline_fillbehavior.md) value of **HoldEnd**, this has the same effect as calling [Stop](storyboard_stop.md).

This method is mainly relevant for methods that are playing or paused, and which don't have infinite repeat. Calling [SkipToFill](storyboard_skiptofill.md) on an infinite animation or an animation that's already stopped has no effect.


<!--What about if Begin hasn't been called yet?-->

## -examples

## -see-also
[FillBehavior](timeline_fillbehavior.md), [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a)