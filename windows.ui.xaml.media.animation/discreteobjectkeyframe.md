---
-api-id: T:Windows.UI.Xaml.Media.Animation.DiscreteObjectKeyFrame
-api-type: winrt class
---

<!-- Class syntax.
public class DiscreteObjectKeyFrame : Windows.UI.Xaml.Media.Animation.ObjectKeyFrame, Windows.UI.Xaml.Media.Animation.IDiscreteObjectKeyFrame
-->

# Windows.UI.Xaml.Media.Animation.DiscreteObjectKeyFrame

## -description
Animates from the [Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true) value of the previous key frame to its own [Value](objectkeyframe_value.md) using discrete values.



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

DiscreteObjectKeyFrame is the only keyframe type permitted in an [ObjectAnimationUsingKeyFrames](objectanimationusingkeyframes.md). There are no linear interpolations or other interpolation logic that's possible for changing object values as the animation runs. The old object is removed at the [KeyTime](objectkeyframe_keytime.md) and the new object that is the value of the keyframe with that [KeyTime](objectkeyframe_keytime.md) replaces it.

There are several scenarios where using [ObjectAnimationUsingKeyFrames](objectanimationusingkeyframes.md) rather than a typed animation is useful. Some of them are:
+ Creating the [Storyboard](storyboard.md) for a visual state and using a value that is a [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) reference, rather than one of the typed values. This gives you the ability to reference system theme resources from a visual state. For more info see [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)).
+ Animating **int** or **byte** values.
+ Animating structures used in UI definitions and visual states, such as [GridLength](../windows.ui.xaml/gridlength.md). You can't animate the properties of the structure but you can swap the entire structure value with a DiscreteObjectKeyFrame and a new [GridLength](../windows.ui.xaml/gridlength.md).


For more info on how to use key-frame animations, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)), [ObjectKeyFrame](objectkeyframe.md), [ObjectAnimationUsingKeyFrames](objectanimationusingkeyframes.md)
