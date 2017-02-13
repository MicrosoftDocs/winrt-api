---
-api-id: E:Windows.UI.WebUI.WebUIApplication.Activated
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.UI.WebUI.ActivatedEventHandler Activated
-->

# Windows.UI.WebUI.WebUIApplication.Activated

## -description
Occurs when the app is activated.

## -remarks
Whenever your app is launched, the **activated** event is raised. This event can also be raised while your app is running if the system needs to pass the app parameters related to a new activation contract. You can use the activated event to restore the previous state of your app and to retrieve the activation parameters related to the contract for which your app is being activated. For a full list of the activation contracts and more details on their parameters see the [ActivationKind](../windows.applicationmodel.activation/activationkind.md) enumeration. Note that you can also use the WinJS [Onactivated event](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) to handle app activation.



> [!NOTE]
> : If your app needs to navigate the top level document for any reason you must first complete activation before attempting to do the top level navigation. If you attempt a top level navigation before activation completes your app will crash. This ensures that your app and the system are in a consistent state before the JavaScript context is torn down and recreated during the navigation.

## -examples

## -see-also
[App lifecycle](http://msdn.microsoft.com/library/6c469e77-f1e3-4859-a27b-c326f9616d10), [Onactivated event](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4), [App activated, resume, and suspend using the WRL sample](http://go.microsoft.com/fwlink/p/?linkid=226722)