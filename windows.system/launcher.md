---
-api-id: T:Windows.System.Launcher
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class Launcher 
-->

# Windows.System.Launcher

## -description
Starts the default app associated with the specified file or URI.

## -remarks
> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
**Launch a file contained in the app package**This example uses [LaunchFileAsync(IStorageFile) | launchFileAsync(IStorageFile)](launcher_launchfileasync_1594978114.md) to launch a file contained in the app package.

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

```csharp
async void DefaultLaunch()
{
   // Path to the file in the app package to launch
   string imageFile = @"images\test.png";

   var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(imageFile);

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

**Launch a URI**This example uses [LaunchUriAsync(Uri) | launchUriAsync(Uri)](launcher_launchuriasync_53691900.md) to launch a URI.

```javascript

// The URI to launch
var uriToLaunch = "http://www.bing.com";

// Create a Uri object from a URI string 
var uri = new Windows.Foundation.Uri(uriToLaunch);

// Launch the URI
Windows.System.Launcher.launchUriAsync(uri).then(   
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

// Create a Uri object from a URI string 
var uri = new Uri(uriToLaunch);

// Launch the URI
async void DefaultLaunch()
{
   // Launch the URI
   var success = await Windows.System.Launcher.LaunchUriAsync(uri);

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

   ' Launch the URI
   Dim success = await Windows.System.Launcher.LaunchUriAsync(uri)

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
   // Launch the URI
   concurrency::task<bool> launchUriOperation(Windows::System::Launcher::LaunchUriAsync(uri));
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

**Launch with a warning dialog**Call [launchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md) to launch a URI with a warning. Use the [treatAsUntrusted](launcheroptions_treatasuntrusted.md) property to indicate that the system should display a warning.

> [!NOTE]
> For Windows app using JavaScript, call [preventDefault](XREF:TODO:wwa.IDOMEvent_preventDefault) in your event handler if the [treatAsUntrusted](launcheroptions_treatasuntrusted.md) property is set and you are using an [a](XREF:TODO:wwa.A_Element_A_Object) element to launch the URI.

```javascript
function linkClickHandler(eventInfo) {
    var link = eventInfo.target;
    if (eventInfo.srcElement && (
        (eventInfo.type === "click") ||
        (eventInfo.type === "keydown" && (
        eventInfo.keyCode === WinJS.Utilities.Key.enter ||
        eventInfo.keyCode === WinJS.Utilities.Key.space)))) {
        eventInfo.preventDefault();
        if (link.href.indexOf("ms-appx") > -1) {
            WinJS.Navigation.navigate(link.href);
        }
        else if (link.href.indexOf("http") > -1) {
            // Create a Uri object from a URI string 
            var uri = new Windows.Foundation.Uri(link.href);
            var options = new Windows.System.LauncherOptions();
            // Launch the URI with a warning prompt
            options.treatAsUntrusted = true;
            // Launch the URI
            Windows.System.Launcher.launchUriAsync(uri, options).then(
                function (success) {
                    if (success) {
                        // URI launched
                    } else {
                        // URI launch failed
                    }
                });
        }
    }
}
```



## -see-also
[How to launch the default app for a file (JavaScript)](http://msdn.microsoft.com/library/876edae5-f1a8-45f9-a1a6-50efb1025f96), [Launch the default app for a file](http://msdn.microsoft.com/library/bb45fcaf-df93-4c99-a8b5-59b799c7bd98), [How to launch the default app for a URI (JavaScript)](http://msdn.microsoft.com/library/0f9fa8db-3e51-4cf8-879d-2b79a8ddbb7d), [Launch the default app for a URI](http://msdn.microsoft.com/library/7b0d0af5-d89e-4db0-9b79-90201d79974f), [Association launching sample](http://go.microsoft.com/fwlink/p/?linkid=231484), [Guidelines for file types and URIs](http://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [LauncherOptions](launcheroptions.md), [LauncherUIOptions](launcheruioptions.md)