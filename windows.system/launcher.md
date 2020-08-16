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

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://msdn.microsoft.com/en-us/library/windows/apps/hh771042.aspx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | FindAppUriHandlersAsync |
| 1607 | 14393 | LaunchUriForResultsForUserAsync(User,Uri,LauncherOptions) |
| 1607 | 14393 | LaunchUriForResultsForUserAsync(User,Uri,LauncherOptions,ValueSet) |
| 1607 | 14393 | LaunchUriForUserAsync(User,Uri) |
| 1607 | 14393 | LaunchUriForUserAsync(User,Uri,LauncherOptions) |
| 1607 | 14393 | LaunchUriForUserAsync(User,Uri,LauncherOptions,ValueSet) |
| 1607 | 14393 | QueryAppUriSupportAsync(Uri) |
| 1607 | 14393 | QueryAppUriSupportAsync(Uri,String) |
| 1809 | 17763 | LaunchFolderPathAsync(String) |
| 1809 | 17763 | LaunchFolderPathAsync(String,FolderLauncherOptions) |
| 1809 | 17763 | LaunchFolderPathForUserAsync(User,String) |
| 1809 | 17763 | LaunchFolderPathForUserAsync(User,String,FolderLauncherOptions) |

## -examples

**Launch a file contained in the app package**

See the code example in the [LaunchFileAsync(IStorageFile)](launcher_launchfileasync_1594978114.md) topic.

**Launch a URI**

See the code example in the [LaunchUriAsync(Uri)](launcher_launchuriasync_53691900.md) topic.

**Launch with a warning dialog**

This example calls [launchUriAsync(Uri, LauncherOptions)](launcher_launchuriasync_68890748.md) to launch a URI with a warning. Use the [treatAsUntrusted](launcheroptions_treatasuntrusted.md) property to indicate that the system should display a warning.

> [!NOTE]
> For a Windows app using JavaScript, call [preventDefault](https://docs.microsoft.com/previous-versions/windows/internet-explorer/ie-developer/platform-apis/ff975967(v=vs.85)) in your event handler if the [treatAsUntrusted](launcheroptions_treatasuntrusted.md) property is set and you are using an [anchor](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/a) element to launch the URI.

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

[How to launch the default app for a file (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh452687(v=win.10)), [Launch the default app for a file](https://docs.microsoft.com/windows/uwp/launch-resume/launch-the-default-app-for-a-file), [How to launch the default app for a URI (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh452690(v=win.10)), [Launch the default app for a URI](https://docs.microsoft.com/windows/uwp/launch-resume/launch-default-app), [Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Guidelines for file types and URIs](https://docs.microsoft.com/windows/uwp/files/index), [LauncherOptions](launcheroptions.md), [LauncherUIOptions](launcheruioptions.md)
