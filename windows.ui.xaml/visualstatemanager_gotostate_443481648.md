---
-api-id: M:Windows.UI.Xaml.VisualStateManager.GoToState(Windows.UI.Xaml.Controls.Control,System.String,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public bool GoToState(Windows.UI.Xaml.Controls.Control control, System.String stateName, System.Boolean useTransitions)
-->

# Windows.UI.Xaml.VisualStateManager.GoToState

## -description
Transitions a control between two states, by requesting a new [VisualState](visualstate.md) by name.



## -parameters
### -param control
The control to transition between states.

### -param stateName
The state to transition to.

### -param useTransitions
**true** to use a [VisualTransition](visualtransition.md) to transition between states. **false** to skip using transitions and go directly to the requested state. The default is **false**.

## -returns
**true** if the control successfully transitions to the new state, or was already using that state; otherwise, **false**.

## -remarks
This method is used by control logic. You typically only need it if you are writing a custom control, or if you are using app-level logic for view states (such as refreshing your app content for changes in app window size or orientation).

When you call this method, there is expected to be a [VisualState](visualstate.md) with an **x:Name** value that matches your *stateName* value, somewhere in the control template for the control identified by *control*, or as a resource for your app. If there isn't, you don't get exceptions, but the return value will be **false**. The state named by *stateName* can be in any of the [VisualStateGroup](visualstategroup.md) elements in the template for the specified [Control](../windows.ui.xaml.controls/control.md). It's up to you to keep track of which states are in which [VisualStateGroup](visualstategroup.md) and knowing which state gets unloaded when you specify a new state from that group.

Typically the [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) that contains the visual states as referenced by name when using GoToState is not specifically defined for that control instance. Instead the visual states are from the default control style that's loaded as the implicit style for all instances of that control. For more info on the implicit style concept, see [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)).

[VisualStateManager](visualstatemanager.md) supports two important features for control authors, and for app developers who are applying a custom template to a control:
+ Control authors or app developers add [VisualStateGroup](visualstategroup.md) object elements to the root element of a control template definition in XAML, using the [VisualStateManager.VisualStateGroups](/dotnet/api/system.windows.visualstatemanager.visualstategroups) attached property. Within a [VisualStateGroup](visualstategroup.md) element, each [VisualState](visualstate.md) represents a discrete visual state of a control. Each [VisualState](visualstate.md) has a name that is representative of a UI state that can be changed by the user, or changed by control logic. A [VisualState](visualstate.md) consists mainly of a [Storyboard](visualstate_storyboard.md). This [Storyboard](visualstate_storyboard.md) targets individual dependency property values that should be applied whenever the control is in that visual state.
+ Control authors or app developers transition between these states by calling the static GoToState method of [VisualStateManager](visualstatemanager.md). Control authors do this whenever the control logic handles events that indicate a change of state, or control logic initiates a state change by itself. It's more common for control definition code to do this rather than app code, so that all the possible visual states and their transitions and trigger conditions are there by default for app code. Or, it's the app code that is changing visual states, to manage app-level view states in response to user-driven changes to the size or orientation of the main app window.


When you call GoToState to change the visual state of a control, the [VisualStateManager](visualstatemanager.md) performs these actions:
+ First it's determined whether a state that matches *stateName* exists. If not, nothing happens and the method returns **false**.
+ If the [VisualState](visualstate.md) as named by *stateName* exists, and has a [Storyboard](visualstate_storyboard.md), the storyboard begins.
+ If the [VisualState](visualstate.md) that the control was using from that same [VisualStateGroup](visualstategroup.md) prior to the newly requested state has a [Storyboard](visualstate_storyboard.md), that storyboard stops. Other than the specific properties that the new [VisualState](visualstate.md) applies an animation to, the control reverts to the initially loaded states from the control template and its composition.


If the control is already in the [VisualState](visualstate.md) requested as *stateName*, GoToState returns **true**, but there is otherwise no action (the storyboard won't be restarted).

A common control implementation pattern is to define a single private method of the control class that takes care of all possible [VisualState](visualstate.md) changes for the control. Which visual state to use is determined by checking the control's properties. These properties might be public or private. Values of properties are adjusted by handlers in control logic for events such as [OnGotFocus](../windows.ui.xaml.controls/control_ongotfocus_1398920478.md), and are checked just-in-time immediately before setting the visual state. The code example in this topic uses this implementation pattern. Alternatively, you can call GoToState for individual states from within event handlers, from control event handler overrides (the **On**_Event_ methods), or from helper methods that are called by all possible impetus for changing states (user-driven events, automation events, initialization logic).

You might also call GoToState from within the [PropertyChangedCallback](propertychangedcallback.md) implementation for a custom dependency property.

### Visual states and transitions

In addition to the visual states, the visual state model also includes transitions. Transitions are animation actions controlled by a [Storyboard](visualtransition_storyboard.md) that occur between each visual state when the state is changed. The transition can be defined differently for each combination of starting state and ending state as defined by your control's set of visual states. Transitions are defined by the [Transitions](visualstategroup_transitions.md) property of [VisualStateGroup](visualstategroup.md) and are usually defined in XAML. Most default control templates don't define transitions, and in this case the transitions between states happen instantaneously. For more info, see [VisualTransition](visualtransition.md).

A [VisualTransition](visualtransition.md) can also be defined such that it produces an implicit transition. Any dependency property that is specifically targeted for animation in either the [From](visualtransition_from.md) or[To](visualtransition_to.md) visual states of a [VisualTransition](visualtransition.md) and has different values across the state change can be animated with an implicit transition animation. This generated animation transitions between the [From](visualtransition_from.md) state value and the [To](visualtransition_to.md) state value of such a property using interpolation. The implicit transition animation lasts for the time stated by the [GeneratedDuration](visualtransition_generatedduration.md) value of a [VisualTransition](visualtransition.md). Implicit transitions only apply to properties that are a [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true), [Color](../windows.ui/color.md) or [Point](../windows.foundation/point.md) value. In other words the property must be possible to implicitly animate using a [DoubleAnimation](../windows.ui.xaml.media.animation/doubleanimation.md), [PointAnimation](../windows.ui.xaml.media.animation/pointanimation.md) or [ColorAnimation](../windows.ui.xaml.media.animation/coloranimation.md). For more info, see [GeneratedDuration](visualtransition_generatedduration.md).

### Events for visual state changes

[CurrentStateChanging](visualstategroup_currentstatechanging.md) fires when the control begins to transition states as requested by the GoToState call. If a [VisualTransition](visualtransition.md) is applied to the state change, this event occurs when the transition begins.

[CurrentStateChanged](visualstategroup_currentstatechanged.md) fires after the control is in the state as requested by the GoToState call, just as the new [Storyboard](visualstate_storyboard.md) begins. No event is fired on the new storyboard's completion.

If a [VisualTransition](visualtransition.md) is not applied, [CurrentStateChanging](visualstategroup_currentstatechanging.md) and [CurrentStateChanged](visualstategroup_currentstatechanged.md) fire in quick succession, but are guaranteed in that order if both occur.

However, if a state change transition is interrupted by a new GoToState call, the [CurrentStateChanged](visualstategroup_currentstatechanged.md) event is never raised for the first state transition. A new event series is fired for the next requested state change.

[OnApplyTemplate](frameworkelement_onapplytemplate_1955470198.md) is not invoked for visual state changes. [OnApplyTemplate](frameworkelement_onapplytemplate_1955470198.md) is only invoked for the initial load of a control into a XAML UI.

### Attributing a custom control's named visual states

If you are defining a custom control that has visual states in its control template XAML, it's a best practice to attribute the control class to indicate to control consumers which visual states are available. To do this, apply one or more [TemplateVisualState](templatevisualstateattribute.md) attributes at the class level of your control definition code. Each attribute should specify the state's [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute), which is the *stateName* value a control consumer would pass in a GoToState call to use that visual state. If the [VisualState](visualstate.md) is part of a [VisualStateGroup](visualstategroup.md), that should also be indicated in the attribute definition.

A related concept is that control authors should attribute the names of key control parts using [TemplatePartAttribute](templatepartattribute.md). This is very helpful if control consumers want to access named parts from the template scope after the template is applied. [TemplateVisualStateAttribute](templatevisualstateattribute.md) and [TemplatePartAttribute](templatepartattribute.md) combined help define the control contract for a control. 
<!--For more info??-->

### Custom **VisualStateManager**

As an advanced scenario, it is possible to derive from [VisualStateManager](visualstatemanager.md) and change the default GoToState behavior. The derived class should override the protected [GoToStateCore](visualstatemanager_gotostatecore_681569745.md) method. Any instance of the custom [VisualStateManager](visualstatemanager.md) uses this **Core** logic when its GoToState method is called.

### Visual states for app view states

Visual states aren't necessarily for custom controls. You can use visual states from new control templates that you apply to any [Control](../windows.ui.xaml.controls/control.md) instance where you're replacing the default template by setting the [Template](../windows.ui.xaml.controls/control_template.md) property. To set this up, you must define the control template and visual states that you're planning on using as a [Style](style.md) resource that's in either `Page.Resources` or `Application.Resources`. It's always best to start with a copy of the default template and modify only certain aspects of the template or even just modify some of the visual states and leave the basic composition alone. For more info, see [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)).

Visual states can be used to change properties of a [Page](../windows.ui.xaml.controls/page.md) or controls within the page to account for app window orientation. Your composition or your control's layout-related property values might change depending on whether the overall orientation is portrait or landscape. For more info about this scenario for GoToState, see [Quickstart: Designing apps for different window sizes](/previous-versions/windows/apps/dn297195(v=win.10)).

### Visual states for elements that aren't controls

Visual states are sometimes useful for scenarios where you want to change the state of some area of UI that's not immediately a [Control](../windows.ui.xaml.controls/control.md) subclass. You can't do this directly because the *control* parameter of the GoToState method requires a [Control](../windows.ui.xaml.controls/control.md) subclass, which refers to the object that the [VisualStateManager](visualstatemanager.md) acts upon. [Page](../windows.ui.xaml.controls/page.md) is a [Control](../windows.ui.xaml.controls/control.md) subclass, and it's fairly rare that you'd be showing UI in a context where you don't have a [Page](../windows.ui.xaml.controls/page.md), or your [Window.Content](window_content.md) root isn't a [Control](../windows.ui.xaml.controls/control.md) subclass. We recommend you define a custom [UserControl](../windows.ui.xaml.controls/usercontrol.md) to either be the [Window.Content](window_content.md) root or be a container for other content you want to apply states to (such as a [Panel](../windows.ui.xaml.controls/panel.md)). Then you can call GoToState on your [UserControl](../windows.ui.xaml.controls/usercontrol.md) and apply states regardless of whether the rest of the content is a [Control](../windows.ui.xaml.controls/control.md). For example you could apply visual states to UI that otherwise consists of just a [SwapChainPanel](../windows.ui.xaml.controls/swapchainpanel.md) so long as you placed that within your [UserControl](../windows.ui.xaml.controls/usercontrol.md) and declared named states that apply to the properties of the parent [UserControl](../windows.ui.xaml.controls/usercontrol.md) or of the named [SwapChainPanel](../windows.ui.xaml.controls/swapchainpanel.md) part of the template.

## -examples
This example demonstrates control logic that uses the GoToState method to transition between states.



[!code-csharp[UpdateStates](../windows.ui.xaml/code/NumericUpDownCustomControl/csharp/NumericUpDownCustomControl.cs#SnippetUpdateStates)]

[!code-vb[UpdateStates](../windows.ui.xaml/code/NumericUpDownCustomControl/vbnet/NumericUpDown.vb#SnippetUpdateStates)]



[!code-xaml[NUDTemplate](../windows.ui.xaml/code/NumericUpDownCustomControl/csharp/themes/Generic.xaml#SnippetNUDTemplate)]

## -see-also
[Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)), [GoToStateCore](visualstatemanager_gotostatecore_681569745.md), [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute), [TemplateVisualStateAttribute](templatevisualstateattribute.md), [VisualStateGroup](visualstategroup.md), [VisualState](visualstate.md), [VisualState](visualstate.md)
