---
-api-id: T:Windows.UI.Xaml.VisualStateGroup
-api-type: winrt class
---

<!-- Class syntax.
public class VisualStateGroup : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.IVisualStateGroup
-->

# Windows.UI.Xaml.VisualStateGroup

## -description
Contains mutually exclusive [VisualState](visualstate.md) objects and [VisualTransition](visualtransition.md) objects that are used to go from one state to another.

## -xaml-syntax
```xaml
<VisualStateManager.VisualStateGroups>
   <VisualStateGroup x:Name="groupname" ...>
     oneOrMoreVisualStates
   </VisualStateGroup>
   <!--- other peer VisualStateGroup's here ... -->
</VisualStateManager.VisualStateGroups>
```


## -remarks
Each [VisualStateGroup](visualstategroup.md) declared in XAML as part of a control template should always have an [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) set on it. Each name string used in the set of [VisualStateGroups](visualstatemanager_visualstategroups.md) in a control template must be unique in that template. It's common to use the same group names for different controls though. For example, almost all existing control templates have a [VisualStateGroup](visualstategroup.md) with [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) of "CommonStates".

The set of visual states within each [VisualStateGroup](visualstategroup.md) should be mutually exclusive in the group. In other words, the control should be using exactly one of the visual states from each of its defined [VisualStateGroup](visualstategroup.md) groups at all times. Whenever there's a case where a control is intended to be simultaneously in two states, make sure that the two states are in different groups. For example, it's possible for a drop-down control to simultaneously be focused and have its drop-down open. In a correct visual state design, you'd have a separate [VisualStateGroup](visualstategroup.md) for each state so they can both be active at once. Such groups might have names like "FocusStates" and "DropDownStates".

Whenever you define a [VisualStateGroup](visualstategroup.md) that enables a temporary storyboarded behavior in one of its [VisualState](visualstate.md) elements, make sure that group also contains a second [VisualState](visualstate.md) that can be called to cancel the previous state. This can be as simple as declaring the second [VisualState](visualstate.md) with no [Storyboard](visualstate_storyboard.md) at all, just an [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d).

The [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) value you set for a [VisualStateGroup](visualstategroup.md) is not used for a call to [VisualStateManager.GoToState](visualstatemanager_gotostate.md); instead it's the [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) of a [VisualState](visualstate.md) that is used for [VisualStateManager.GoToState](visualstatemanager_gotostate.md). Anyone that uses [VisualStateManager.GoToState](visualstatemanager_gotostate.md) should be aware of all the groups and states available, so that each call correctly transitions from old states to new states within a group.

In addition to a set of [VisualState](visualstate.md) elements, a [VisualStateGroup](visualstategroup.md) can also define a set of [VisualTransition](visualtransition.md) elements, where each [VisualTransition](visualtransition.md) pertains to at least one of the named [VisualState](visualstate.md) elements defined in the group. In XAML, the set of [VisualState](visualstate.md) elements can be declared as immediate object element child elements of the [VisualStateGroup](visualstategroup.md). This is possible because the [States](visualstategroup_states.md) property, which is the collection of visual states, is the XAML content property for [VisualStateGroup](visualstategroup.md). In contrast, to set the collection of visual transitions, you must declare that collection within a [VisualStateGroup.Transitions](visualstategroup_transitions.md) property element in XAML. For more info on XAML content properties, see [XAML syntax guide](http://msdn.microsoft.com/library/a57fe7b4-9947-4aa0-bc99-5fe4686b611d).

###  **VisualStateGroup**  API that support custom **VisualStateManager** implementation

Many of the API of [VisualStateGroup](visualstategroup.md) exist only to support custom [VisualStateManager](visualstatemanager.md) implementation. These include: [Name](visualstategroup_name.md), [CurrentState](visualstategroup_currentstate.md), [CurrentStateChanging](visualstategroup_currentstatechanging.md), [CurrentStateChanged](visualstategroup_currentstatechanged.md). Most common usages of visual states for control templates won't need these API. In particular it's not typical to handle the events. Most logic operations for a control should involve its own properties and events. For most app and control definition scenarios, visual state changes that happen to the control should only be an end result of logic that the control applies to its template, not a trigger for other logic.

## -examples
This example creates a simple [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) for a [Button](../windows.ui.xaml.controls/button.md) that contains one [Grid](../windows.ui.xaml.controls/grid.md). It also contains a [VisualStateGroup](visualstategroup.md) called "CommonStates", which defines the "PointerOver" and "Normal" states. The [VisualStateGroup](visualstategroup.md) also has a [VisualTransition](visualtransition.md) that specifies that it takes one half second for the [Grid](../windows.ui.xaml.controls/grid.md) to change from green to red when the user puts the pointer over the [Button](../windows.ui.xaml.controls/button.md).



[!code-xml[11](../windows.ui.xaml.data/code/StylingTemplatingOverview/csharp/ButtonStages.xaml#Snippet11)]

## -see-also
[DependencyObject](dependencyobject.md), [VisualStateManager](visualstatemanager.md), [VisualState](visualstate.md), [Quickstart: Control templates](http://msdn.microsoft.com/library/67c424ae-afb1-4560-a6a8-4a3506775d77), [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4), [XAML control and app styling sample](http://go.microsoft.com/fwlink/p/?LinkID=258670)
