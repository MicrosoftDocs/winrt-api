---
-api-id: T:Windows.UI.Xaml.VisualStateManager
-api-type: winrt class
---

<!-- Class syntax.
public class VisualStateManager : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.IVisualStateManager, Windows.UI.Xaml.IVisualStateManagerOverrides, Windows.UI.Xaml.IVisualStateManagerProtected
-->

# Windows.UI.Xaml.VisualStateManager

## -description
Manages visual states and the logic for transitions between visual states for controls. Also provides the attached property support for [VisualStateManager.VisualStateGroups](visualstatemanager_visualstategroups.md), which is how you define visual states in XAML for a control template.

## -remarks
[VisualStateManager](visualstatemanager.md) supports two important features for control authors, and for app developers who are applying a custom template to a control:
+ Control authors or app developers add [VisualStateGroup](visualstategroup.md) object elements to the root element of a control template definition in XAML, using the [VisualStateManager.VisualStateGroups](visualstatemanager_visualstategroups.md) attached property. Within a [VisualStateGroup](visualstategroup.md) element, each [VisualState](visualstate.md) represents a discrete visual state of a control. Each [VisualState](visualstate.md) has a name that is representative of a UI state that can be changed by the user, or changed by control logic. A [VisualState](visualstate.md) consists mainly of a [Storyboard](visualstate_storyboard.md). This [Storyboard](visualstate_storyboard.md) targets individual dependency property values that should be applied whenever the control is in that visual state. For more info on how to write visual states in XAML, including example code, see [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4).
+ Control authors or app developers transition between these states by calling the static [GoToState](visualstatemanager_gotostate.md) method of [VisualStateManager](visualstatemanager.md). Control authors do this whenever the control logic handles events that indicate a change of state, or control logic initiates a state change by itself. It's more common for control definition code to do this rather than app code, so that all the possible visual states and their transitions and trigger conditions are there by default for app code, and the logic is encapsulated by the control.


Most developers will use just two of the [VisualStateManager](visualstatemanager.md)  API: [VisualStateManager.VisualStateGroups](visualstatemanager_visualstategroups.md), and [GoToState](visualstatemanager_gotostate.md), as described above. The remaining API are all for extension support and creating a custom [VisualStateManager](visualstatemanager.md). For more info see "Custom VisualStateManager" section in this topic.

When you edit copies of styles as enabled by the XAML design surface of Microsoft Visual Studio, the visual states from the default template are defined in the XAML you are editing. Make sure you don't delete these states or change their names, because the control logic is expecting that these visual states exist in the template.

In addition to the visual states, the visual state model also includes transitions. Transitions are animation actions controlled by a [Storyboard](visualtransition_storyboard.md) that occur between each visual state when the state is changed. The transition can be defined differently for each combination of starting state and ending state as defined by your control's set of visual states. Transitions are defined by the [Transitions](visualstategroup_transitions.md) property of [VisualStateGroup](visualstategroup.md), in XAML using property element syntax. Most default control templates don't define transitions. In absence of specifically defined transitions, the transitions between states happen instantaneously (zero-duration). For more info, see [VisualTransition](visualtransition.md).

### Attached properties defined by **VisualStateManager**

[VisualStateManager](visualstatemanager_visualstatemanager.md) supports these XAML attached properties: + [VisualStateManager.VisualStateGroups](visualstatemanager_visualstategroups.md) (a collection)
+ [VisualStateManager.CustomVisualStateManager](visualstatemanager_customvisualstatemanager.md) (for advanced scenarios)


### Custom **VisualStateManager**

As an advanced scenario, it is possible to derive from [VisualStateManager](visualstatemanager.md) and change the default [GoToState](visualstatemanager_gotostate.md) behavior. Follow these guidelines:
+ The derived class should override the protected [GoToStateCore](visualstatemanager_gotostatecore.md) method. Any instance of the custom [VisualStateManager](visualstatemanager.md) uses this **Core** logic when its [GoToState](visualstatemanager_gotostate.md) method is called.
+ To use a custom [VisualStateManager](visualstatemanager.md) in app code, reference the custom class as a resource using the [VisualStateManager.CustomVisualStateManager](visualstatemanager_customvisualstatemanager.md) attached property. You set [VisualStateManager.CustomVisualStateManager](visualstatemanager_customvisualstatemanager.md) on the root element of a [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md), alongside the [VisualStateManager.VisualStateGroups](visualstatemanager_visualstategroups.md) attached property usage that defines the visual states for the template.


That's the basic requirements for creating and using a custom [VisualStateManager](visualstatemanager.md). You also can choose to override a few more behaviors:
+ Override [RaiseCurrentStateChanged](visualstatemanager_raisecurrentstatechanged.md) to control when the [CurrentStateChanged](visualstategroup_currentstatechanged.md) event is fired by a [VisualStateGroup](visualstategroup.md) being managed by the [VisualStateManager](visualstatemanager.md).
+ Override [RaiseCurrentStateChanging](visualstatemanager_raisecurrentstatechanging.md) to control when the [CurrentStateChanging](visualstategroup_currentstatechanging.md) event is fired by a [VisualStateGroup](visualstategroup.md) being managed by the [VisualStateManager](visualstatemanager.md).
+ Override or overload the constructor if your custom class needs additional information to initialize with.


