---
-api-id: P:Windows.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames.KeyFrames
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.PointKeyFrameCollection KeyFrames { get; }
-->

# Windows.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames.KeyFrames

## -description
Gets the collection of [PointKeyFrame](pointkeyframe.md) objects that define the animation.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames.KeyFrames](/windows/winui/api/microsoft.ui.xaml.media.animation.pointanimationusingkeyframes.keyframes) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<PointAnimationUsingKeyFrames>
  oneOrMorePointKeyFrames
</PointAnimationUsingKeyFrames>
```


## -xaml-values
<dl><dt>oneOrMorePointKeyFrames</dt><dd>oneOrMorePointKeyFramesOne or more object elements that define the key frames for the animation. These object elements represent one of the classes deriving from PointKeyFrame. These are typically any combination of LinearPointKeyFrame, EasingPointKeyFrame, DiscretePointKeyFrame, and SplinePointKeyFrame.</dd>
</dl>
## -property-value
The collection of [PointKeyFrame](pointkeyframe.md) objects that define the animation. The default is an empty collection.

## -remarks

## -examples

## -see-also
