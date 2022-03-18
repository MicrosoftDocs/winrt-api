---
-api-id: T:Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest
-api-type: winrt class
---

<!-- Class syntax.
public class OnlineIdServiceTicketRequest : Windows.Security.Authentication.OnlineId.IOnlineIdServiceTicketRequest
-->

# Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest

## -description
Provides the ability for an app to specify the service and policy that is used to authenticate a Live user to obtain identity properties and tickets.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -remarks

## -examples
The following example shows how to specify the service and policy that is used to authenticate a Live user.

```javascript
function signIn() {
    var authenticator = new Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator();
    var serviceTicketRequest = new Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest(
        "wl.basic wl.contacts_photos wl.calendars", "DELEGATION");

    sdkSample.displayStatus("Signing in...");

    authenticator.authenticateUserAsync(serviceTicketRequest)
        .done(function (authResult) {

            if ((authResult.tickets.size == 1) && (authResult.tickets[0].errorCode == 0)) {
                sdkSample.isSignedIn = true;
                sdkSample.displayStatus("Authorization succeeded.");
                sdkSample.accessToken = authResult.tickets[0];
                sdkSample.canSignOut = authenticator.canSignOut;
            }
        },

            function (authStatus) {
                if (authStatus && (authStatus.name !== "Canceled")) {
                    showErrorMessage("Autorization failed: " + authStatus.message);
                } else {
                    sdkSample.displayStatus("");
                }
                    showAccountStatus();
                });
}
```

<!--<auto_snippet snippet_id="OnlineIdAuthenticator" sample_id="MicrosoftAccount"  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"/>-->

## -see-also