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
Each VisualStateGroup declared in XAML as part of a control template should always have an [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) set on it. Each name string used in the set of [VisualStateGroups](/dotnet/api/system.windows.visualstatemanager.visualstategroups) in a control template must be unique in that template. It's common to use the same group names for different controls though. For example, almost all existing control templates have a VisualStateGroup with [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) of "CommonStates".

The set of visual states within each VisualStateGroup should be mutually exclusive in the group. In other words, the control should be using exactly one of the visual states from each of its defined VisualStateGroup groups at all times. Whenever there's a case where a control is intended to be simultaneously in two states, make sure that the two states are in different groups. For example, it's possible for a drop-down control to simultaneously be focused and have its drop-down open. In a correct visual state design, you'd have a separate VisualStateGroup for each state so they can both be active at once. Such groups might have names like "FocusStates" and "DropDownStates".

Whenever you define a VisualStateGroup that enables a temporary storyboarded behavior in one of its [VisualState](visualstate.md) elements, make sure that group also contains a second [VisualState](visualstate.md) that can be called to cancel the previous state. This can be as simple as declaring the second [VisualState](visualstate.md) with no [Storyboard](visualstate_storyboard.md) at all, just an [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute).

The [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) value you set for a VisualStateGroup is not used for a call to [VisualStateManager.GoToState](visualstatemanager_gotostate_443481648.md); instead it's the [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) of a [VisualState](visualstate.md) that is used for [VisualStateManager.GoToState](visualstatemanager_gotostate_443481648.md). Anyone that uses [VisualStateManager.GoToState](visualstatemanager_gotostate_443481648.md) should be aware of all the groups and states available, so that each call correctly transitions from old states to new states within a group.

In addition to a set of [VisualState](visualstate.md) elements, a VisualStateGroup can also define a set of [VisualTransition](visualtransition.md) elements, where each [VisualTransition](visualtransition.md) pertains to at least one of the named [VisualState](visualstate.md) elements defined in the group. In XAML, the set of [VisualState](visualstate.md) elements can be declared as immediate object element child elements of the VisualStateGroup. This is possible because the [States](visualstategroup_states.md) property, which is the collection of visual states, is the XAML content property for VisualStateGroup. In contrast, to set the collection of visual transitions, you must declare that collection within a [VisualStateGroup.Transitions](visualstategroup_transitions.md) property element in XAML. For more info on XAML content properties, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

When using [StateTriggers](visualstate_statetriggers.md) to control visual states, the trigger engine uses the following precedence rules to score triggers and determine which trigger, and the corresponding [VisualState](visualstate.md), will be active:
1. Custom trigger that derives from [StateTriggerBase](statetriggerbase.md)
2. [AdaptiveTrigger](adaptivetrigger.md) activated due to [MinWindowWidth](adaptivetrigger_minwindowwidth.md)
3. [AdaptiveTrigger](adaptivetrigger.md) activated due to [MinWindowHeight](adaptivetrigger_minwindowheight.md)

If there are multiple active triggers at a time that have a conflict in scoring (i.e. two active custom triggers), then the first one declared in the markup file takes precedence.

Note: While [AdaptiveTrigger](adaptivetrigger.md) does derive from [StateTriggerBase](statetriggerbase.md), it can only be activated through setting [MinWindowWidth](adaptivetrigger_minwindowwidth.md) and/or [MinWindowHeight](adaptivetrigger_minwindowheight.md).

###  **VisualStateGroup**  API that support custom **VisualStateManager** implementation

Many of the API of VisualStateGroup exist only to support custom [VisualStateManager](visualstatemanager.md) implementation. These include: [Name](visualstategroup_name.md), [CurrentState](visualstategroup_currentstate.md), [CurrentStateChanging](visualstategroup_currentstatechanging.md), [CurrentStateChanged](visualstategroup_currentstatechanged.md). Most common usages of visual states for control templates won't need these API. In particular it's not typical to handle the events. Most logic operations for a control should involve its own properties and events. For most app and control definition scenarios, visual state changes that happen to the control should only be an end result of logic that the control applies to its template, not a trigger for other logic.

## -examples
This example creates a simple [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) for a [Button](../windows.ui.xaml.controls/button.md) that contains one [Grid](../windows.ui.xaml.controls/grid.md). It also contains a VisualStateGroup called "CommonStates", which defines the "PointerOver" and "Normal" states. The VisualStateGroup also has a [VisualTransition](visualtransition.md) that specifies that it takes one half second for the [Grid](../windows.ui.xaml.controls/grid.md) to change from green to red when the user puts the pointer over the [Button](../windows.ui.xaml.controls/button.md).



[!code-xaml[11](../windows.ui.xaml.data/code/StylingTemplatingOverview/csharp/ButtonStages.xaml#Snippet11)]

## -see-also
[DependencyObject](dependencyobject.md), [VisualStateManager](visualstatemanager.md), [VisualState](visualstate.md), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)), [XAML control and app styling sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20control%20and%20app%20styling%20sample/C%23)
