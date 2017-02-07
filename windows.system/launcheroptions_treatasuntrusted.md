---
-api-id: P:Windows.System.LauncherOptions.TreatAsUntrusted
-api-type: winrt property
---

<!-- Property syntax
public bool TreatAsUntrusted { get;  set; }
-->

# Windows.System.LauncherOptions.TreatAsUntrusted

## -description
Gets or sets a value that indicates whether the system should display a warning that the file or URI is potentially unsafe when starting the app associated with a file or URI.

## -property-value
True if the warning should be displayed; otherwise false.

## -remarks
> [!IMPORTANT]
> This property is only implemented on Desktop devices.

## -examples
This sample uses [LaunchUriAsync(Uri, LauncherOptions) | launchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md) to launch a URI with a warning. The [TreatAsUntrusted | treatAsUntrusted](launcheroptions_treatasuntrusted.md) property indicates that the system should display a warning.

```javascript

// The URI to launch
var uriToLaunch = "http://www.bing.com";

// Create a Uri object from a URI string 
var uri = new Windows.Foundation.Uri(uriToLaunch);

// Launch the URI with a warning prompt
var options = new Windows.System.LauncherOptions();
options.treatAsUntrusted = true;

Windows.System.Launcher.launchUriAsync(uri, options).then(
   function (success) {
      if (success) {
         // URI launched
      } else {
         // URI launch failed
      }
   });
```

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

```vbnet
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

```cpp
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



## -see-also
[Association launching sample](http://go.microsoft.com/fwlink/p/?linkid=231484), [How to launch the default app for a file (JavaScript)](http://msdn.microsoft.com/library/876edae5-f1a8-45f9-a1a6-50efb1025f96), [Launch the default app for a file](http://msdn.microsoft.com/library/bb45fcaf-df93-4c99-a8b5-59b799c7bd98), [How to launch the default app for a URI (JavaScript)](http://msdn.microsoft.com/library/0f9fa8db-3e51-4cf8-879d-2b79a8ddbb7d), [Launch the default app for a URI](http://msdn.microsoft.com/library/7b0d0af5-d89e-4db0-9b79-90201d79974f), [Guidelines for file types and URIs](http://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [Launcher.LaunchFileAsync(IStorageFile, LauncherOptions)](launcher_launchfileasync_1480137410.md), [Launcher.LaunchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md)