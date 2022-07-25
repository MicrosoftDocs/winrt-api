---
-api-id: M:Windows.UI.Xaml.FrameworkElement.OnApplyTemplate
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnApplyTemplate()
-->

# Windows.UI.Xaml.FrameworkElement.OnApplyTemplate

## -description
Invoked whenever application code or internal processes (such as a rebuilding layout pass) call [ApplyTemplate](../windows.ui.xaml.controls/control_applytemplate_1368990630.md). In simplest terms, this means the method is called just before a UI element displays in your app. Override this method to influence the default post-template logic of a class.



## -remarks
Although OnApplyTemplate is a method defined by the [FrameworkElement](frameworkelement.md) class, the OnApplyTemplate behavior and the scenarios for overriding OnApplyTemplate are mainly relevant to a [Control](../windows.ui.xaml.controls/control.md) subclass. This is because the [Template](../windows.ui.xaml.controls/control_template.md) property that you typically define in a XAML file and the internal Windows Runtime logic that applies the templates are specifically for controls. Specialized template behavior also exists for [ContentPresenter](../windows.ui.xaml.controls/contentpresenter.md) and [ContentControl](../windows.ui.xaml.controls/contentcontrol.md).

### Notes to implementers

There is a base implementation of this method implemented as a Windows Runtime internal behavior, which provides some basic layout logic. You should always call the base implementation from your implementation. Failing to reference the base implementation might result in undesirable layout behavior. 
<!--If deriving from Control or further subclasses, the Control implementation calls the FrameworkElement base. Therefore, this accesses the native-level implementation implicitly if you call the immediate base.-->

Derived classes can use this method as a notification or entry point for the following scenarios:

+ Build the remainder of a visual tree using custom code.
+ Run code that can only work once the XAML-defined visual tree from templates has been applied. For example, code that obtains references to named elements that came from a template, by calling [GetTemplateChild](../windows.ui.xaml.controls/control_gettemplatechild_501346084.md), so that members of these parts can be referenced by other post-template runtime code.
+ Introduce services that only make sense to exist after the visual tree from templates is complete.
+ Attach class-defined event handlers to parts of the template, or the control parent of a composite control. For example, you might want class logic to handle routed [KeyDown](uielement_keydown.md) events from a [TextBox](../windows.ui.xaml.controls/textbox.md) template part of a composite control. You would do this so that UI states are updated based on the low-level input event of the part, and other events that are specific to your control and raised by the control parent are raised instead.
+ Set states and properties of elements within the template that are dependent on other factors. For example, property values might only be discoverable by knowing the parent element, or when a specific derived class uses a common template. However, note that a well-designed control should handle its visual states with [VisualStateManager](visualstatemanager.md). For more info on this concept, see [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)).
<!--This conceptual link is a little weak but it's all there is available right now. Hoping for a dedicated conceptual about VisualStateManager and in particular calling GoToState yourself from code.-->
OnApplyTemplate is often a more appropriate point to deal with adjustments to the template-created visual tree than is the [Loaded](frameworkelement_loaded.md) event. The [Loaded](frameworkelement_loaded.md) event might occur before the template is applied, and the visual tree might be incomplete as of [Loaded](frameworkelement_loaded.md).
<!--Query is out on this note, it came from Silverlight. My guess is still applies.-->

## -examples
This example shows an OnApplyTemplate override defined by a custom control. The override is designed to account for callers potentially defining and applying their own control template through the template and style system. As part of its definition, the control attributes the named elements within a template that are required, such as "UpButton". Then OnApplyTemplate retrieves the object references based on this naming contract when the template is loaded, calling [GetTemplateChild](../windows.ui.xaml.controls/control_gettemplatechild_501346084.md). (The values being set, for example "UpButtonElement", refer to private fields defined at class-level so that other members of the class can reference that part as an object at run time.) Also, this example calls the private method `UpdateStates` (definition not shown). This is another common scenario for OnApplyTemplate: making sure that the visual state is set for the control's starting state, in this case by calling a private method that accounts for all of the control's defined states and calls [GoToState](visualstatemanager_gotostate_443481648.md) to set the appropriate state.



[!code-csharp[ApplyTemplate](../windows.ui.xaml/code/NumericUpDownCustomControl/csharp/NumericUpDownCustomControl.cs#SnippetApplyTemplate)]

[!code-vb[ApplyTemplate](../windows.ui.xaml/code/NumericUpDownCustomControl/vbnet/NumericUpDown.vb#SnippetApplyTemplate)]

## -see-also
[ControlTemplate](../windows.ui.xaml.controls/controltemplate.md), [GetTemplateChild](../windows.ui.xaml.controls/control_gettemplatechild_501346084.md), [Styling controls](/windows/uwp/controls-and-patterns/styling-controls)
9a46-faf5-42d0-9340-948d0edf4150)
