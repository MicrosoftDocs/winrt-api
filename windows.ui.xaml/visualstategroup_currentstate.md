---
-api-id: P:Windows.UI.Xaml.VisualStateGroup.CurrentState
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.VisualState CurrentState { get; }
-->

# Windows.UI.Xaml.VisualStateGroup.CurrentState

## -description
Gets the most recently set [VisualState](visualstate.md) from a successful call to the [GoToState](visualstatemanager_gotostate.md) method.

## -property-value
The most recently set [VisualState](visualstate.md) from a successful call to the [GoToState](visualstatemanager_gotostate.md) method, or **null**.

## -remarks
If [GoToState](visualstatemanager_gotostate.md) has never been called for the states in a particular [VisualStateGroup](visualstategroup.md), [CurrentState](visualstategroup_currentstate.md) is **null**. With correct design of controls and visual state, this shouldn't happen. The control logic for a control should always be able to select one state from a given [VisualStateGroup](visualstategroup.md), even if that state is a named state with no specific storyboarded behavior.

Because there are potentially multiple [VisualStateGroup](visualstategroup.md) sets of visual states for a control, each such [VisualStateGroup](visualstategroup.md) can report a [CurrentState](visualstategroup_currentstate.md). For example, if you click on a [Button](../windows.ui.xaml.controls/button.md) with a default control template, the "CommonStates"  [VisualStateGroup](visualstategroup.md) reports a [CurrentState](visualstategroup_currentstate.md) of "Pressed", and the "FocusStates"  [VisualStateGroup](visualstategroup.md) reports a [CurrentState](visualstategroup_currentstate.md) of "PointerFocused".

## -examples

## -see-also
[VisualState](visualstate.md), [GoToState](visualstatemanager_gotostate.md), [CurrentStateChanged](visualstategroup_currentstatechanged.md), [Quickstart: Control templates](http://msdn.microsoft.com/library/67c424ae-afb1-4560-a6a8-4a3506775d77)