---
-api-id: P:Windows.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames.EnableDependentAnimation
-api-type: winrt property
---

<!-- Property syntax
public bool EnableDependentAnimation { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.PointAnimationUsingKeyFrames.EnableDependentAnimation

## -description
Gets or sets a value that declares whether animated properties that are considered dependent animations should be permitted to use this animation declaration.



## -xaml-syntax
```xaml
<PointAnimationUsingKeyFrames EnableDependentAnimation="bool" />
```


## -property-value
**true** if the animation can be used for a dependent animation case. **false** if the animation cannot be used for a dependent animation case. The default is **false**.

## -remarks
### What's considered a dependent animation?

Not all custom animations you create can run by default in a Windows Runtime app, if the animation system determines that the animation might cause bad performance in your UI. Animations where the system determines there could be a performance impact are called *dependent animations*. It's dependent because your animation is actively and frequently updating objects on the UI thread, which is also where current user input and other programmatic updates are making runtime changes to UI.

A dependent animation that's consuming extensive system resources on the UI thread can make the app appear unresponsive in certain situations. If your animation causes a layout change or otherwise has the potential to impact performance on the UI thread, you often need to explicitly enable the animation to see it run. That's what the **EnableDependentAnimation** property on specific animation classes is for. Use this property with caution, because setting it to **true** means you are deliberately acknowledging that the animation might slow down other operations on the UI thread when it runs.

For more info, see [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations). That topic includes a list of the criteria for an independent animation. An animation is a dependent animation if it doesn't satisfy at least one of those criteria. For the specific property you intend to animate, and for the specifics of your animation, compare your intended animation to the criteria to see whether it would be considered dependent or independent by the system.

Another way to discover whether your animations are dependent is that you might receive a warning from your XAML design surface or tool after you compose that animation, and the warning indicates that you'll need to set **EnableDependentAnimation** to **true** to see your animation run.

As an app developer, you can also choose to apply an app-wide setting that always disables dependent animations, even those where **EnableDependentAnimation** is **true**. See [Timeline.AllowDependentAnimations](timeline_allowdependentanimations.md). This is useful to you as an app developer if you're consuming controls where the templates have dependent animations, and you've identified that as a performance problem, but you don't want to have to retemplate the whole control to turn those animations off.

## -examples

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10))
