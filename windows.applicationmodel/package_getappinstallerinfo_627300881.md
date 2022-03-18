---
-api-id: M:Windows.ApplicationModel.Package.GetAppInstallerInfo
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public AppInstallerInfo Package.GetAppInstallerInfo()
-->

# Windows.ApplicationModel.Package.GetAppInstallerInfo

## -description

Returns the .appinstaller XML file location. Use this method when you need to retrieve the .appinstaller XML file location for your app. For example, this is useful if your app needs to share a URI to its associated .appinstaller file. You can optionally add arguments to the URI.

## -returns

The .appinstaller XML file location.

## -remarks

Use this method if you want to get the URI to the .appinstaller file associated with the current app so you can share the URI with users. If a user who doesn't have the app clicks the URI, they are taken through the install process for the app. If a user who already has the app clicks the URI, the app is updated if needed and then it opens.

You can optionally add arguments to the URI. In this case, the behavior is the same as described above, but the app can then use the arguments when it opens. The arguments must use a protocol that the app supports. For more information, see [Handle URI activation](/windows/uwp/launch-resume/handle-uri-activation).

## -see-also

[AppInstallerInfo.Uri](appinstallerinfo_uri.md),[App Installer APIs](/windows/msix/app-installer/app-installer-documentation#app-installer-file-apis),[Handle URI activation](/windows/uwp/launch-resume/handle-uri-activation)

## -examples

The following example generates an .appinstaller URI with arguments and creates an email to send the URI to another user. In this example, the ```ComposeEmailAsync``` method is assumed to be defined elsewhere.

```csharp
AppInstallerInfo info = Windows.ApplicationModel.Package.Current.GetAppInstallerInfo();
if (info != null)
{
    // Uri that was used to install the app.
    // Example: http://contoso/connect4.appinstaller.
    Uri appInstallerUri = info.Uri;

    // Create the inner URI which uses a protocol handled by your app, passing any arguments needed in it 
    UriBuilder innerUriBuilder = new UriBuilder("my-app-protocol:");
    innerUriBuilder.Query = "difficulty=hard&highscore=9000";

    // Create outer URI builder for ms-appinstaller initializer link.
    UriBuilder outerUriBuilder = new UriBuilder("ms-appinstaller:");
    outerUriBuilder.Query =
        $"source={Uri.EscapeDataString(appInstallerUri.ToString())}&activationUri={Uri.EscapeDataString(innerUriBuilder.ToString())}";

    await ComposeEmailAsync(/* To */ colleagueEmail, /* Subject */ "Beat my high score!",
        /* Body */ outerUriBuilder.ToString());
}
```