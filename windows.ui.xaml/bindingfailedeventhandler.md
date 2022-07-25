---
-api-id: T:Windows.UI.Xaml.BindingFailedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void BindingFailedEventHandler(System.Object sender, Windows.UI.Xaml.BindingFailedEventArgs e)
-->
# Windows.UI.Xaml.BindingFailedEventHandler

## -description
Represents the method that will handle the [DebugSettings.BindingFailed](debugsettings_bindingfailed.md) event.



## -parameters
### -param sender
The source of the event.

### -param e
The event data.


## -remarks
[IsBindingTracingEnabled](debugsettings_isbindingtracingenabled.md) must be **true** and there must be a debugger attached to the app process in order for [BindingFailed](debugsettings_bindingfailed.md) to occur and for tracing to appear in debugger output. You don't need to handle the event in order to see tracing appear in a debugger. The debugger output contains message information that goes to the **Output** window of the debugger. Attaching a [BindingFailed](debugsettings_bindingfailed.md) handler yourself is an advanced scenario for when you want to see the raw message.

## -examples

## -see-also
[BindingFailed](debugsettings_bindingfailed.md), [DebugSettings](debugsettings.md), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
