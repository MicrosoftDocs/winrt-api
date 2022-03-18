---
-api-id: T:Windows.ApplicationModel.Activation.FileActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class FileActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs, Windows.ApplicationModel.Activation.IFileActivatedEventArgs, Windows.ApplicationModel.Activation.IFileActivatedEventArgsWithCallerPackageFamilyName, Windows.ApplicationModel.Activation.IFileActivatedEventArgsWithNeighboringFiles, Windows.ApplicationModel.Activation.IViewSwitcherProvider
-->

# Windows.ApplicationModel.Activation.FileActivatedEventArgs

## -description

Provides data when an app is activated because it is the app associated with a file.

> **JavaScript**
> This type appears as [WebUIFileActivatedEventArgs](../windows.ui.webui/webuifileactivatedeventargs.md).

## -remarks

This object is accessed when you implement an event handler to respond to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **File**.

UWP app using C++, C#, or Visual Basic typically implement activation points by overriding methods of the [Application](../windows.ui.xaml/application.md) object. The default template app.xaml code-behind files always include an override for [OnLaunched](../windows.ui.xaml/application_onlaunched_859642554.md), but defining overrides for other activation points such as [OnFileActivated](../windows.ui.xaml/application_onfileactivated_2046716329.md) is up to your app code.

All [Application](../windows.ui.xaml/application.md) overrides involved in an activation scenario should call [Window.Activate](../windows.ui.xaml/window_activate_1797342875.md) in their implementations.

Note that when your app is activated for the file contract you must access the data using the [StorageFile](../windows.storage/storagefile.md) objects passed to your app through the [Files](fileactivatedeventargs_files.md) property. You should not attempt to access the path of the file since your app may not have permission to the file’s location.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

The [OnFileActivated](../windows.ui.xaml/application_onfileactivated_2046716329.md) event handler on the [Application](../windows.ui.xaml/application.md) object receives all file activation events.

```csharp
protected override void OnFileActivated(FileActivatedEventArgs args)
{
       // TODO: Handle file activation

       // The number of files received is args.Files.Size
       // The first file is args.Files[0].Name
}
```

```vb
Private Sub OnFileActivated(ByVal args As Windows.ApplicationModel.Activation.FileActivatedEventArgs)
      ' TODO: Handle file activation

      ' The number of files received is args.Files.Size
      ' The first file is args.Files(0).Name
End Sub
```

```cppwinrt
void App::OnFileActivated(Windows::ApplicationModel::Activation::FileActivatedEventArgs const& /* args */)
{
    // TODO: Handle file activation.

    // The number of files received is args.Files().Size().
    // The first file is args.Files().GetAt(0).Name().
}
```

```cppcx
void App::OnFileActivated(Windows::ApplicationModel::Activation::FileActivatedEventArgs^ args)
{
       // TODO: Handle file activation

       // The number of files received is args->Files->Size
       // The first file is args->Files->GetAt(0)->Name
}
```

## -see-also

[Association launching sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AssociationLaunching), [Handle file activation](/windows/uwp/launch-resume/handle-file-activation), [Guidelines for file types and URIs](/windows/uwp/files/index), [Windows.Storage](../windows.storage/windows_storage.md), [Windows.UI.Core.CoreApplicationView.Activated](../windows.applicationmodel.core/coreapplicationview_activated.md), [Windows.UI.Xaml.Application.OnFileActivated](../windows.ui.xaml/application_onfileactivated_2046716329.md), [Association launching sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620490)
