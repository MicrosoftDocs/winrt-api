---
-api-id: P:Windows.UI.Xaml.VisualTransition.Storyboard
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.Storyboard Storyboard { get;  set; }
-->

# Windows.UI.Xaml.VisualTransition.Storyboard

## -description
Gets or sets the [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) that runs when the transition occurs.

## -xaml-syntax
```xaml
<VisualTransition>
  singleStoryboard
</VisualTransition>
```


## -xaml-values
<dl><dt>singleStoryboard</dt><dd>singleStoryboardExactly one Storyboard object element.</dd>
</dl>
## -property-value
The [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) that occurs when the transition occurs.

## -remarks
The value of the [Storyboard](visualtransition_storyboard.md) property is either null or a single [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) object. A [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) is like a container for animations, it can contain one or more animation definitions. Each such animation can target a specific dependency property on a specific named target. The named target must be an element in the control template that has a [Name](frameworkelement_name.md) or [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) value defined in the template itself. The dependency property must be a property that exists in that object's object model, or must be an attached property. To target animations, you use the [Storyboard.TargetName](../windows.ui.xaml.media.animation/storyboard_targetname.md) and [Storyboard.TargetProperty](../windows.ui.xaml.media.animation/storyboard_targetproperty.md) attached properties. For more info on how to define animations with XAML syntax, and the types of animations you can use, see [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).

The properties you target using animations in [VisualTransition.Storyboard](visualtransition_storyboard.md) are not limited to[Point](../windows.foundation/point.md), [Color](../windows.ui/color.md), or [Double](https://msdn.microsoft.com/library/system.double.aspx). You can use [ObjectAnimationUsingKeyFrames](../windows.ui.xaml.media.animation/objectanimationusingkeyframes.md) and [DiscreteObjectKeyFrame](../windows.ui.xaml.media.animation/discreteobjectkeyframe.md).

If you have a value for [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), you can choose to omit a value for [GeneratedDuration](visualtransition_generatedduration.md). Instead, set specific [Duration](duration.md) values on the animations in the [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) or the main [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) element within it. If you do set a [GeneratedDuration](visualtransition_generatedduration.md) value, it won't truncate or change any [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) with a [Duration](../windows.ui.xaml.media.animation/timeline_duration.md) value; the total length of the transition is the longest [Duration](../windows.ui.xaml.media.animation/timeline_duration.md) value that you've set in the animations for [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), or the [GeneratedDuration](visualtransition_generatedduration.md), whichever is longer.

### Implicit transitions

You can define a [VisualTransition](visualtransition.md) such that it has a [GeneratedDuration](visualtransition_generatedduration.md), but does not have a [Storyboard](visualtransition_storyboard.md) value. This creates an implicit transition that can interpolate values that are different between two states. For more info, see [GeneratedDuration](visualtransition_generatedduration.md).

## -examples

## -see-also
[GoToState](visualstatemanager_gotostate.md), [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), [Quickstart: Control templates](http://msdn.microsoft.com/library/67c424ae-afb1-4560-a6a8-4a3506775d77), [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4)