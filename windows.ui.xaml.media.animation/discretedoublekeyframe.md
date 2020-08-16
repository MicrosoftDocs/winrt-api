---
-api-id: T:Windows.UI.Xaml.Media.Animation.DiscreteDoubleKeyFrame
-api-type: winrt class
---

<!-- Class syntax.
public class DiscreteDoubleKeyFrame : Windows.UI.Xaml.Media.Animation.DoubleKeyFrame, Windows.UI.Xaml.Media.Animation.IDiscreteDoubleKeyFrame
-->

# Windows.UI.Xaml.Media.Animation.DiscreteDoubleKeyFrame

## -description
Animates from the [Double](https://docs.microsoft.com/dotnet/api/system.double?redirectedfrom=MSDN) value of the previous key frame to its own [Value](doublekeyframe_value.md) using discrete values.

## -xaml-syntax
```xaml
<DiscreteDoubleKeyFrame .../>
```


## -remarks
Key-frame animations permit more than one target value that is reached at a point along the animation timeline. In other words each key frame can specify a different intermediate value, and the last key frame reached is the final animation value. By specifying multiple values to animate, you can make more complex animations. You can mix discrete, linear, and spline keyframes in the same keyframe collection.

For more info on how to use key-frame animations, see [Key-frame animations and easing function animations](https://docs.microsoft.com/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples
This XAML example moves a rectangle across a screen. The example uses the [DoubleAnimationUsingKeyFrames](doubleanimationusingkeyframes.md) class to animate the [X](../windows.ui.xaml.media/translatetransform_x.md) property of a [TranslateTransform](../windows.ui.xaml.media/translatetransform.md) applied to a [Rectangle](../windows.ui.xaml.shapes/rectangle.md). This animation uses three key frames in the following manner:


1. During the first three seconds, it uses an instance of the [LinearDoubleKeyFrame](lineardoublekeyframe.md) class to move the rectangle along a path at a steady rate from its starting position to the 500 position. Linear key frames like [LinearDoubleKeyFrame](lineardoublekeyframe.md) create a smooth linear transition between values.
1. At the end of the fourth second, it uses an instance of the DiscreteDoubleKeyFrame class to suddenly move the rectangle to the next position. Discrete key frames like DiscreteDoubleKeyFrame create sudden jumps between values. In this example, the rectangle is at the starting position and then suddenly appears at the 500 position.
1. In the final two seconds, it uses an instance of the [SplineDoubleKeyFrame](splinedoublekeyframe.md) class to move the rectangle back to its starting position. Spline key frames like [SplineDoubleKeyFrame](splinedoublekeyframe.md) create a variable transition between values according to the value of the [KeySpline](splinedoublekeyframe_keyspline.md) property. In this example, the rectangle begins by moving slowly and then speeds up exponentially toward the end of the time segment.

<!--<p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=doubleanimationusingkeyframes2</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->



[!code-xaml[Doubleanimationusingkeyframes2](../windows.ui.xaml.media.animation/code/doubleanimationusingkeyframes2/csharp/Page.xaml#SnippetDoubleanimationusingkeyframes2_cs)]

[!code-vb[Doubleanimationusingkeyframes2](../windows.ui.xaml.media.animation/code/doubleanimationusingkeyframes2/vbnet/Page.xaml.vb#SnippetDoubleanimationusingkeyframes2)]

[!code-csharp[Doubleanimationusingkeyframes2_cs](../windows.ui.xaml.media.animation/code/doubleanimationusingkeyframes2/csharp/Page.xaml.cs#SnippetDoubleanimationusingkeyframes2)]

## -see-also
[Storyboarded animations](https://docs.microsoft.com/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](https://docs.microsoft.com/windows/uwp/graphics/key-frame-and-easing-function-animations), [DoubleKeyFrame](doublekeyframe.md), [DoubleAnimationUsingKeyFrames](doubleanimationusingkeyframes.md), [DoubleKeyFrameCollection](doublekeyframecollection.md), [KeyTime](doublekeyframe_keytime.md), [Value](doublekeyframe_value.md), [Value](doublekeyframe_value.md)
