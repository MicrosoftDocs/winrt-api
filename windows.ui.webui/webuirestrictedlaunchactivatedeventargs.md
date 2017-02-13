---
-api-id: T:Windows.UI.WebUI.WebUIRestrictedLaunchActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIRestrictedLaunchActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IRestrictedLaunchActivatedEventArgs, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUIRestrictedLaunchActivatedEventArgs

## -description
Provides event information when a restricted app is launched.

## -remarks
This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **restrictedLaunch**.



> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275).

<!--TODO: Document how the developer can obtain this class object, and add or update retriever elements as necessary.-->

## -examples

## -see-also
[IRestrictedLaunchActivatedEventArgs](../windows.applicationmodel.activation/irestrictedlaunchactivatedeventargs.md), [IActivatedEventArgs](../windows.applicationmodel.activation/iactivatedeventargs.md), [IActivatedEventArgsDeferral](iactivatedeventargsdeferral.md)