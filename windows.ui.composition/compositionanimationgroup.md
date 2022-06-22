---
-api-id: T:Windows.UI.Composition.CompositionAnimationGroup
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionAnimationGroup : Windows.UI.Composition.CompositionObject, Windows.Foundation.Collections.IIterable<Windows.UI.Composition.CompositionAnimation>, Windows.UI.Composition.ICompositionAnimationBase, Windows.UI.Composition.ICompositionAnimationGroup
-->

# Windows.UI.Composition.CompositionAnimationGroup

## -description
Defines a group of animations.

CompositionAnimationGroup provides a way to group [CompositionAnimation](compositionanimation.md)s in a list which will be started at the same time when [StartAnimationGroup](compositionobject_startanimationgroup_696523374.md) is called on [CompositionObject](compositionobject.md). All CompositionAnimation in CompositionAnimationGroup need to assign a value to the [Target](compositionanimation_target.md) property in the animation itself. CompositionAnimationGroup can also be associated with [ImplicitAnimationCollection](implicitanimationcollection.md) as an animation that gets executed as a result of a trigger.



## -remarks
CompositionAnimationGroup is a list of [CompositionAnimation](compositionanimation.md). Different [CompositionAnimation](compositionanimation.md)s can be added to the group and can be used in [ImplicitAnimationCollection](implicitanimationcollection.md) or start the group using Visual.StartAnimationGroup(CompositionAnimationGroup).

All the [CompositionAnimation](compositionanimation.md)s in CompositionAnimationGroup should have target property assigned as part of animation template.

If CompositionAnimationGroup is changed while iterating the animations in the group, an InvalidOperationException will be thrown.

Use the [CompostionObject.StartAnimationGroup](compositionobject_startanimationgroup_696523374.md) and [CompostionObject.StopAnimationGroup](compositionobject_stopanimationgroup_293483380.md) methods to start and stop the animation group.

## -examples
Implicit Animations usage of Animation Group

```csharp

class PropertyAnimation 
{ 
  PropertyAnimation(Compositor compositor, SpriteVisual heroVisual, Vector2KeyFrameAnimation sizeAnimation, Vector3KeyFrameAnimation OffsetAnimation) 
  { 
  // Define ImplicitAnimations 
  ImplicitAnimationCollection implicitAnimations =  compositor.CreateImplicitAnimationCollection(); 

  // Create AnimationGroup 
  CompositionAnimationGroup animationGroup = compositor.CreateAnimationGroup(); 

  animationGroup.Add(sizeAnimation); 
  animationGroup.Add(offsetAnimation); 

  // Associate the given animation group with the “Size” Change 
  implicitAnimationsCollection["Size"] = animationGroup; 

  // assign ImplicitAnimationCollection to visual 
  heroVisual.ImplicitAnimations = implicitAnimations;  

  // Set the CenterPoint so that rotation will be around the center 
  heroVisual.CenterPoint = new Vector3((heroVisual.Size.X/2.0f), (heroVisual.Size.Y/2.0f), 0.0f); 
} 
         
```

StartAnimationGroup

```csharp

class PropertyAnimation 
{ 
  PropertyAnimation(Compositor compositor, SpriteVisual heroVisual, Vector2KeyFrameAnimation sizeAnimation, Vector3KeyFrameAnimation OffsetAnimation) 
  { 
    // Create AnimationGroup 
    CompositionAnimationGroup animationGroup =  
    compositor.CreateAnimationGroup(); 

    animationGroup.Add(sizeAnimation); 
    animationGroup.Add(offsetAnimation); 
    heroVisual.StartAnimationGroup(animationGroup); 
  }
} 
         
```



## -see-also
[CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md), [IIterable(CompositionAnimation)](../windows.foundation.collections/iiterable_1.md), [ICompositionAnimationBase](icompositionanimationbase.md)
