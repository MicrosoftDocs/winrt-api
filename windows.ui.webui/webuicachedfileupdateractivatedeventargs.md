---
-api-id: T:Windows.UI.WebUI.WebUICachedFileUpdaterActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class WebUICachedFileUpdaterActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.ICachedFileUpdaterActivatedEventArgs, Windows.UI.WebUI.IActivatedEventArgsDeferral
-->

# Windows.UI.WebUI.WebUICachedFileUpdaterActivatedEventArgs

## -description

Provides information about the activated event that fires when the user saves or opens a file that needs updates from the app.

> **C#/C++/VB**
> This type appears as [CachedFileUpdaterActivatedEventArgs](../windows.applicationmodel.activation/cachedfileupdateractivatedeventargs.md).

## -remarks

Learn more about providing updates for files that your app offers in the [Quickstart: Providing file services through ](http://msdn.microsoft.com/library/3a348fea-c4b3-4847-a350-a41a69441c00) and in the [Windows.Storage.Pickers.Provider](../windows.storage.pickers.provider/windows_storage_pickers_provider.md) namespace reference.

This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **cachedFileUpdater**.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275)
<!--[jjacks - removed this link (http://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

## -examples

The [File picker contracts sample](http://go.microsoft.com/fwlink/p/?linkid=231536) demonstrates how to respond to a [cachedFileUpdater](../windows.applicationmodel.activation/activationkind.md) activated event.

```javascript

// cachedFileUpdater activated event handler
function activated(eventObject) {
        // Identify whether app was launched for cachedFileUpdater
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.cachedFileUpdater) {
            // Perform tasks to prepare your app to display its file picker page

            // Get file picker UI
            cachedFileUpdaterUI = eventObject.detail.cachedFileUpdaterUI;

            cachedFileUpdaterUI.addEventListener("fileupdaterequested", onFileUpdateRequest);
            cachedFileUpdaterUI.addEventListener("uirequested", onUIRequested);

            switch (cachedFileUpdaterUI.updateTarget) {
                case Windows.Storage.Provider.CachedFileTarget.local:
                    scenarios = [{ url: "/html/cachedFileUpdaterScenario1.html", title: "Get latest version" }];
                    break;
                case Windows.Storage.Provider.CachedFileTarget.remote:
                    scenarios = [{ url: "/html/cachedFileUpdaterScenario2.html", title: "Remote file update" }];
                    break;
            }
            SdkSample.scenarios = scenarios;
        }
    }

// Register the activated event handler
WinJS.Application.addEventListener("activated", activated, false);
```

For JavaScript, `eventObject` contains a [webUICachedFileUpdaterActivatedEventArgs](webuicachedfileupdateractivatedeventargs.md) object.

## -see-also

[Quickstart: Providing file services through ](http://msdn.microsoft.com/library/3a348fea-c4b3-4847-a350-a41a69441c00), [File picker provider sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620543)