---
-api-id: E:Windows.UI.Xaml.DebugSettings.BindingFailed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.BindingFailedEventHandler BindingFailed
-->

# Windows.UI.Xaml.DebugSettings.BindingFailed

## -description
Occurs when a [Binding](../windows.ui.xaml.data/binding.md) cannot be resolved.



## -remarks
[IsBindingTracingEnabled](debugsettings_isbindingtracingenabled.md) must be **true** and there must be a debugger attached to the app process in order for BindingFailed to fire and for tracing to appear in debugger output. You don't need to handle the event in order to see tracing appear in a debugger. The debugger output contains message information that goes to the **Output** window of the debugger. Attaching a BindingFailed handler yourself is an advanced scenario for when you want to see the raw message.

## -examples

## -see-also
[BindingFailedEventHandler](bindingfailedeventhandler.md), [IsBindingTracingEnabled](debugsettings_isbindingtracingenabled.md), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
