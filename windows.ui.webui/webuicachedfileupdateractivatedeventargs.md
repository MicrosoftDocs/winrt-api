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

Learn more about providing updates for files that your app offers in the [Quickstart: Providing file services through ](/previous-versions/windows/apps/hh465192(v=win.10)) and in the [Windows.Storage.Pickers.Provider](../windows.storage.pickers.provider/windows_storage_pickers_provider.md) namespace reference.

This object is accessed when you implement an event handler for the [WinJS.Application.Onactivated](/previous-versions/windows/apps/br212679(v=win.10)) or the [Windows.UI.WebUI.WebUIApplication.activated](webuiapplication_activated.md) events when [ActivationKind](../windows.applicationmodel.activation/activationkind.md) is **cachedFileUpdater**.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

The [File picker contracts sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/File%20picker%20contracts%20sample) demonstrates how to respond to a [cachedFileUpdater](../windows.applicationmodel.activation/activationkind.md) activated event.

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

For JavaScript, `eventObject` contains a webUICachedFileUpdaterActivatedEventArgs object.

## -see-also

[Quickstart: Providing file services through ](/previous-versions/windows/apps/hh465192(v=win.10)), [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts)
