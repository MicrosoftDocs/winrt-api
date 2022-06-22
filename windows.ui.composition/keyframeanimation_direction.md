---
-api-id: P:Windows.UI.Composition.KeyFrameAnimation.Direction
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Composition.AnimationDirection Direction { get;  set; }
-->

# Windows.UI.Composition.KeyFrameAnimation.Direction

## -description
The direction the animation is playing.

The 
    **Direction**
   property allows you to drive your animation from start to end or end to start or alternate between start and end or end to start if animation has an [IterationCount](keyframeanimation_iterationcount.md) greater than one. This gives an easy way for customizing animation definitions.



## -property-value
The direction the animation is playing.

## -remarks
Given an offset animation with an iteration count of 3 and two keyframes (0, and 1) with a value of Vector3(5,5,5) for keyframe 0 and a value of Vector3(20,20,20) for keyframe 1, the following table shows the animation behavior with different values for Direction.

<table>
   <tr><th>Direction</th><th>Animation Behavior</th></tr>
   <tr><td>Normal</td><td>Animation will start from offset value Vector3(5,5,5) and go to Vector3(20,20,20), repeating 3 times always starting from (5,5,5).</td></tr>
   <tr><td>Reverse</td><td>Animation will start in reverse and offset value (20,20,20) and goes to (5,5,5) repeating 3 times always starting from (20,20,20).</td></tr>
   <tr><td>Alternate</td><td>For the first iteration the animation will start from offset value (5,5,5) and go to (20,20,20). In the second iteration animation the animation will start from offset value (20,20,20) and go to (5,5,5). In third and final iteration the animation will start from offset (5,5,5) and go to (20,20,20).</td></tr>
   <tr><td>AlternateReverse</td><td>For the first iteration the animation will start from offset value (20,20,20) and go to (5,5,5). In the second iteration the animation will start from offset value (5,5,5) and go to (20, 20, 20). In the third and final iteration the animation will start from offset (20, 20, 20) and go to (5,5,5).</td></tr>
</table>

## -examples
AnimationDirection is Normal

```csharp

class Direction 
{ 
  Direction(Compositor compositor, SpriteVisual heroVisual) 
  { 
    Vector3KeyFrameAnimation animation = compositor.CreateVector3KeyFrameAnimation(); 
    animation.InsertKeyFrame(0f, new Vector3(0f,0f,0f)); 
    animation.InsertKeyFrame(1f, new Vector3(20f,20f,0f)); 
    animation.Duration = TimeSpan.FromSeconds(0.25); 

    // Run animation for 4 times 
    animation.IterationCount = 4; 

    // Direction of animation is normal i.e. forward. 
    animation.Direction = AnimationDirection.Normal; 

    heroVisual.StartAnimation("Offset", animation); 
  } 
} 
          
          
```

AnimationDirection is Reverse

```csharp

class Direction 
{ 
  Direction(Compositor compositor, SpriteVisual heroVisual) 
  { 
    Vector3KeyFrameAnimation animation = compositor.CreateVector3KeyFrameAnimation(); 
    animation.InsertKeyFrame(0f, new Vector3(0f,0f,0f)); 
    animation.InsertKeyFrame(1f, new Vector3(20f,20f,0f)); 
    animation.Duration = TimeSpan.FromSeconds(0.25); 

    // Run animation for 4 times 
    animation.IterationCount = 4; 

    // Direction of animation is Reverse i.e. end to start. 
    animation.Direction = AnimationDirection.Reverse; 

    heroVisual.StartAnimation("Offset", animation); 
  } 
} 
          
```

AnimationDirection is Alternate

```csharp

class Direction 
{ 
  Direction(Compositor compositor, SpriteVisual heroVisual) 
  { 
    Vector3KeyFrameAnimation animation = compositor.CreateVector3KeyFrameAnimation(); 
    animation.InsertKeyFrame(0f, new Vector3(0f,0f,0f)); 
    animation.InsertKeyFrame(1f, new Vector3(20f,20f,0f)); 
    animation.Duration = TimeSpan.FromSeconds(0.25); 

    // Run animation for 4 times 
    animation.IterationCount = 4; 

    // Direction of animation is alternate i.e. start to end and then end to start and so on. 
    animation.Direction = AnimationDirection.Alternate; 

    heroVisual.StartAnimation("Offset", animation); 
  } 
} 
          
```

AnimationDirection is AlternateReverse

```csharp

class Direction 
{ 
  Direction(Compositor compositor, SpriteVisual heroVisual) 
  { 
    Vector3KeyFrameAnimation animation = compositor.CreateVector3KeyFrameAnimation(); 
    animation.InsertKeyFrame(0f, new Vector3(0f,0f,0f)); 
    animation.InsertKeyFrame(1f, new Vector3(20f,20f,0f)); 
    animation.Duration = TimeSpan.FromSeconds(0.25); 

    // Run animation for 4 times 
    animation.IterationCount = 4; 

    // Direction of animation is alternate-reverse i.e. end to start and then start to end and so on. 
    animation.Direction = AnimationDirection.AlternateReverse; 

    heroVisual.StartAnimation("Offset", animation); 
  } 
} 
          
```



## -see-also
