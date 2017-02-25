---
-api-id: P:Windows.UI.Xaml.VisualState.Storyboard
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.Storyboard Storyboard { get;  set; }
-->

# Windows.UI.Xaml.VisualState.Storyboard

## -description
Gets or sets a [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) that defines state-specific property values and appearance of the control when it is using this visual state.

## -xaml-syntax
```xaml
<VisualState>
  singleStoryboard
</VisualState>
```


## -xaml-values
<dl><dt>singleStoryboard</dt><dd>singleStoryboardA single Storyboard object element, which declares the animation storyboard to use for this state.</dd>
</dl>
## -property-value
A [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) that defines the property changes to apply to the control when this [VisualState](visualstate.md) is used as the current visual state.

## -remarks
The value of the [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) property is either **null** or a single [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) object. A [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) is like a container for animations; it can contain one or more animation definitions. Each such animation can target a specific dependency property on a specific named target. The named target must be an element in the control template that has a [Name](frameworkelement_name.md) or [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) value defined in the template itself. The dependency property must be a property that exists in that object's object model, or an attached property. To target animations, you use the [Storyboard.TargetName](../windows.ui.xaml.media.animation/storyboard_targetname.md) and [Storyboard.TargetProperty](../windows.ui.xaml.media.animation/storyboard_targetproperty.md) attached properties. For more info on how to define animations with XAML syntax, and the types of animations you can use, see [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).

Animations that affect layout are potentially dependent animations, which can have performance consequences for users of your control when the control loads a [VisualState](visualstate.md). For more info, see [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4).

## -examples
This example creates a simple [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) for a [Button](../windows.ui.xaml.controls/button.md) that contains one [Grid](../windows.ui.xaml.controls/grid.md). The [VisualState](visualstate.md) with the [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) value of "PointerOver" has a [Storyboard](../windows.ui.xaml.media.animation/storyboard.md) that changes the color of the button content (a [Grid](../windows.ui.xaml.controls/grid.md)) from green to red when the user puts the pointer over the [Button](../windows.ui.xaml.controls/button.md). The [VisualState](visualstate.md) with the [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) value of "Normal" is included so that when the user moves the pointer off the button, the [Grid](../windows.ui.xaml.controls/grid.md) background returns to green.



[!code-xml[11](../windows.ui.xaml.data/code/StylingTemplatingOverview/csharp/ButtonStages.xaml#Snippet11)]

## -see-also
[Storyboard](../windows.ui.xaml.media.animation/storyboard.md), [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4), [Quickstart: Control templates](http://msdn.microsoft.com/library/67c424ae-afb1-4560-a6a8-4a3506775d77), [XAML control and app styling sample](http://go.microsoft.com/fwlink/p/?LinkID=258670)