All the other API ([CustomVisualStateManagerProperty](visualstatemanager_customvisualstatemanagerproperty.md), [GetCustomVisualStateManager](visualstatemanager_getcustomvisualstatemanager.md), [GetVisualStateGroups](visualstatemanager_getvisualstategroups.md), [SetCustomVisualStateManager](visualstatemanager_setcustomvisualstatemanager.md)) are infrastructure for attached property support, and you don't need to call them or do anything with them.

### Visual states for elements that aren't controls

Visual states are sometimes useful for scenarios where you want to change the state of some area of UI that's not immediately a [Control](../windows.ui.xaml.controls/control.md) subclass. You can't do this directly because the *control* parameter of the [GoToState](visualstatemanager_gotostate.md) method requires a [Control](../windows.ui.xaml.controls/control.md) subclass, which refers to the object that the [VisualStateManager](visualstatemanager.md) acts upon. [Page](../windows.ui.xaml.controls/page.md) is a [Control](../windows.ui.xaml.controls/control.md) subclass, and it's fairly rare that you'd be showing UI in a context where you don't have a [Page](../windows.ui.xaml.controls/page.md), or your [Window.Content](window_content.md) root isn't a [Control](../windows.ui.xaml.controls/control.md) subclass. We recommend you define a custom [UserControl](../windows.ui.xaml.controls/usercontrol.md) to either be the [Window.Content](window_content.md) root or be a container for other content you want to apply states to (such as a [Panel](../windows.ui.xaml.controls/panel.md)). Then you can call [GoToState](visualstatemanager_gotostate.md) on your [UserControl](../windows.ui.xaml.controls/usercontrol.md) and apply states regardless of whether the rest of the content is a [Control](../windows.ui.xaml.controls/control.md). For example you could apply visual states to UI that otherwise consists of just a [SwapChainPanel](../windows.ui.xaml.controls/swapchainpanel.md) so long as you placed that within your [UserControl](../windows.ui.xaml.controls/usercontrol.md) and declared named states that apply to the properties of the parent [UserControl](../windows.ui.xaml.controls/usercontrol.md) or of the named [SwapChainPanel](../windows.ui.xaml.controls/swapchainpanel.md) part of the template.

## -examples
This example shows how to use the [VisualStateManager.VisualStateGroups](visualstatemanager_visualstategroups.md) XAML attached property. Note how there is otherwise no "VisualStateManager" tag defined. Conceptually, [VisualStateManager.VisualStateGroups](visualstatemanager_visualstategroups.md) contains the visual states for a control, as an immediate child tag of the template root in a control template.

The particular set of visual states contains one [VisualStateGroup](visualstategroup.md), called "CommonStates", which defines the "PointerOver" and "Normal"**[VisualState](visualstate.md) objects. When the user puts the pointer over the [Button](../windows.ui.xaml.controls/button.md), the [Grid](../windows.ui.xaml.controls/grid.md) changes from green to red in .5 seconds. When the user moves the pointer away from the button, the [Grid](../windows.ui.xaml.controls/grid.md) immediately changes back to green.



[!code-xml[11](../windows.ui.xaml.data/code/StylingTemplatingOverview/csharp/ButtonStages.xaml#Snippet11)]

```xaml
<common:LayoutAwarePage>
  <Grid>
...
    <VisualStateManager.VisualStateGroups>
    <!-- Visual states reflect the application's window size -->
      <VisualStateGroup>
        <VisualState x:Name="DefaultLayout">
           <Storyboard>
           </Storyboard>
        </VisualState>
        <VisualState x:Name="Below768Layout">
           <Storyboard>
             <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty="(FrameworkElement.Margin)"
               Storyboard.TargetName="ContentRoot">
               <DiscreteObjectKeyFrame KeyTime="0">
                 <DiscreteObjectKeyFrame.Value>
                   <Thickness>20,20,20,20</Thickness>
                 </DiscreteObjectKeyFrame.Value>
               </DiscreteObjectKeyFrame>
             </ObjectAnimationUsingKeyFrames>
             <ObjectAnimationUsingKeyFrames Storyboard.TargetProperty="(FrameworkElement.HorizontalAlignment)"
               Storyboard.TargetName="FooterPanel">
               <DiscreteObjectKeyFrame KeyTime="0">
                 <DiscreteObjectKeyFrame.Value>
                    <HorizontalAlignment>Left</HorizontalAlignment>
                 </DiscreteObjectKeyFrame.Value>
               </DiscreteObjectKeyFrame>
             </ObjectAnimationUsingKeyFrames>
           </Storyboard>
         </VisualState>
       </VisualStateGroup>
     </VisualStateManager.VisualStateGroups>
   </Grid>
</common:LayoutAwarePage>
```

The next snippet is code to go along with the XAML, showing how an app might detect the app window width and use that info to call the appropriate visual state.

```csharp
String state = (Window.Current.Bounds.Width > 768) ? "DefaultLayout" : "Below768Layout";
VisualStateManager.GoToState(this, state, false); // 'this' is the LayoutAwarePage, scope is page code-behind
```



## -see-also
[DependencyObject](dependencyobject.md), [VisualStateGroup](visualstategroup.md), [VisualState](visualstate.md), [Storyboard](../windows.ui.xaml.media.animation/storyboard.md), [Quickstart: Control templates](http://msdn.microsoft.com/library/67c424ae-afb1-4560-a6a8-4a3506775d77), [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4), [Attached properties overview](http://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2), [Snap sample](http://go.microsoft.com/fwlink/p/?LinkID=231523), [XAML control and app styling sample](http://go.microsoft.com/fwlink/p/?LinkID=258670)