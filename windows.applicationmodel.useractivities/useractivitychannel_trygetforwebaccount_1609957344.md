---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivityChannel.TryGetForWebAccount(Windows.Security.Credentials.WebAccount)
-api-type: winrt method
---

<!-- Method syntax.
public UserActivityChannel UserActivityChannel.TryGetForWebAccount(WebAccount account)
-->

# Windows.ApplicationModel.UserActivities.UserActivityChannel.TryGetForWebAccount

## -description
Get a channel, specific to a specified web account, to use to record user activity.

## -parameters
### -param account
The web account to associate user activity with.

## -returns
The channel to use to record user activity. The channel will be associated with the web account.

## -remarks
Some apps, such as Mail, support multiple user accounts within a single instance of the app. If the user has a Microsoft Account (MSA) and an Azure Active Directory account (AAD), the app can choose to write to the activity feed associated with the MSA account or the AAD account.

## -see-also

## -examples
```csharp
private static UserActivityChannel _currentChannel;

public static void UpdateActivityChannelForAccount(WebAccount account)
{
    _currentChannel = UserActivityChannel.TryGetForWebAccount(account);
    if (_currentChannel != null)
    {
        // app-specific – generate activity that will be associated with the web account
    }
}
```
