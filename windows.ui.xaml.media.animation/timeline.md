---
-api-id: T:Windows.UI.Xaml.Media.Animation.Timeline
-api-type: winrt class
---

<!-- Class syntax.
public class Timeline : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.Animation.ITimeline
-->

# Windows.UI.Xaml.Media.Animation.Timeline

## -description
Defines a duration and other behavior properties for a Windows Runtime animation. Timeline is the base class for [Storyboard](storyboard.md) and all the Windows Runtime animation types, including those from the animation library and those used for custom animations in visual states or page-level XAML.



## -remarks
Timeline defines the [Duration](timeline_duration.md) property that controls how long an animation runs once started. Timeline also defines these behavior properties, which are common to all animations types, and to [Storyboard](storyboard.md):
+ [AutoReverse](timeline_autoreverse.md)
+ [BeginTime](timeline_begintime.md)
+ [FillBehavior](timeline_fillbehavior.md)
+ [RepeatBehavior](repeatbehavior.md)
+ [SpeedRatio](timeline_speedratio.md) (not commonly used)


Timeline also defines the [Completed](timeline_completed.md) event for [Storyboard](storyboard.md) and animations. Handling the [Completed](timeline_completed.md) event isn't necessary or most UI animation scenarios.

The relationship between [Storyboard](storyboard.md) and the animation types is that a [Storyboard](storyboard.md) is a container that can group multiple animations, and acts as the controller for starting and stopping the contained animations. When you set Timeline properties on a [Storyboard](storyboard.md) as opposed to individual animations within a [Storyboard](storyboard.md), the Timeline properties set in the [Storyboard](storyboard.md) typically override those from the combined animations. For more info see [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations).

Timeline has a strongly typed collection class that is used for properties that take a set of Timeline values, such as [Storyboard.Children](storyboard_children.md). For more info see [TimelineCollection](timelinecollection.md).

### **Timeline** derived classes

Timeline is the parent class for several immediately derived classes that support the storyboarded animation system and also the built-in library animations. Here are some of the notable derived classes:

+ [Storyboard](storyboard.md): A container and controller for other storyboarded animations that each target a particular object and property.
+ Typed animations: Each of these is used to animate a property that takes a particular value type, or an object. + [ColorAnimation](coloranimation.md), [ColorAnimationUsingKeyFrames](coloranimationusingkeyframes.md)
+ [DoubleAnimation](doubleanimation.md), [DoubleAnimationUsingKeyFrames](doubleanimationusingkeyframes.md)
+ [ObjectAnimationUsingKeyFrames](objectanimationusingkeyframes.md)
+ [PointAnimation](pointanimation.md), [PointAnimationUsingKeyFrames](pointanimationusingkeyframes.md)

+ Theme animations: These are animations defined by the animation library that you use for common UI interactions.+ [DragItemThemeAnimation](dragitemthemeanimation.md)
+ [DragOverThemeAnimation](dragoverthemeanimation.md)
+ [DropTargetItemThemeAnimation](droptargetitemthemeanimation.md)
+ [FadeInThemeAnimation](fadeinthemeanimation.md)
+ [FadeOutThemeAnimation](fadeoutthemeanimation.md)
+ [PointerDownThemeAnimation](pointerdownthemeanimation.md)
+ [PointerUpThemeAnimation](pointerupthemeanimation.md)
+ [PopInThemeAnimation](popinthemeanimation.md)
+ [PopOutThemeAnimation](popoutthemeanimation.md)
+ [RepositionThemeAnimation](repositionthemeanimation.md)
+ [SplitCloseThemeAnimation](splitclosethemeanimation.md)
+ [SplitOpenThemeAnimation](splitopenthemeanimation.md)
+ [SwipeBackThemeAnimation](swipebackthemeanimation.md)
+ [SwipeHintThemeAnimation](swipehintthemeanimation.md)


> [!NOTE]
> Theme transitions don't derive from Timeline, they derive from [Transition](transition.md).


## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [Storyboard](storyboard.md), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations)
