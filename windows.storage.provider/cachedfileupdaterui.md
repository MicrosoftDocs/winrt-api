---
-api-id: T:Windows.Storage.Provider.CachedFileUpdaterUI
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class CachedFileUpdaterUI : Windows.Storage.Provider.ICachedFileUpdaterUI, Windows.Storage.Provider.ICachedFileUpdaterUI2
-->

# Windows.Storage.Provider.CachedFileUpdaterUI

## -description

Used to interact with the file picker if your app provides file updates through the Cached File Updater contract.

## -remarks

In JavaScript, retrieve a [CachedFileUpdaterUI](cachedfileupdaterui.md) object using the [webuiCachedFileUpdaterActivatedEventArgs.cachedFileUpdaterUI](../windows.ui.webui/webuicachedfileupdateractivatedeventargs_cachedfileupdaterui.md) property.

In C#, C++, and VB, retrieve a [CachedFileUpdaterUI](cachedfileupdaterui.md) object using the [CachedFileUpdaterActivatedEventArgs.CachedFileUpdaterUI](../windows.applicationmodel.activation/cachedfileupdateractivatedeventargs_cachedfileupdaterui.md) property.

## -examples

The [File picker contracts sample](https://go.microsoft.com/fwlink/p/?linkid=231536) demonstrates how to respond to a [cachedFileUpdater](../windows.applicationmodel.activation/activationkind.md) activated event.

```csharp

// CachedFileUpdater activated event handler
protected override void OnCachedFileUpdaterActivated(CachedFileUpdaterActivatedEventArgs args)
{
    var CachedFileUpdaterPage = new SDKTemplate.CachedFileUpdaterPage();
    CachedFileUpdaterPage.Activate(args);
}

// Overloaded method to respond to CachedFileUpdater events
public void Activate(CachedFileUpdaterActivatedEventArgs args)
{
            // Get file picker UI
            cachedFileUpdaterUI = args.CachedFileUpdaterUI;

            cachedFileUpdaterUI.FileUpdateRequested += CachedFileUpdaterUI_FileUpdateRequested;
            cachedFileUpdaterUI.UIRequested += CachedFileUpdaterUI_UIRequested;

            switch (cachedFileUpdaterUI.UpdateTarget)
            {
                case CachedFileTarget.Local:
                    scenarios = new List<Scenario> { new Scenario() { Title = "Get latest version", ClassType = typeof(FilePickerContracts.CachedFileUpdater_Local) } };
                    break;
                case CachedFileTarget.Remote:
                    scenarios = new List<Scenario> { new Scenario() { Title = "Remote file update", ClassType = typeof(FilePickerContracts.CachedFileUpdater_Remote) } };
                    break;
            }

            Window.Current.Activate();
        }
```

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

For JavaScript, `eventObject` contains a [webUICachedFileUpdaterActivatedEventArgs](../windows.ui.webui/webuicachedfileupdateractivatedeventargs.md) object.

For C#, `args` contains a [CachedFileUpdaterActivatedEventArgs](../windows.applicationmodel.activation/cachedfileupdateractivatedeventargs.md) object. Additionally, the `OnCachedFileUpdaterActivated` is in the App.xaml.cs file and the `Activate` method is in the CachedFileUpdaterPage.xaml.cs file of the [File picker contracts sample](https://go.microsoft.com/fwlink/p/?linkid=231536).

## -see-also

[File picker provider sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620543)
