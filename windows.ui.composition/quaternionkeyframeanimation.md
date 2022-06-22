---
-api-id: T:Windows.UI.Composition.QuaternionKeyFrameAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class QuaternionKeyFrameAnimation : Windows.UI.Composition.KeyFrameAnimation, Windows.UI.Composition.IQuaternionKeyFrameAnimation
-->

# Windows.UI.Composition.QuaternionKeyFrameAnimation

## -description
A time-based animation that targets the Orientation property with one or more key frames.

The QuaternionKeyFrameAnimation class is one of the supported types of [KeyFrameAnimation](keyframeanimation.md)s that is used to animate the [Orientation](visual_orientation.md) property on a [Visual](visual.md). Quaternions are a useful and sometimes simpler way to think about rotations – Quaternions take the shortest path between angles and avoid issues like Gimbal Lock that rotation angle/axis and rotation matrices run into. A Quaternion is made up of two components: a scalar and vector part.



## -remarks
An animation is associated with an object's property by calling [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) and specifying the property name and the animation. See the remarks section of [CompositionObject.StartAnimation](compositionobject_startanimation_709050842.md) for a list of animatable properties.

A Quaternion is made up of two distinguishable parts: A vector and scalar component. When using with KeyFrame Animations, the Quaternion can be defined by the notation of System.Numerics of 4 floats or a Vector3 and a scalar. System.Numerics provides constructors for either of these notations.

When translating a rotation into a Quaternion, you can utilize System.Numerics Quaternion helper functions that allow you to create Quaternions out of an Axis/Angle combo, Rotation Matrix or Yaw/Pitch/Roll. In the example above, the same Quaternion could be constructed from the below helper:

```csharp
Quaternion quaternion = Quaternion.CreateFromAxisAngle(new Vector3(1.0f, 0.0f, 0.0f), 0.78f);
```



## -examples


```csharp

void QuaternionAnimation(SpriteVisual visual)
{
  // Create the QuaternionKeyFrameAnimation
  var quaternionKFA = _compositor.CreateQuaternionKeyFrameAnimation();

  // Create a Quaternion that represents a 45 degree rotation around X Axis
  Quaternion quaternion = new Quaternion(0.380f, 0f, 0.0f, 0.92f);

  // Insert the Quaternion into the KeyFrame
  quaternionKFA.InsertKeyFrame(1.0f, quaternion);
  quaternionKFA.Duration = TimeSpan.FromSeconds(1);

  // Attach to the Orientation property of Visual
  visual.StartAnimation("Orientation", quaternionKFA);
}
          
          
```



## -see-also
[Composition Animations Overview](/windows/uwp/composition/composition-animation), [KeyFrameAnimation](keyframeanimation.md), [IClosable](../windows.foundation/iclosable.md)
