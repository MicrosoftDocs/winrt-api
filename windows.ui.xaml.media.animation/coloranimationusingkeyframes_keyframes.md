---
-api-id: P:Windows.UI.Xaml.Media.Animation.ColorAnimationUsingKeyFrames.KeyFrames
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.ColorKeyFrameCollection KeyFrames { get; }
-->

# Windows.UI.Xaml.Media.Animation.ColorAnimationUsingKeyFrames.KeyFrames

## -description
Gets the collection of [ColorKeyFrame](colorkeyframe.md) objects that define the animation.



## -xaml-syntax
```xaml
<ColorAnimationUsingKeyFrames ...>
  oneOrMoreColorKeyFrames
</ColorAnimationUsingKeyFrames>
```


## -xaml-values
<dl><dt>oneOrMoreColorKeyFrames</dt><dd>oneOrMoreColorKeyFramesOne or more object elements that define the key frames for the animation. These object elements represent one of the classes deriving from ColorKeyFrame. These are typically any combination of LinearColorKeyFrame, DiscreteColorKeyFrame, EasingColorKeyFrame, and SplineColorKeyFrame. Object elements defined here become members of the collection when code accesses the ColorAnimationUsingKeyFrames.KeyFrames property at run time.</dd>
</dl>
## -property-value
The collection of [ColorKeyFrame](colorkeyframe.md) objects that define the animation. The default is an empty collection.

## -remarks

## -examples

## -see-also
