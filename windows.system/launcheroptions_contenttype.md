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

Because **ContentType** allows you to directly launch a file handler the same security checks that apply to file launching apply to URI launches with this option specified. See [Launch the default app for a file](http://msdn.microsoft.com/library/bb45fcaf-df93-4c99-a8b5-59b799c7bd98) and [How to launch the default app for a file (JavaScript)](http://msdn.microsoft.com/library/876edae5-f1a8-45f9-a1a6-50efb1025f96) for more details on those security checks. 

> [!NOTE]
> This functionality only works if the default file handler supports being passed a URI to a file on the network. The default file handler must also be able to authenticate with the file’s server. Because of these limitations you should only use the **ContentType** property if you have thoroughly tested the end to end scenario between your app and the app’s that you expect to handle the files being launched

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
   // Set the URI’s content type
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

```cpp
// The URI to launch.
auto uri = ref new Windows::Foundation::Uri("http://www.contoso.com/SomeFile.docx");

void MainPage::DefaultLaunch()
{
   // Set the URI’s content type
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

```javascript
// The URI to launch
var uriToLaunch = "http://www.contoso.com/SomeFile.docx";

// Create a Uri object from a URI string 
var uri = new Windows.Foundation.Uri(uriToLaunch);

// Set the URI’s content type
var options = new Windows.System.LauncherOptions();
options.contentType = "application/vnd.ms-word.document.12";

Windows.System.Launcher.launchUriAsync(uri, options).then(
   function (success) {
      if (success) {
         // URI launched
      } else {
         // URI launch failed
      }
   });
```

```vb
' The URI to launch
Dim uri As New Uri("http://www.contoso.com/SomeFile.docx")

async Sub DefaultLaunch()

   ' Set the URI’s content type
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
[Association launching sample](http://go.microsoft.com/fwlink/p/?linkid=231484), [How to launch the default app for a file (JavaScript)](http://msdn.microsoft.com/library/876edae5-f1a8-45f9-a1a6-50efb1025f96), [Launch the default app for a file](http://msdn.microsoft.com/library/bb45fcaf-df93-4c99-a8b5-59b799c7bd98), [How to launch the default app for a URI (JavaScript)](http://msdn.microsoft.com/library/0f9fa8db-3e51-4cf8-879d-2b79a8ddbb7d), [Launch the default app for a URI](http://msdn.microsoft.com/library/7b0d0af5-d89e-4db0-9b79-90201d79974f), [Guidelines for file types and URIs](http://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)