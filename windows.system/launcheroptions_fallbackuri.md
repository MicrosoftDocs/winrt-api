---
-api-id: P:Windows.System.LauncherOptions.FallbackUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri FallbackUri { get;  set; }
-->

# Windows.System.LauncherOptions.FallbackUri

## -description
Gets or sets a value that represents a URI that the user should be taken to in the browser if no app exists to handle the file type or URI.

## -property-value
URI that the user should be taken to in the browser.

## -remarks
You can only set the fallback URI property with http:// or https:// URI. If this property is set and there is no app installed to handle the file or URI being launched, the user's default browser is launched automatically and navigated to the specified URI. The user will not see an **Open With** dialog asking to choose an option in this case. You should only use the fallback URI when directing the user to the Microsoft Store is not appropriate, such as the case when the file or URI is only supported by a desktop app that is not listed on the Store. In all cases where there is an app on the Microsoft Store that supports the file or URI that you are launching, you should use the [PreferredApplicationPackageFamilyName](launcheroptions_preferredapplicationpackagefamilyname.md) and [PreferredApplicationDisplayName](launcheroptions_preferredapplicationdisplayname.md) to recommend that app to the user.

You cannot set the preferred application properties and the fallback URI at the same time, since only one fallback may be used. The Launcher API will fail if both fallbacks are set.

> **Windows 8.1**
> In Windows 8.1 only, this property also accepts Microsoft Store URIs. These URIs can be used as an alternative to the [PreferredApplicationPackageFamilyName](launcheroptions_preferredapplicationpackagefamilyname.md) and [PreferredApplicationDisplayName](launcheroptions_preferredapplicationdisplayname.md) properties to send the user to a specific app in the Store without popping an **Open With** dialog. This functionality is not supported on Windows Phone 8.1 or converged Windows 10 apps, and its use is not recommended.

## -examples
Call the [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions) | launchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md) method with **fallbackUri** set to the fallback URI.

```csharp
// The URI to launch
string uriToLaunch = @ "contoso:somearguments";
var uri = new Uri(uriToLaunch);

// The fallback URI
string uriFallback = @ "http://www.contoso.com/somearguments";
var fallbackUri = new Uri(fallbackUri);

async void DefaultLaunch()
{
   // Set the fallback URI
   var options = new Windows.System.LauncherOptions();
   options.FallbackUri = fallbackUri;

   // Launch the URI with the fallback URI
   var success = await Windows.System.Launcher.LaunchUriAsync(uri, options);

   if (success)
   {
      // URI launched
   }
   else
   {
      // URI launch failed
   }
}
```

```cppwinrt
// The URI to launch.
Windows::Foundation::Uri m_uri{ L"contoso:somearguments" };

// The fallback URI.
Windows::Foundation::Uri m_fallbackUri{ L"http://www.contoso.com/somearguments" };

Windows::Foundation::IAsyncAction MainPage::DefaultLaunch()
{
    // Set the fallback URI.
    Windows::System::LauncherOptions launcherOptions;
    launcherOptions.FallbackUri(m_fallbackUri);

    // Launch the URI.
    if (co_await Windows::System::Launcher::LaunchUriAsync(m_uri, launcherOptions))
    {
        // URI launched.
    }
    else
    {
        // URI launch failed.
    }
}
```

```cppcx
// The URI to launch
auto uri = ref new Windows::Foundation::Uri("contoso:somearguments");

// The fallback URI
auto fallbackUri = ref new Windows::Foundation::Uri("http://www.contoso.com/somearguments");

void MainPage::DefaultLaunch()
{
   // Set the fallback URI
   auto launchOptions = ref new Windows::System::LauncherOptions();
   launchOptions->FallbackUri = fallbackUri;

   // Launch the URI with the fallback URI
   concurrency::task<bool> launchUriOperation(Windows::System::Launcher::LaunchUriAsync(uri, launchOptions));
   launchUriOperation.then([](bool success)
   {
      if (success)
      {
         // URI launched
      }
      else
      {
         // URI launch failed
      }
   });
}
```

```vb
' The URI to launch
Dim uri As New Uri("contoso:somearguments")

' The fallback URI
Dim fallbackUri As New Uri("http://www.contoso.com/somearguments")

async Sub DefaultLaunch()

   ' Set the fallback URI
   Dim options = Windows.System.LauncherOptions()
   options.FallbackUri = fallbackUri

   ' Launch the URI with the fallback URI
   Dim success = await Windows.System.Launcher.LaunchUriAsync(uri, options)

   If success Then
      ' URI launched
   Else
      ' URI launch failed
   End If

End Sub
```

## -see-also
[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Launch the default app for a file](/windows/uwp/launch-resume/launch-the-default-app-for-a-file), [Launch the default app for a URI](/windows/uwp/launch-resume/launch-default-app), [Guidelines for file types and URIs](/windows/uwp/files/index), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)
