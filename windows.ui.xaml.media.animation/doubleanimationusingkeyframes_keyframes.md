---
-api-id: P:Windows.UI.Xaml.Media.Animation.DoubleAnimationUsingKeyFrames.KeyFrames
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.DoubleKeyFrameCollection KeyFrames { get; }
-->

# Windows.UI.Xaml.Media.Animation.DoubleAnimationUsingKeyFrames.KeyFrames

## -description
Gets the collection of [DoubleKeyFrame](doublekeyframe.md) objects that define the animation.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.Animation.DoubleAnimationUsingKeyFrames.KeyFrames](/windows/winui/api/microsoft.ui.xaml.media.animation.doubleanimationusingkeyframes.keyframes) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<DoubleAnimationUsingKeyFrames>
  oneOrMoreDoubleKeyFrames
</DoubleAnimationUsingKeyFrames>
```


## -xaml-values
<dl><dt>oneOrMoreDoubleKeyFrames</dt><dd>oneOrMoreDoubleKeyFramesOne or more object elements that define the key frames for the animation. These object elements represent one of the classes deriving from DoubleKeyFrame. These are typically any combination of LinearDoubleKeyFrame, DiscreteDoubleKeyFrame, EasingDoubleKeyFrame, and SplineDoubleKeyFrame.</dd>
</dl>
## -property-value
The collection of [DoubleKeyFrame](doublekeyframe.md) objects that define the animation. The default is an empty collection.

## -remarks

## -examples

## -see-also
