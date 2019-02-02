---
-api-id: M:Windows.System.Launcher.LaunchFileAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> LaunchFileAsync(Windows.Storage.IStorageFile file)
-->

# Windows.System.Launcher.LaunchFileAsync

## -description
Starts the default app associated with the specified file.

## -parameters
### -param file
The file.

## -returns
The launch operation.

## -remarks
The calling app must be visible to the user when the API is invoked.

This API must be called from an ASTA thread (also known as a UI thread).

This API also imposes several restrictions on what types of files it can launch. Many file types that contain executable code, for example .exe, .msi, and .js files, are blocked from launching. This restriction protects users from potentially malicious files that could modify the system.

When the launch fails for any of the above reasons, the API succeeds and returns FALSE from its asynchronous operation. Since it has no ability to query whether the above restrictions apply to the current launch, the calling app should not assume that the launch succeeded, and should provide fallback mechanism in case it failed. A possible solution would be to ask the user to save the file and direct the user to open it in the desktop. 

To enable the user to choose an app instead of launching the default app, set the [LauncherOptions.DisplayApplicationPicker](launcheroptions_displayapplicationpicker.md) property.

To display a warning that the file is potentially unsafe, set the [LauncherOptions.TreatAsUntrusted](launcheroptions_treatasuntrusted.md) property.

The file is passed to the associated app. If the associated app is a desktop app, the file is passed using shell execution mechanisms.

## -examples
This example uses [LaunchFileAsync(IStorageFile)](launcher_launchfileasync_1594978114.md) to launch a file contained in the app package.

```csharp
async void DefaultLaunch()
{
   // Path to the file in the app package to launch
   string imageFile = @"images\test.png";

   var file = wait Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(imageFile);

   if (file != null)
   {
      // Launch the retrieved file
      var success = await Windows.System.Launcher.LaunchFileAsync(file);

      if (success)
      {
         // File launched
      }
      else
      {
         // File launch failed
      }
   }
   else
   {
      // Could not find file
   }
}
```

```cppwinrt
Windows::Foundation::IAsyncAction MainPage::DefaultLaunch()
{
    // Get the app's installation folder.
    Windows::Storage::StorageFolder installFolder{ Windows::ApplicationModel::Package::Current().InstalledLocation() };

    Windows::Storage::StorageFile file{ co_await installFolder.GetFileAsync(L"Assets\\LockScreenLogo.scale-200.png") };

    if (file)
    {
        // Launch the retrieved file.
        bool success{ co_await Windows::System::Launcher::LaunchFileAsync(file) };
        if (success)
        {
            // File launched.
        }
        else
        {
            // File launch failed.
        }
    }
    else
    {
        // Couldn't find file.
    }
}
```

```cpp
void MainPage::DefaultLaunch()
{
   auto installFolder = Windows::ApplicationModel::Package::Current->InstalledLocation;

   concurrency::task<Windows::Storage::StorageFile^> getFileOperation(installFolder->GetFileAsync("images\\test.png"));
   getFileOperation.then([](Windows::Storage::StorageFile^ file)
   {
      if (file != nullptr)
      {
         // Launch the retrieved file
         concurrency::task<bool> launchFileOperation(Windows::System::Launcher::LaunchFileAsync(file));
         launchFileOperation.then([](bool success)
         {
            if (success)
            {
               // File launched
            }
            else
            {
               // File launch failed
            }
         });
      }
      else
      {
         // Could not find file
      }
   });
}
```

```javascript
// Path to the file in the app package to launch
var imageFile = "images\\test.png";

// Get the image file from the package's image directory
Windows.ApplicationModel.Package.current.installedLocation.getFileAsync(imageFile).then(
  function (file) {
    // Launch the retrieved file using the default app
    Windows.System.Launcher.launchFileAsync(file).then(
      function (success) {
        if (success) {
            // File launched
        } else {
            // File launch failed
        }
      });
  });
```

```vbnet
async Sub DefaultLaunch()

   ' Path to the file in the app package to launch
   Dim imageFile = "images\test.png"

   Dim file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(imageFile)

   If file IsNot Nothing Then
      ' Launch the retrieved file
      Dim success = await Windows.System.Launcher.LaunchFileAsync(file)

      If success Then
         ' File launched
      Else
         ' File launch failed
      End If
   Else
      ' Could not find file
   End If
End Sub
```

## -see-also
[Association launching sample](https://go.microsoft.com/fwlink/p/?linkid=231484), [Guidelines for file types and URIs](https://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [How to launch the default app for a file (JavaScript)](https://msdn.microsoft.com/library/876edae5-f1a8-45f9-a1a6-50efb1025f96), [Launch the default app for a file](https://msdn.microsoft.com/library/bb45fcaf-df93-4c99-a8b5-59b799c7bd98), [LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md)
