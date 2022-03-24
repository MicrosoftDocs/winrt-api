---
-api-id: T:Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator
-api-type: winrt class
---

<!-- Class syntax.
public class OnlineIdAuthenticator : Windows.Security.Authentication.OnlineId.IOnlineIdAuthenticator
-->

# Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator

## -description
Provides an app with the ability to start the authentication request to get JavaScript Object Notation (JSON) tokens to use with your service or request tickets that can be used to get data that the user has consented to for your app using the Live ConnectAPI.

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

> [!NOTE]
> If you're developing for Windows 10 or later, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -remarks

## -examples
The following example shows how to handle a user authentication request.

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