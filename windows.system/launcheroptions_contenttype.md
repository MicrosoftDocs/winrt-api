---
-api-id: P:Windows.System.LauncherOptions.ContentType
-api-type: winrt property
---

<!-- Property syntax
public string ContentType { get;  set; }
-->

# Windows.System.LauncherOptions.ContentType

## -description
Gets or sets the content type that is associated with a URI that represents a file on the network.

## -property-value
The content type of the URI.

## -remarks
ContentType may only be specified when launching a URI using [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md).

The **ContentType** property allows your app to specify a URI along with a content type. You can use this to associate a URI pointing to a resource on the network with a file type, instead of a URI scheme name. Windows will attempt to use the file type computed from the content type to select the app to launch. The default file handler is then passed the URI instead of a file path. So for example if you have an http:// URI pointing to a .docx file, clicking on it would normally open the browser and begin a file download. By using the **ContentType** property you can skip the intermediate step and have the default file handler launch immediately. The file handler can then directly access the file on the network using the path embedded in the URI.

If the handler is unable to work directly on the URI, a copy of the file will be downloaded on their behalf.

Because **ContentType** allows you to directly launch a file handler the same security checks that apply to file launching apply to URI launches with this option specified. See [Launch the default app for a file](/windows/uwp/launch-resume/launch-the-default-app-for-a-file) for more details on those security checks. 

> [!NOTE]
> This functionality only works if the default file handler supports being passed a URI to a file on the network. The default file handler must also be able to authenticate with the file's server. Because of these limitations you should only use the **ContentType** property if you have thoroughly tested the end to end scenario between your app and the app's that you expect to handle the files being launched

> [!IMPORTANT]
> This property is only implemented on Desktop devices.

## -examples
Call the [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md) method with **ContentType** set to the content type associated with the URI being launched.

```csharp
// The URI to launch
string uriToLaunch = @"http://www.contoso.com/SomeFile.docx";
var uri = new Uri(uriToLaunch);

async void DefaultLaunch()
{
   // Set the URI's content type
   var options = new Windows.System.LauncherOptions();
   options.ContentType = "application/vnd.ms-word.document.12";

   // Launch the URI with the content type
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
Windows::Foundation::Uri m_uri{ L"http://www.contoso.com/SomeFile.docx" };

Windows::Foundation::IAsyncAction MainPage::DefaultLaunch()
{
    // Set the URI's content type.
    Windows::System::LauncherOptions launcherOptions;
    launcherOptions.ContentType(L"application/vnd.ms-word.document.12");

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
// The URI to launch.
auto uri = ref new Windows::Foundation::Uri("http://www.contoso.com/SomeFile.docx");

void MainPage::DefaultLaunch()
{
   // Set the URI's content type
   auto launchOptions = ref new Windows::System::LauncherOptions();
   launchOptions->ContentType = "application/vnd.ms-word.document.12";

   // Launch the URI with the content type
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
Dim uri As New Uri("http://www.contoso.com/SomeFile.docx")

async Sub DefaultLaunch()

   ' Set the URI's content type
   Dim options = Windows.System.LauncherOptions()
   options.ContentType = "application/vnd.ms-word.document.12"

   ' Launch the URI with the content type
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
