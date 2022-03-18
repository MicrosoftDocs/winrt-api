---
-api-id: T:Windows.Security.Authentication.OnlineId.SignOutUserOperation
-api-type: winrt class
---

<!-- Class syntax.
public class SignOutUserOperation : Windows.Foundation.IAsyncAction, Windows.Foundation.IAsyncInfo
-->

# Windows.Security.Authentication.OnlineId.SignOutUserOperation

## -description
Allows users to sign out of your app.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -remarks

## -examples
This example shows how to sign out of an app.

```javascript
function signOut() {
    if (sdkSample.canSignOut) {
        sdkSample.displayStatus("Signing out...");
        authenticator.signOutUserAsync().done(function () {
            sdkSample.accessToken = null;
            sdkSample.authenticatedSafeCustomerId = "";
            sdkSample.isSignedIn = false;
            sdkSample.displayStatus("Signed out.");
        },
            function (status) {
            if (status && (status.name !== "Canceled")) {
                showErrorMessage("Sign out action failed: " + status.message);
            } else {
                sdkSample.displayStatus("");
            }
        });
    }
}
```

<!--<auto_snippet snippet_id="SignOutUserOperation" sample_id="MicrosoftAccount"  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"/>-->

## -see-also