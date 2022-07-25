---
-api-id: T:Windows.UI.Xaml.Media.Animation.ColorAnimationUsingKeyFrames
-api-type: winrt class
---

<!-- Class syntax.
public class ColorAnimationUsingKeyFrames : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IColorAnimationUsingKeyFrames
-->

# Windows.UI.Xaml.Media.Animation.ColorAnimationUsingKeyFrames

## -description
Animates the value of a [Color](../windows.ui/color.md) property along a set of key frames.



## -xaml-syntax
```xaml
<ColorAnimationUsingKeyFrames ...>
  oneOrMoreColorKeyFrames
</ColorAnimationUsingKeyFrames>
```


## -remarks

## -examples
The following example uses the ColorAnimationUsingKeyFrames class to animate the [Background](../windows.ui.xaml.controls/panel_background.md) property of a [StackPanel](../windows.ui.xaml.controls/stackpanel.md). This animation uses three key frames in the following manner:


1. During the first two seconds, [LinearColorKeyFrame](linearcolorkeyframe.md) gradually changes the color from green to red. Linear key frames like [LinearColorKeyFrame](linearcolorkeyframe.md) create a smooth linear transition between values.
1. During the end of the next half second, [DiscreteColorKeyFrame](discretecolorkeyframe.md) quickly changes the color from red to yellow. Discrete key frames like [DiscreteColorKeyFrame](discretecolorkeyframe.md) create sudden changes between values; the animation occurs quickly and has no interpolation at all between values.
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
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations)
p://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a)
