---
-api-id: M:Windows.System.Launcher.LaunchUriAsync(Windows.Foundation.Uri,Windows.System.LauncherOptions)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> LaunchUriAsync(Windows.Foundation.Uri uri, Windows.System.LauncherOptions options)
-->

# Windows.System.Launcher.LaunchUriAsync

## -description
Starts the default app associated with the URI scheme name or the one specified by the [ContentType](launcheroptions_contenttype.md) for the specified URI, using the specified options.

## -parameters
### -param uri
The URI.

### -param options
The launch options for the app.

## -returns
Returns **true** if the default app for the URI scheme was launched; **false** otherwise.

## -remarks
Unless you are calling this API from a Windows desktop application, this API must be called from within an ASTA thread (also known as the UI thread).

This API may also be called from a Windows desktop application.

This API launches the default app for the scheme whether it be a Universal Windows Platform (UWP) app or Windows desktop application.

The calling app must be visible to the user when this API is invoked.

Unless you are calling this API from a Windows desktop application, this API must be called from within an ASTA thread (also known as a UI thread).

You must specify the **privateNetworkClientServer** capability in the manifest in order to launch intranet URIs, for example a file:/// URI pointing to a network location.

You cannot use this method to launch a URI in the local zone. For example, apps cannot use the **file:///** protocol to access files on the local computer. Instead, you must use the [Storage APIs](../windows.storage/windows_storage.md) to access files.

The content type is used to compute a file extension, from the extension the default app is chosen. For example a content type value of ""application/vnd.ms-word.document.12"" is mapped to ".docx" and then the default application for ".docx" is launched. For example:

```csharp

// this specifies the file type, which is used to bind to Word. 
launcherOptions.ContentType = "application/vnd.ms-word.document.12"; 
// and then this launches the file using the application
Launcher.LaunchUriAsync("http://www.cloud.com/file.docx", options);
```

When the launch fails for any of the above reasons, the API will succeed and return FALSE from its asynchronous operation.

To enable the user to choose an app instead of launching the default app, set the [LauncherOptions.DisplayApplicationPicker](launcheroptions_displayapplicationpicker.md) property.

To display a warning that the URI is potentially unsafe, set the [LauncherOptions.TreatAsUntrusted](launcheroptions_treatasuntrusted.md) property.

The URI is passed to the associated app. If the associated app is a desktop app, the URI is passed using shell execution mechanisms.

## -examples
This sample uses [LaunchUriAsync(Uri, LauncherOptions) to launch a URI with a warning. The [TreatAsUntrusted](launcheroptions_treatasuntrusted.md) property indicates that the system should display a warning.

```csharp
// The URI to launch
string uriToLaunch = @"http://www.bing.com";
var uri = new Uri(uriToLaunch);

async void DefaultLaunch()
{
   // Set the option to show a warning
   var options = new Windows.System.LauncherOptions();
   options.TreatAsUntrusted = true;

   // Launch the URI with a warning prompt
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
Windows::Foundation::Uri m_uri{ L"http://www.bing.com" };

Windows::Foundation::IAsyncAction MainPage::DefaultLaunch()
{
    // Set the option to show a warning
    Windows::System::LauncherOptions launcherOptions;
    launcherOptions.TreatAsUntrusted(true);

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
auto uri = ref new Windows::Foundation::Uri("http://www.bing.com");

void MainPage::DefaultLaunch()
{
   // Set the option to show a warning
   auto launchOptions = ref new Windows::System::LauncherOptions();
   launchOptions->TreatAsUntrusted = true;

   // Launch the URI with a warning prompt
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
Dim uri As New Uri("http://www.bing.com")

async Sub DefaultLaunch()

   ' Set the option to show a warning
   Dim options = Windows.System.LauncherOptions()
   options.TreatAsUntrusted = True

   ' Launch the URI with a warning prompt
   Dim success = await Windows.System.Launcher.LaunchUriAsync(uri, options)

   If success Then
      ' URI launched
   Else
      ' URI launch failed
   End If

End Sub
```

## -see-also
[LaunchUriAsync(Uri)](launcher_launchuriasync_53691900.md), [LaunchUriAsync(Uri, LauncherOptions, ValueSet)](launcher_launchuriasync_569877360.md), [Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Guidelines for file types and URIs](/windows/uwp/files/index), [Launch the default app for a URI](/windows/uwp/launch-resume/launch-default-app)
