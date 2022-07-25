---
-api-id: M:Windows.UI.Xaml.Media.Animation.Storyboard.Begin
-api-type: winrt method
---

<!-- Method syntax
public void Begin()
-->

# Windows.UI.Xaml.Media.Animation.Storyboard.Begin

## -description
Initiates the set of animations associated with the storyboard.



## -remarks
Calling this method begins all the animations that are in the [Children](storyboard_children.md) collection of the [Storyboard](storyboard.md).

Begin starts the animations within the [Storyboard](storyboard.md) from their initial state, a clock time of zero. If you want to restart an animation where [Pause](storyboard_pause_1953642114.md) had been called previously, and continue on from the clock time where it was paused, use [Resume](storyboard_resume_406343050.md) instead.

## -examples

## -see-also
[Stop](storyboard_stop_1201535524.md), [GetCurrentTime](storyboard_getcurrenttime_1338472985.md), [Children](storyboard_children.md), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations)
