---
-api-id: T:Windows.UI.Xaml.Media.Animation.DiscreteObjectKeyFrame
-api-type: winrt class
---

<!-- Class syntax.
public class DiscreteObjectKeyFrame : Windows.UI.Xaml.Media.Animation.ObjectKeyFrame, Windows.UI.Xaml.Media.Animation.IDiscreteObjectKeyFrame
-->

# Windows.UI.Xaml.Media.Animation.DiscreteObjectKeyFrame

## -description
Animates from the [Object](https://msdn.microsoft.com/library/system.object.aspx) value of the previous key frame to its own [Value](objectkeyframe_value.md) using discrete values.

## -xaml-syntax
```xaml
<DiscreteObjectKeyFrame ...>
  <DiscreteObjectKeyFrame.Value>
    objectValue
  </DiscreteObjectKeyFrame.Value>
</DiscreteObjectKeyFrame ...>
-or-
</DiscreteObjectKeyFrame Value="objectAsAttribute"...>
```


## -remarks
Key-frame animations permit more than one target value that is reached at a point along the animation timeline. In other words each key frame can specify a different intermediate value, and the last key frame reached is the final animation value. By specifying multiple values to animate, you can make more complex animations.

[DiscreteObjectKeyFrame](discreteobjectkeyframe.md) is the only keyframe type permitted in an [ObjectAnimationUsingKeyFrames](objectanimationusingkeyframes.md). There are no linear interpolations or other interpolation logic that's possible for changing object values as the animation runs. The old object is removed at the [KeyTime](objectkeyframe_keytime.md) and the new object that is the value of the keyframe with that [KeyTime](objectkeyframe_keytime.md) replaces it.

There are several scenarios where using [ObjectAnimationUsingKeyFrames](objectanimationusingkeyframes.md) rather than a typed animation is useful. Some of them are:
+ Creating the [Storyboard](storyboard.md) for a visual state and using a value that is a [{StaticResource} markup extension](https://msdn.microsoft.com/library/d50349b5-4588-4ebd-9458-75f629ccc395) reference, rather than one of the typed values. This gives you the ability to reference system theme resources from a visual state. For more info see [Storyboarded animations for visual states](https://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4).
+ Animating **int** or **byte** values.
+ Animating structures used in UI definitions and visual states, such as [GridLength](../windows.ui.xaml/gridlength.md). You can't animate the properties of the structure but you can swap the entire structure value with a [DiscreteObjectKeyFrame](discreteobjectkeyframe.md) and a new [GridLength](../windows.ui.xaml/gridlength.md).


For more info on how to use key-frame animations, see [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677).

## -examples

## -see-also
[Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677), [Storyboarded animations for visual states](https://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4), [ObjectKeyFrame](objectkeyframe.md), [ObjectAnimationUsingKeyFrames](objectanimationusingkeyframes.md)
