---
-api-id: T:Windows.UI.WebUI.WebUIProtocolActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIProtocolActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs, Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs, Windows.ApplicationModel.Activation.IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUIProtocolActivatedEventArgs

## -description

Provides data when an app is activated because it is the app associated with a URI scheme name.

## -remarks

This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **protocol**.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275)
<!--[jjacks - removed this link (http://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/en-us/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

## -examples

The [activated](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) event handler receives all activation events. The  property indicates the type of activation event. This example is set up to handle **URI** activation events.

```javascript
function onActivatedHandler(eventArgs) {
   if (eventArgs.detail.kind == Windows.ApplicationModel.Activation.ActivationKind.protocol) 
   {
       // TODO: Handle URI activation.

       // The received URI is eventArgs.detail.uri.rawUri
   }
}
```

## -see-also

[Association launching sample](http://go.microsoft.com/fwlink/p/?linkid=231484), [How to handle URI activation](http://msdn.microsoft.com/library/6d3b8229-a773-4750-b856-1d9dd1e34f2e), [Guidelines for file types and URIs](http://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [URI](../windows.foundation/uri.md), [WebUIApplication.ActivatedEventHandler](activatedeventhandler.md), [WinJS.Application.onactivated](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4), [Association launching sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620490)