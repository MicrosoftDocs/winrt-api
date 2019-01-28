---
-api-id: T:Windows.ApplicationModel.AppInstallerInfo
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class AppInstallerInfo 
-->

# Windows.ApplicationModel.AppInstallerInfo

## -description

The AppInstallerInfo class allows read-only access to the Uri field for the .appinstaller xml file location. This allows app developers to retrieve the .appinstaller xml file location when needed by their app.

## -remarks

## -see-also
[Windows.ApplicationModel.AppInstallerInfo.Uri](appinstallerinfo_uri.md)

## -examples

If the app developer wants to post or send a link of the .appinstaller URI that was used to install the app from their internal network, the developer would do the following:

```csharp

AppInstallerInfo info = Windows.ApplicationModel.Package.Current.GetAppInstallerInfo();
if (info != null)
{
    // Uri that was used to install the app. 
    // Example: http://ie-snap/scratchtests/joshusto/connect4.appinstaller.
    Uri appInstallerUri = info.Uri;
    // Pass to URI builder and provide optional args.
    UriBuilder innerUriBuilder = new UriBuilder(appInstallerUri);
    innerUriBuilder.Query = "difficulty=hard&highscore=9000";
    // Create outer URI builder for ms-appinstaller initializer link.
    UriBuilder outerUriBuilder = new UriBuilder("ms-appinstaller:");
    outerUriBuilder.Query = $"source={Uri.EscapeDataString(innerUriBuilder.ToString())}";
    await ComposeEmailAsync( /* To */ colleagueEmail, /* Subject */ "Beat my high score!", /* Body */ outerUriBuilder.ToString());
}
```
