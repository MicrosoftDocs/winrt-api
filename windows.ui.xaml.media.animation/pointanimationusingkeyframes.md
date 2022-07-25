---
-api-id: T:Windows.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames
-api-type: winrt class
---

<!-- Class syntax.
public class PointAnimationUsingKeyFrames : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IPointAnimationUsingKeyFrames
-->

# Windows.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames

## -description
Animates the value of a [Point](../windows.foundation/point.md) property along a set of [KeyFrames](pointanimationusingkeyframes_keyframes.md).



## -xaml-syntax
```xaml
<PointAnimationUsingKeyFrames>
  oneOrMorePointKeyFrames
</PointAnimationUsingKeyFrames>
```


## -remarks

## -examples
The following example moves an ellipse along a triangular path. The example uses the PointAnimationUsingKeyFrames class to animate the [Center](../windows.ui.xaml.media/ellipsegeometry_center.md) property of an [EllipseGeometry](../windows.ui.xaml.media/ellipsegeometry.md). This animation uses three key frames in the following manner:


1. During the first half second, it uses an instance of the [LinearPointKeyFrame](linearpointkeyframe.md) class to move the ellipse along a path at a steady rate from its starting position. Linear key frames such as [LinearPointKeyFrame](linearpointkeyframe.md) create a smooth linear interpolation between values.
1. During the end of the next half second, it uses an instance of the [DiscretePointKeyFrame](discretepointkeyframe.md) class to suddenly move the ellipse along the path to the next position. Discrete key frames like [DiscretePointKeyFrame](discretepointkeyframe.md) create sudden jumps between values.
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
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations)
p://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a)
