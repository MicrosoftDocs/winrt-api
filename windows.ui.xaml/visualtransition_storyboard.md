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
The value of the Storyboard property is either null or a single [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) object. A [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) is like a container for animations, it can contain one or more animation definitions. Each such animation can target a specific dependency property on a specific named target. The named target must be an element in the control template that has a [Name](frameworkelement_name.md) or [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) value defined in the template itself. The dependency property must be a property that exists in that object's object model, or must be an attached property. To target animations, you use the [Storyboard.TargetName](/uwp/api/windows.ui.xaml.media.animation.storyboard.targetname) and [Storyboard.TargetProperty](/uwp/api/windows.ui.xaml.media.animation.storyboard.targetproperty) attached properties. For more info on how to define animations with XAML syntax, and the types of animations you can use, see [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations).

The properties you target using animations in VisualTransition.Storyboard are not limited to[Point](../windows.foundation/point.md), [Color](../windows.ui/color.md), or [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true). You can use [ObjectAnimationUsingKeyFrames](../windows.ui.xaml.media.animation/objectanimationusingkeyframes.md) and [DiscreteObjectKeyFrame](../windows.ui.xaml.media.animation/discreteobjectkeyframe.md).

If you have a value for [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), you can choose to omit a value for [GeneratedDuration](visualtransition_generatedduration.md). Instead, set specific [Duration](duration.md) values on the animations in the [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) or the main [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) element within it. If you do set a [GeneratedDuration](visualtransition_generatedduration.md) value, it won't truncate or change any [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) with a [Duration](../windows.ui.xaml.media.animation/timeline_duration.md) value; the total length of the transition is the longest [Duration](../windows.ui.xaml.media.animation/timeline_duration.md) value that you've set in the animations for [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), or the [GeneratedDuration](visualtransition_generatedduration.md), whichever is longer.

### Implicit transitions

You can define a [VisualTransition](visualtransition.md) such that it has a [GeneratedDuration](visualtransition_generatedduration.md), but does not have a Storyboard value. This creates an implicit transition that can interpolate values that are different between two states. For more info, see [GeneratedDuration](visualtransition_generatedduration.md).

## -examples

## -see-also
[GoToState](visualstatemanager_gotostate_443481648.md), [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10))
