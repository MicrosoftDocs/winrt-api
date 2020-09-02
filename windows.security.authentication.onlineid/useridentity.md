---
-api-id: T:Windows.Security.Authentication.OnlineId.UserIdentity
-api-type: winrt class
---

<!-- Class syntax.
public class UserIdentity : Windows.Security.Authentication.OnlineId.IUserIdentity
-->

# Windows.Security.Authentication.OnlineId.UserIdentity

## -description
Contains the ID, tickets, and other information associated with a user.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -remarks

## -examples


```csharp
List<OnlineIdServiceTicketRequest> targetArray = new List<OnlineIdServiceTicketRequest>();
targetArray.Add(new OnlineIdServiceTicketRequest("wl.basic wl.contacts_photos wl.calendars",
        "DELEGATION"));

DebugPrint("Signing in ...");

Windows.Security.Authentication.OnlineId.UserIdentity result = 
        await _authenticator.AuthenticateUserAsync(targetArray, CredentialPromptType.PromptIfNeeded);

if (result.Tickets[0].Value != string.Empty)
{
    DebugPrint("Signed in.");
    IsNotSignedIn = false;
}
else
{
    // Handle errors like bad parameter, misconfigured target, and so on.
    DebugPrint("Unable to get the ticket. Error: " + result.Tickets[0].ErrorCode.ToString());
    IsNotSignedIn = true;
}
```



## -see-also