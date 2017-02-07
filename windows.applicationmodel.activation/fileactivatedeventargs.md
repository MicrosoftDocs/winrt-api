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

Windows Store app using C++, C#, or Visual Basic typically implement activation points by overriding methods of the [Application](../windows.ui.xaml/application.md) object. The default template app.xaml code-behind files always include an override for [OnLaunched](../windows.ui.xaml/application_onlaunched.md), but defining overrides for other activation points such as [OnFileActivated](../windows.ui.xaml/application_onfileactivated.md) is up to your app code.

All [Application](../windows.ui.xaml/application.md) overrides involved in an activation scenario should call [Window.Activate](../windows.ui.xaml/window_activate.md) in their implementations.

Note that when your app is activated for the file contract you must access the data using the [StorageFile](../windows.storage/storagefile.md) objects passed to your app through the [Files](fileactivatedeventargs_files.md) property. You should not attempt to access the path of the file since your app may not have permission to the file’s location.

## -examples
The [OnFileActivated](../windows.ui.xaml/application_onfileactivated.md) event handler on the [Application](../windows.ui.xaml/application.md) object receives all file activation events.

```csharp
protected override void OnFileActivated(FileActivatedEventArgs args)
{
       // TODO: Handle file activation

       // The number of files received is args.Files.Size
       // The first file is args.Files[0].Name
}
```

```vbnet
Private Sub OnFileActivated(ByVal args As Windows.ApplicationModel.Activation.FileActivatedEventArgs)
      ' TODO: Handle file activation

      ' The number of files received is args.Files.Size
      ' The first file is args.Files(0).Name
End Sub
```

```cpp
void App::OnFileActivated(Windows::ApplicationModel::Activation::FileActivatedEventArgs^ args)
{
       // TODO: Handle file activation

       // The number of files received is args->Files->Size
       // The first file is args->Files->GetAt(0)->Name
}
```



## -see-also
[Association launching sample](http://go.microsoft.com/fwlink/p/?linkid=231484), [Handle file activation](http://msdn.microsoft.com/library/a0f914c5-62bc-4ff7-9236-e34c5277c363), [Guidelines for file types and URIs](http://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [Windows.Storage](../windows.storage/windows_storage.md), [Windows.UI.Core.CoreApplicationView.Activated](../windows.applicationmodel.core/coreapplicationview_activated.md), [Windows.UI.Xaml.Application.OnFileActivated](../windows.ui.xaml/application_onfileactivated.md), [Association launching sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620490)