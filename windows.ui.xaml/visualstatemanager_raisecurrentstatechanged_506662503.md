---
-api-id: M:Windows.UI.Xaml.VisualStateManager.RaiseCurrentStateChanged(Windows.UI.Xaml.VisualStateGroup,Windows.UI.Xaml.VisualState,Windows.UI.Xaml.VisualState,Windows.UI.Xaml.Controls.Control)
-api-type: winrt method
---

<!-- Method syntax
protected void RaiseCurrentStateChanged(Windows.UI.Xaml.VisualStateGroup stateGroup, Windows.UI.Xaml.VisualState oldState, Windows.UI.Xaml.VisualState newState, Windows.UI.Xaml.Controls.Control control)
-->

# Windows.UI.Xaml.VisualStateManager.RaiseCurrentStateChanged

## -description
When overridden in a derived class, fires the [CurrentStateChanged](visualstategroup_currentstatechanged.md) event on the specified [VisualStateGroup](visualstategroup.md).



## -parameters
### -param stateGroup
The object on which the [CurrentStateChanging](visualstategroup_currentstatechanging.md) event occurred.

### -param oldState
The state that the control transitions from.

### -param newState
The state that the control transitions to.

### -param control
The control that transitioned states.

## -remarks
This API is part of the scenario of defining a custom [VisualStateManager](visualstatemanager.md) behavior. The most important method to override in this scenario is [GoToStateCore](visualstatemanager_gotostatecore_681569745.md), because it's that method that changes the state behavior in your custom class behavior. Overriding the behavior of RaiseCurrentStateChanged and [RaiseCurrentStateChanging](visualstatemanager_raisecurrentstatechanging_642620570.md) is optional: how and when the events are raised by the default implementation might be adequate for your custom class.

## -examples

## -see-also
