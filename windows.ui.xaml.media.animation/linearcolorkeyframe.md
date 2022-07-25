---
-api-id: T:Windows.UI.Xaml.Media.Animation.LinearColorKeyFrame
-api-type: winrt class
---

<!-- Class syntax.
public class LinearColorKeyFrame : Windows.UI.Xaml.Media.Animation.ColorKeyFrame, Windows.UI.Xaml.Media.Animation.ILinearColorKeyFrame
-->

# Windows.UI.Xaml.Media.Animation.LinearColorKeyFrame

## -description
Animates from the [Color](../windows.ui/color.md) value of the previous key frame to its own [Value](colorkeyframe_value.md) using linear interpolation.



## -xaml-syntax
```xaml
<LinearColorKeyFrame .../>
```


## -remarks
Key-frame animations permit more than one target value that is reached at a point along the animation timeline. In other words each key frame can specify a different intermediate value, and the last key frame reached is the final animation value. By specifying multiple values to animate, you can make more complex animations. You'd typically have at least two keyframes in a [ColorAnimationUsingKeyFrames](coloranimationusingkeyframes.md) with LinearColorKeyFrame, otherwise a [ColorAnimation](coloranimation.md) would have been simpler.

For more info on how to use key-frame animations, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples
This XAML example uses the [ColorAnimationUsingKeyFrames](coloranimationusingkeyframes.md) class to animate the [Background](../windows.ui.xaml.controls/panel_background.md) property of a [StackPanel](../windows.ui.xaml.controls/stackpanel.md). This animation uses three key frames in the following manner:


1. During the first two seconds, LinearColorKeyFrame gradually changes the color from green to red. Linear key frames like LinearColorKeyFrame create a smooth linear transition between values.
1. During the end of the next half second, [DiscreteColorKeyFrame](discretecolorkeyframe.md) quickly changes the color from red to yellow. Discrete key frames like [DiscreteColorKeyFrame](discretecolorkeyframe.md) create sudden changes between values; the animation occurs quickly and has no interpolation between values at all.
1. During the final two seconds, [SplineColorKeyFrame](splinecolorkeyframe.md) changes the color again, this time from yellow back to green. Spline key frames like [SplineColorKeyFrame](splinecolorkeyframe.md) create a variable transition between values according to the values of the [KeySpline](splinecolorkeyframe_keyspline.md) property. A [KeySpline](keyspline.md) provides a way to alter the relationship of time versus value during the animation duration to be nonlinear, and in particular the relationship can be a curve that would be difficult to produce with individual key frames. In this example, the change in color begins slowly and speeds up exponentially toward the end of the time segment.

<!--<p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=coloranimationusingkeyframes</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->



[!code-xaml[Coloranimationusingkeyframes](../windows.ui.xaml.media.animation/code/coloranimationusingkeyframes/csharp/Page.xaml#SnippetColoranimationusingkeyframes)]

[!code-csharp[Coloranimationusingkeyframes_cs](../windows.ui.xaml.media.animation/code/coloranimationusingkeyframes/csharp/Page.xaml.cs#SnippetColoranimationusingkeyframes_cs)]

[!code-vb[Coloranimationusingkeyframes_cs](../windows.ui.xaml.media.animation/code/coloranimationusingkeyframes/vbnet/Page.xaml.vb#SnippetColoranimationusingkeyframes_cs)]

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [ColorKeyFrame](colorkeyframe.md), [ColorAnimationUsingKeyFrames](coloranimationusingkeyframes.md), [ColorKeyFrameCollection](colorkeyframecollection.md), [KeyTime](colorkeyframe_keytime.md), [Value](colorkeyframe_value.md),
[KeyTime](colorkeyframe_keytime.md), [Value](colorkeyframe_value.md)
