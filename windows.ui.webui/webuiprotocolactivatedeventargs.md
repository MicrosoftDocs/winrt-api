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

This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](https://docs.microsoft.com/previous-versions/windows/apps/br212679(v=win.10)) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **protocol**.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275)
<!--[jjacks - removed this link (https://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

The [activated](https://docs.microsoft.com/previous-versions/windows/apps/br212679(v=win.10)) event handler receives all activation events. The  property indicates the type of activation event. This example is set up to handle **URI** activation events.

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

[Association launching sample](https://go.microsoft.com/fwlink/p/?linkid=231484), [How to handle URI activation](https://docs.microsoft.com/previous-versions/windows/apps/hh452686(v=win.10)), [Guidelines for file types and URIs](https://docs.microsoft.com/windows/uwp/files/index), [URI](../windows.foundation/uri.md), [WebUIApplication.ActivatedEventHandler](activatedeventhandler.md), [WinJS.Application.onactivated](https://docs.microsoft.com/previous-versions/windows/apps/br212679(v=win.10)), [Association launching sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620490)
