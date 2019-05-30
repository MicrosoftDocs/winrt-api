---
-api-id: T:Windows.UI.WebUI.ActivatedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void ActivatedEventHandler(System.Object sender, Windows.ApplicationModel.Activation.IActivatedEventArgs eventArgs)
-->
# Windows.UI.WebUI.ActivatedEventHandler

## -description
Represents a method that handles the app activation event.

## -parameters
### -param sender
The sender.

### -param eventArgs
The event information. The data type depends on why the app was activated. For a list of possible data types, see the [ActivationKind](../windows.applicationmodel.activation/activationkind.md) enumeration.


## -remarks

## -examples

## -see-also
[App lifecycle](https://docs.microsoft.com/windows/uwp/launch-resume/app-lifecycle), [Onactivated event](https://docs.microsoft.com/previous-versions/windows/apps/br212679(v=win.10)), [WebUIApplication](webuiapplication.md), [ActivationKind](../windows.applicationmodel.activation/activationkind.md), [App activated, resume, and suspend using the WRL sample](https://go.microsoft.com/fwlink/p/?linkid=226722)
