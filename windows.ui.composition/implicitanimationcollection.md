---
-api-id: T:Windows.UI.Composition.ImplicitAnimationCollection
-api-type: winrt class
---

<!-- Class syntax.
public class ImplicitAnimationCollection : Windows.UI.Composition.CompositionObject, Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, Windows.UI.Composition.ICompositionAnimationBase>>, Windows.Foundation.Collections.IMap<System.String, Windows.UI.Composition.ICompositionAnimationBase>, Windows.UI.Composition.IImplicitAnimationCollection
-->

# Windows.UI.Composition.ImplicitAnimationCollection

## -description
A collection of animations triggered when a condition is met.



## -remarks

Implicit animations let you drive animations by specifying trigger conditions rather than requiring the manual definition of animation behavior. They help decouple animation start logic from core app logic. You define animations and the events that should trigger these animations. The compositor then executes the set animations when the appropriate trigger conditions are met.

### Triggers

Condition act as triggers for ImplicitAnimationCollection. These triggers are CompositionObject animatable properties. For Windows 10 Anniversary Update only Visual animatable properties are supported as triggers.

### this.FinalValue

This is a special keyword within “Composition Expressions system” that developers can use to template their animations and let the platform bind it to the target property’s API value.

Animations will support this.FinalValue keyword as a valid keyword to signify the final value of a target property for an animation.

+ Implicit Animations – The 
    **this.FinalValue**
   will be set to the last value that the corresponding target property was directly assigned to. For instance, when the visual’s 
    **Offset**
   property is directly assigned to, implicit animations that target the 
    **Offset**
   property will have 
    **this.FinalValue**
   set to the new 
    **Offset**
   value, of type Vector3. Other implicit animations that target different properties, say 
    **Size**
  , will still be able to use the 
    **this.FinalValue**
   in the template, and in that case 
    **this.FinalValue**
   will be set to the current value of the 
    **Size**
   property, of type Vector2. Note that in the latter case 
    **this.FinalValue**
   will be the same as 
    **this.StartingValue**
  . This provides a well-defined behavior and makes it easy for the developers to author the animation templates as 
    **this.FinalValue**
   will always be resolved to a valid value, regardless of which property has triggered the change.
+ Explicit Animations: By default it will have the same behavior as the implicit animation’s case, where 
    **this.FinalValue**
   will be set to the last value that the property was directly set to. For example, animations that target the 
    **Size**
   property will have 
    **this.FinalValue**
   resolved to the last known 
    **Size**
   value on the API layer. In other words, 
    **this.FinalValue**
   will be the same as 
    **this.StartingValue**
  . The developer will be able to override that behavior and set 
    **this.FinalValue**
   to a different value by setting it as an animation parameter explicitly.


### Events and target properties for ImplicitAnimationCollection and CompositionAnimationGroup

ImplicitAnimationCollection lets you add triggers which implicit animation will monitor for changes and kick off related animations as provided by the developer. ImplicitAnimationCollection supports all Visual animatable properties which are also used as target properties for animations. Target has to be defined on the animation or it will throw an exception.

```

implicitAnimationCollection[“Offset”] = offsetAnimationGroup;            
            
```

[CompositionAnimationGroup](compositionanimationgroup.md) contains a list of [CompositionAnimation](compositionanimation.md) where they can be triggered as a single logical unit. Each [CompositionAnimation](compositionanimation.md) in the group should have the target property set.

```

CompositionAnimationGroup.Add(opacityKeyFrameAnimation);
CompositionAnimationGroup.Insert(sizeKeyFrameAnimation);
        
```

ImplicitAnimationCollection supports the following properties on [Visual](visual.md):

+ [AnchorPoint](visual_anchorpoint.md)
+ [CenterPoint](visual_centerpoint.md)
+ [Offset](visual_offset.md)
+ [Opacity](visual_opacity.md)
+ [Orientation](visual_orientation.md)
+ [RotationAngle](visual_rotationangle.md)
+ [RotationAngleInDegrees](visual_rotationangleindegrees.md)
+ [RotationAxis](visual_rotationaxis.md)
+ [Scale](visual_scale.md)
+ [Size](visual_size.md)
If the same value is set again then animation will not occur as there was not delta between previous and new value.

## -examples
```csharp

class PropertyAnimation 
{ 
  PropertyAnimation(Compositor compositor, SpriteVisual heroVisual, SpriteVisual listVisual) 
  { 
    // Define ImplicitAnimationCollection 
    ImplicitAnimationCollection implicitAnimations = compositor.CreateImplicitAnimationCollection(); 

    // Trigger animation when the “Offset” property changes. 
    implicitAnimations["Offset"] = CreateAnimation(compositor); 

    // Assign ImplicitAnimations to a visual. Unlike Visual.Children,     
    // ImplicitAnimations can be shared by multiple visuals so that they  
    // share the same implicit animation behavior (same as Visual.Clip). 
    heroVisual.ImplicitAnimations = implicitAnimations; 

    // ImplicitAnimations can be shared among visuals  
    listVisual.ImplicitAnimations = implicitAnimations; 

    listVisual.Offset = new Vector3(20f, 20f, 20f); 
  } 

  Vector3KeyFrameAnimation CreateAnimation(Compositor compositor) 
  { 
    Vector3KeyFrameAnimation animation = compositor.CreateVector3KeyFrameAnimation(); 
    animation.InsertExpressionKeyFrame(0f, "this.StartingValue"); 
    animation.InsertExpressionKeyFrame(1f, "this.FinalValue"); 
    animation.Target = “Offset”; 
    animation.Duration = TimeSpan.FromSeconds(0.25); 
    return animation; 
  } 
} 
         
         
```



## -see-also
[CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md), [IMap(String, ICompositionAnimationBase)](../windows.foundation.collections/imap_2.md), [IIterable(IKeyValuePair)](../windows.foundation.collections/iiterable_1.md)
