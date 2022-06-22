---
-api-id: M:Windows.UI.Xaml.VisualStateManager.GoToStateCore(Windows.UI.Xaml.Controls.Control,Windows.UI.Xaml.FrameworkElement,System.String,Windows.UI.Xaml.VisualStateGroup,Windows.UI.Xaml.VisualState,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool GoToStateCore(Windows.UI.Xaml.Controls.Control control, Windows.UI.Xaml.FrameworkElement templateRoot, System.String stateName, Windows.UI.Xaml.VisualStateGroup group, Windows.UI.Xaml.VisualState state, System.Boolean useTransitions)
-->

# Windows.UI.Xaml.VisualStateManager.GoToStateCore

## -description
When overridden in a derived class, transitions a control between states.



## -parameters
### -param control
The control to transition between states.

### -param templateRoot
The root element of the control's [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md).

### -param stateName
The name of the state to transition to.

### -param group
The [VisualStateGroup](visualstategroup.md) that the state belongs to.

### -param state
The representation of the state to transition to.

### -param useTransitions
**true** to use a [VisualTransition](visualtransition.md) to transition between states; otherwise, **false**.

## -returns
**true** if the control successfully transitions to the new state; otherwise, **false**.

## -remarks
This API is part of the scenario of defining a custom [VisualStateManager](visualstatemanager.md) behavior. Overriding GoToStateCore changes the state behavior in your custom class behavior. 

To reference your custom [VisualStateManager](visualstatemanager.md) class, set the value of the [VisualStateManager.CustomVisualStateManager](/uwp/api/windows.ui.xaml.visualstatemanager.customvisualstatemanager) attached property within any control template where you want to use the custom [VisualStateManager](visualstatemanager.md) class behavior. You typically create an instance of the custom [VisualStateManager](visualstatemanager.md) class through default XAML construction in [Application.Resources](application_resources.md). Then the [VisualStateManager.CustomVisualStateManager](/uwp/api/windows.ui.xaml.visualstatemanager.customvisualstatemanager) attached property is set using a [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) reference to the key of the custom [VisualStateManager](visualstatemanager.md) resource.

### Notes to inheritors

When a consumer of your custom [VisualStateManager](visualstatemanager.md) class calls [GoToState](visualstatemanager_gotostate_443481648.md) to change the visual state of a control, this is the default behavior you are overriding:+ If the [VisualState](visualstate.md) as named by *stateName* has a [Storyboard](visualstate_storyboard.md), the storyboard begins.
+ If the [VisualState](visualstate.md) that the control was using prior to the newly requested state has a [Storyboard](visualstate_storyboard.md), that storyboard stops.
If a [VisualState](visualstate.md) for *stateName* doesn't exist in the *group*, your implementation should return **false**.

If the control is already in the [VisualState](visualstate.md) requested as *stateName*, your implementation should return **true**.

For more info on the default behavior, see [GoToState](visualstatemanager_gotostate_443481648.md).

### Events for visual state changes

[CurrentStateChanging](visualstategroup_currentstatechanging.md) fires when the control begins to transition states as requested by the [GoToState](visualstatemanager_gotostate_443481648.md) call. If a [VisualTransition](visualtransition.md) is applied to the state change, this event occurs when the transition begins.

[CurrentStateChanged](visualstategroup_currentstatechanged.md) fires after the control is in the state as requested by the [GoToState](visualstatemanager_gotostate_443481648.md) call, just as the new [Storyboard](visualstate_storyboard.md) begins. No event is fired on the new storyboard's completion.

If a [VisualTransition](visualtransition.md) is not applied, [CurrentStateChanging](visualstategroup_currentstatechanging.md) and [CurrentStateChanged](visualstategroup_currentstatechanged.md) fire in quick succession, but are guaranteed in that order if both occur.

However, if a state change transition is interrupted by a new [GoToState](visualstatemanager_gotostate_443481648.md) call, the [CurrentStateChanged](visualstategroup_currentstatechanged.md) event is never raised for the first state transition. A new event series is fired for the next requested state change.

Overriding the behavior of [RaiseCurrentStateChanged](visualstatemanager_raisecurrentstatechanged_506662503.md) and [RaiseCurrentStateChanging](visualstatemanager_raisecurrentstatechanging_642620570.md) is optional: how and when the events are raised by the default implementation might be adequate for your custom class.

## -examples

## -see-also
[GoToState](visualstatemanager_gotostate_443481648.md), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10))
