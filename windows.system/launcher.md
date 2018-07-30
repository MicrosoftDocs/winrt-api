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

**Launch a file contained in the app package**

See the code example in the [LaunchFileAsync(IStorageFile)](launcher_launchfileasync_1594978114.md) topic.

**Launch a URI**

See the code example in the [LaunchUriAsync(Uri)](launcher_launchuriasync_53691900.md) topic.

**Launch with a warning dialog**

This example calls [launchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md) to launch a URI with a warning. Use the [treatAsUntrusted](launcheroptions_treatasuntrusted.md) property to indicate that the system should display a warning.

> [!NOTE]
> For a Windows app using JavaScript, call [preventDefault](https://msdn.microsoft.com/library/ff975967) in your event handler if the [treatAsUntrusted](launcheroptions_treatasuntrusted.md) property is set and you are using an [anchor](https://msdn.microsoft.com/library/ms535173) element to launch the URI.

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