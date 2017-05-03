---
-api-id: M:Windows.System.Launcher.LaunchFileAsync(Windows.Storage.IStorageFile,Windows.System.LauncherOptions)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> LaunchFileAsync(Windows.Storage.IStorageFile file, Windows.System.LauncherOptions options)
-->

# Windows.System.Launcher.LaunchFileAsync

## -description
Starts the default app associated with the specified file, using the specified options.

## -parameters
### -param file
The file.

### -param options
The launch options for the app.

## -returns
The launch operation.

## -remarks
The calling app must be visible to the user when the API is invoked.

This API must be called from within an ASTA thread (also known as a UI thread).

This API also imposes several restrictions on what types of files it can launch. Many file types that contain executable code, for example .exe, .msi, and .js files, are blocked from launching. This restriction protects users from potentially malicious files that could modify the system.

When the launch fails for any of the above reasons, the API succeeds and returns FALSE from its asynchronous operation. Since it has no ability to query whether the above restrictions apply to the current launch, the calling app should not assume that the launch succeeded, and should provide fallback mechanism in case it failed. A possible solution would be to ask the user to save the file and direct the user to open it in the desktop. 

To enable the user to choose an app instead of launching the default app, set the [LauncherOptions.DisplayApplicationPicker | displayApplicationPicker](launcheroptions_displayapplicationpicker.md) property.

To display a warning that the file is potentially unsafe, set the [LauncherOptions.TreatAsUntrusted | treatAsUntrusted](launcheroptions_treatasuntrusted.md) property.



The file is passed to the associated app. If the associated app is a desktop app, the file is passed using shell execution mechanisms.

## -examples
Call the [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions) | launchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md) method with [LauncherOptions.DisplayApplicationPicker | displayApplicationPicker](launcheroptions_displayapplicationpicker.md) set to **true** to launch the app that the user selects for the file from the **Open With** dialog box.

```javascript

// Path to the file in the app package to launch
var imageFile = "images\\test.png";

// Get the image file from the package's image directory
Windows.ApplicationModel.Package.current.installedLocation.getFileAsync(imageFile).then(
  function (file) {
    // Set the show picker option
    var options = new Windows.System.LauncherOptions();
    options.displayApplicationPicker = true;

    // Launch the retrieved file using the selected app
    Windows.System.Launcher.launchFileAsync(file, options).then(
      function (success) {
        if (success) {
            // File launched
        } else {
            // File launch failed
        }
      });
  });
```

```csharp
async void DefaultLaunch()
{
   // Path to the file in the app package to launch
   string imageFile = @"images\test.png";

   var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(imageFile);

   if (file != null)
   {
      // Set the option to show the picker
      var options = new Windows.System.LauncherOptions();
      options.DisplayApplicationPicker = true;

      // Launch the retrieved file
      bool success = await Windows.System.Launcher.LaunchFileAsync(file, options);
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

```vbnet
async Sub DefaultLaunch()

   ' Path to the file in the app package to launch
   Dim imageFile = "images\test.png"

   Dim file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(imageFile)

   If file IsNot Nothing Then
      ' Set the option to show the picker
      Dim options = Windows.System.LauncherOptions()
      options.DisplayApplicationPicker = True

      ' Launch the retrieved file
      Dim success = await Windows.System.Launcher.LaunchFileAsync(file, options)

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

```cpp
void MainPage::DefaultLaunch()
{
   auto installFolder = Windows::ApplicationModel::Package::Current->InstalledLocation;

   concurrency::task<Windows::Storage::StorageFile^> getFileOperation(installFolder->GetFileAsync("images\\test.png"));
   getFileOperation.then([](Windows::Storage::StorageFile^ file)
   {
      if (file != nullptr)
      {
         // Set the option to show the picker
         auto launchOptions = ref new Windows::System::LauncherOptions();
         launchOptions->DisplayApplicationPicker = true;

         // Launch the retrieved file
         concurrency::task<bool> launchFileOperation(Windows::System::Launcher::LaunchFileAsync(file, launchOptions));
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



## -see-also
[Association launching sample](http://go.microsoft.com/fwlink/p/?linkid=231484), [Guidelines for file types and URIs](http://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [How to launch the default app for a file (JavaScript)](http://msdn.microsoft.com/library/876edae5-f1a8-45f9-a1a6-50efb1025f96), [Launch the default app for a file](http://msdn.microsoft.com/library/bb45fcaf-df93-4c99-a8b5-59b799c7bd98), [LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md)