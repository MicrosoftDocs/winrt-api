---
-api-id: P:Windows.UI.Xaml.VisualStateGroup.CurrentState
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.VisualState CurrentState { get; }
-->

# Windows.UI.Xaml.VisualStateGroup.CurrentState

## -description
Gets the most recently set [VisualState](visualstate.md) from a successful call to the [GoToState](visualstatemanager_gotostate_443481648.md) method.



## -property-value
The most recently set [VisualState](visualstate.md) from a successful call to the [GoToState](visualstatemanager_gotostate_443481648.md) method, or **null**.

## -remarks
If [GoToState](visualstatemanager_gotostate_443481648.md) has never been called for the states in a particular [VisualStateGroup](visualstategroup.md), CurrentState is **null**. With correct design of controls and visual state, this shouldn't happen. The control logic for a control should always be able to select one state from a given [VisualStateGroup](visualstategroup.md), even if that state is a named state with no specific storyboarded behavior.

Because there are potentially multiple [VisualStateGroup](visualstategroup.md) sets of visual states for a control, each such [VisualStateGroup](visualstategroup.md) can report a CurrentState. For example, if you click on a [Button](../windows.ui.xaml.controls/button.md) with a default control template, the "CommonStates"  [VisualStateGroup](visualstategroup.md) reports a CurrentState of "Pressed", and the "FocusStates"  [VisualStateGroup](visualstategroup.md) reports a CurrentState of "PointerFocused".

## -examples

## -see-also
[VisualState](visualstate.md), [GoToState](visualstatemanager_gotostate_443481648.md), [CurrentStateChanged](visualstategroup_currentstatechanged.md), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10))
