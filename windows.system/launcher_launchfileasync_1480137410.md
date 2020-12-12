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

To enable the user to choose an app instead of launching the default app, set the [LauncherOptions.DisplayApplicationPicker](launcheroptions_displayapplicationpicker.md) property.

To display a warning that the file is potentially unsafe, set the [LauncherOptions.TreatAsUntrusted](launcheroptions_treatasuntrusted.md) property.

The file is passed to the associated app. If the associated app is a desktop app, the file is passed using shell execution mechanisms.

## -examples

Call the [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions) method with [LauncherOptions.DisplayApplicationPicker](launcheroptions_displayapplicationpicker.md) set to **true** to launch the app that the user selects for the file from the **Open With** dialog box.

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

```cppwinrt
Windows::Foundation::IAsyncAction MainPage::DefaultLaunch()
{
    // Get the app's installation folder.
    Windows::Storage::StorageFolder installFolder{ Windows::ApplicationModel::Package::Current().InstalledLocation() };

    Windows::Storage::StorageFile file{ co_await installFolder.GetFileAsync(L"Assets\\LockScreenLogo.scale-200.png") };

    if (file)
    {
        // Set the option to show the picker.
        Windows::System::LauncherOptions launcherOptions;
        launcherOptions.DisplayApplicationPicker(true);

        // Launch the retrieved file.
        bool success{ co_await Windows::System::Launcher::LaunchFileAsync(file, launcherOptions) };
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

```cppcx
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

```vb
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

## -see-also
[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Guidelines for file types and URIs](/windows/uwp/files/index), [Launch the default app for a file](/windows/uwp/launch-resume/launch-the-default-app-for-a-file), [LaunchFileAsync(IStorageFile, LauncherOptions)
