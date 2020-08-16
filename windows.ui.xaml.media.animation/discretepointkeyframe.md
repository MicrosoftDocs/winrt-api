---
-api-id: T:Windows.UI.Xaml.Media.Animation.DiscretePointKeyFrame
-api-type: winrt class
---

<!-- Class syntax.
public class DiscretePointKeyFrame : Windows.UI.Xaml.Media.Animation.PointKeyFrame, Windows.UI.Xaml.Media.Animation.IDiscretePointKeyFrame
-->

# Windows.UI.Xaml.Media.Animation.DiscretePointKeyFrame

## -description
Animates from the [Point](../windows.foundation/point.md) value of the previous key frame to its own [Value](pointkeyframe_value.md) using discrete frames.

## -xaml-syntax
```xaml
<DiscretePointKeyFrame />
```


## -remarks
Key-frame animations permit more than one target value that is reached at a point along the animation timeline. In other words each key frame can specify a different intermediate value, and the last key frame reached is the final animation value. By specifying multiple values to animate, you can make more complex animations. You can mix discrete, linear, and spline keyframes in the same keyframe collection.

For more info on how to use key-frame animations, see [Key-frame animations and easing function animations](https://docs.microsoft.com/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples
This XAML example moves an ellipse along a triangular path. The example uses the [PointAnimationUsingKeyFrames](pointanimationusingkeyframes.md) class to animate the [Center](../windows.ui.xaml.media/ellipsegeometry_center.md) property of an [EllipseGeometry](../windows.ui.xaml.media/ellipsegeometry.md). This animation uses three key frames in the following manner:


1. During the first half second, it uses an instance of the [LinearPointKeyFrame](linearpointkeyframe.md) class to move the ellipse along a path at a steady rate from its starting position. Linear key frames such as [LinearPointKeyFrame](linearpointkeyframe.md) create a smooth linear interpolation between values.
1. During the end of the next half second, it uses an instance of the DiscretePointKeyFrame class to suddenly move the ellipse along the path to the next position. Discrete key frames like DiscretePointKeyFrame create sudden jumps between values.
1. During the final two seconds, it uses an instance of the [SplinePointKeyFrame](splinepointkeyframe.md) class to move the ellipse back to its starting position. Spline key frames like [SplinePointKeyFrame](splinepointkeyframe.md) create a variable transition between values according to the values of the [KeySpline](splinepointkeyframe_keyspline.md) property. In this example, the animation begins slowly and speeds up exponentially toward the end of the time segment.

<!--<p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=pointanimationusingkeyframes</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->



[!code-xaml[Pointanimationusingkeyframes](../windows.ui.xaml/code/pointanimationusingkeyframes/csharp/Page.xaml#SnippetPointanimationusingkeyframes)]

[!code-csharp[Pointanimationusingkeyframes_cs](../windows.ui.xaml/code/pointanimationusingkeyframes/csharp/Page.xaml.cs#SnippetPointanimationusingkeyframes_cs)]

[!code-vb[Pointanimationusingkeyframes_cs](../windows.ui.xaml/code/pointanimationusingkeyframes/vbnet/Page.xaml.vb#SnippetPointanimationusingkeyframes_cs)]

## -see-also
[Storyboarded animations](https://docs.microsoft.com/windows/uwp/graphics/storyboarded-animations), [PointKeyFrame](pointkeyframe.md), [PointAnimationUsingKeyFrames](pointanimationusingkeyframes.md), [KeyTime](pointkeyframe_keytime.md), [Value](pointkeyframe_value.md), [KeyTime](pointkeyframe_keytime.md), [Value](pointkeyframe_value.md)
