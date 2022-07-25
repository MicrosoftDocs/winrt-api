---
-api-id: M:Windows.UI.Composition.CompositionObject.StartAnimationGroup(Windows.UI.Composition.ICompositionAnimationBase)
-api-type: winrt method
---

<!-- Method syntax
public void StartAnimationGroup(Windows.UI.Composition.ICompositionAnimationBase value)
-->

# Windows.UI.Composition.CompositionObject.StartAnimationGroup

## -description
Starts an animation group.

The StartAnimationGroup method on [CompositionObject](compositionobject.md) lets you start [CompositionAnimationGroup](compositionanimationgroup.md). All the animations in the group will be started at the same time on the object.



## -parameters
### -param value
The animation group to start.

## -remarks
StartAnimationGroup takes [CompositionAnimationGroup](compositionanimationgroup.md) as a parameter to start all the animations in the group at the same time on the object. [CompositionAnimation](compositionanimation.md) in the group should have a value assigned to the [Target](compositionanimation_target.md) property.

To get [Completed](compositionscopedbatch_completed.md) events for all the animations, StartAnimationGroup should be called from a [CompositionScopedBatch](compositionscopedbatch.md) with a registered [Completed](compositionscopedbatch_completed.md) event.

## -examples
```csharp

class PropertyAnimation
{
  PropertyAnimation(Compositor compositor, SpriteVisual heroVisual)
  {
    // Define ImplicitAnimations
    ImplicitAnimationCollection implicitAnimations = compositor.CreateImplicitAnimationCollection();
            
    // Animate multiple properties on the target when the “Offset” property changes. 
    CompositionAnimationGroup animationGroup = compositor.CreateCompositionAnimationGroup();

    animationGroup.Add(CreateSizeAnimation(compositor));
    animationGroup.Add(CreateRotationAnimation(compositor));
            
    // Set the CenterPoint so that rotation will be around the center
    heroVisual.CenterPoint = new Vector3((heroVisual.Size.X/2.0f), (heroVisual.Size.Y/2.0f), 0.0f);
     
    // Start AnimationGroup
    heroVisual.StartAnimationGroup(animationGroup);
  }

        
  Vector2KeyFrameAnimation CreateSizeAnimation(Compositor compositor)
  {
    Vector2KeyFrameAnimation animation  = compositor.CreateVector2KeyFrameAnimation();

    CubicBezierEasingFunction easing = compositor.CreateCubicBezierEasingFunction(new Vector2(0.80f, 0.0f), new Vector2(0.95f, 1.0f));
    
    // value (as the animation will target on the “Size” property).
    animation.InsertExpressionKeyFrame(0f, "this.StartingValue", easing);
    animation.InsertExpressionKeyFrame(1f, "this.StartingValue * 2", easing);
    animation.Duration = TimeSpan.FromSeconds(0.25);
    animation.Target = “Size”;

    return animation;
  }

        
  ScalarKeyFrameAnimation CreateRotationAnimation(Compositor compositor)
  {
    ScalarKeyFrameAnimation animation = compositor.CreateScalarKeyFrameAnimation();

    // Create KeyFrameAnimation to animate RotationAngleInDegrees by 90 degrees.	
            
    animation.InsertExpressionKeyFrame(0f, "this.StartingValue”);
    animation.InsertExpressionKeyFrame(1f, "this.StartingValue + 90.0f”);
    animation.Duration = TimeSpan.FromSeconds(0.25);
    animation.Target = “RotationAngleInDegrees”;

    return animation;
  }
}

         
       
```



## -see-also
