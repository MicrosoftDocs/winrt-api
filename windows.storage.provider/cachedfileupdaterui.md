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

Retrieve a CachedFileUpdaterUI object using the [CachedFileUpdaterActivatedEventArgs.CachedFileUpdaterUI](../windows.applicationmodel.activation/cachedfileupdateractivatedeventargs_cachedfileupdaterui.md) property.

## -examples

The [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts) demonstrates how to respond to a [CachedFileUpdater](../windows.applicationmodel.activation/activationkind.md) activated event.

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

For C#, `args` contains a [CachedFileUpdaterActivatedEventArgs](../windows.applicationmodel.activation/cachedfileupdateractivatedeventargs.md) object. Additionally, the `OnCachedFileUpdaterActivated` is in the App.xaml.cs file and the `Activate` method is in the CachedFileUpdaterPage.xaml.cs file of the [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts).

## -see-also

[File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts)
