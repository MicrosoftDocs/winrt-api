---
-api-id: P:Windows.System.LauncherOptions.PreferredApplicationDisplayName
-api-type: winrt property
---

<!-- Property syntax
public string PreferredApplicationDisplayName { get;  set; }
-->

# Windows.System.LauncherOptions.PreferredApplicationDisplayName

## -description
Gets or sets a value that represents the display name of the app in the store that the user should install if no app exists to handle the file type or URI.

## -property-value
The display name of the app.

## -remarks
In some cases the user may not have an app installed to handle the file that you are launching. By default, Windows will handle these cases by providing the user with a link to search for an appropriate app on the store. Use **LauncherOptions.PreferredApplicationDisplayName** in conjunction with **LauncherOptions.preferredApplicationPackageFamilyName** to provide the user with an app in the Windows Store that they can acquire to handle the file. The display name that you use should correspond to the display name of the app in the Windows Store.

You must set both of these preferred application properties to recommend an app. Setting one without the other will result in a failure.

> [!NOTE]
> You cannot set the preferred application properties and the fallback URI at the same time, since only one fallback may be used. The Launcher API will fail if both fallbacks are set.

> [!IMPORTANT]
> This property is only implemented on Desktop devices.

## -examples
Call the [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions) | launchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md) method with **preferredApplicationDisplayName** set to the display name of an app in the Windows Store and the **preferredApplicationPackageFamilyName** set to the package family name of an app in the Windows Store.

```csharp
async void DefaultLaunch()
{
   // Path to the file in the app package to launch
   string imageFile = @"images\test.png";

   // Get the image file from the package's image directory
   var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(imageFile);

   if (file != null)
   {
      // Set the recommended app
      var options = new Windows.System.LauncherOptions();
      options.PreferredApplicationPackageFamilyName = "Contoso.FileApp_8wknc82po1e";
      options.PreferredApplicationDisplayName = "Contoso File App";


      // Launch the retrieved file pass in the recommended app 
      // in case the user has no apps installed to handle the file
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
        // Set the recommended app.
        Windows::System::LauncherOptions launcherOptions;
        launcherOptions.PreferredApplicationPackageFamilyName(L"Contoso.FileApp_8wknc82po1e");
        launcherOptions.PreferredApplicationDisplayName(L"Contoso File App");

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
         // Set the recommended app
         auto launchOptions = ref new Windows::System::LauncherOptions();
         launchOptions->PreferredApplicationPackageFamilyName = "Contoso.FileApp_8wknc82po1e";
         launchOptions->PreferredApplicationDisplayName = "Contoso File App";
         
         // Launch the retrieved file pass in the recommended app 
         // in case the user has no apps installed to handle the file
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

   ' Get the image file from the package's image directory
   Dim file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(imageFile)

   If file IsNot Nothing Then
      ' Set the recommended app
      Dim options = Windows.System.LauncherOptions()
      options.PreferredApplicationPackageFamilyName = "Contoso.FileApp_8wknc82po1e";
      options.PreferredApplicationDisplayName = "Contoso File App";

      ' Launch the retrieved file pass in the recommended app 
      ' in case the user has no apps installed to handle the file
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
[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Launch the default app for a file](/windows/uwp/launch-resume/launch-the-default-app-for-a-file), [Launch the default app for a URI](/windows/uwp/launch-resume/launch-default-app), [Guidelines for file types and URIs](/windows/uwp/files/index), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)
