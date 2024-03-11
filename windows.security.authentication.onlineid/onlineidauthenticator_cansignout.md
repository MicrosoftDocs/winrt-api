---
-api-id: P:Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.CanSignOut
-api-type: winrt property
---

<!-- Property syntax
public bool CanSignOut { get; }
-->

# Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.CanSignOut

## -description
Indicates whether a user can sign out of the app, and whether to show the sign out link in the app.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -property-value
**True** if the user can sign out and the sign out link should be shown in the app, otherwise **false**.

## -remarks
An app that uses the [OnlineIdAuthenticator](onlineidauthenticator.md) class must show an option for the user to sign out. The sign out option must appear in the Settings charm, and the app must create a new page for its user account settings in Accounts. To see an example of how to add the sign out option and the account setting page, see the [Windows Account Authorization sample](https://github.com/microsoft/VCSamples/tree/9e1d4475555b76a17a3568369867f1d7b6cc6126/VC2012Samples/Windows%208%20samples/C%2B%2B/Windows%208%20app%20samples/Windows%20account%20authorization%20sample%20(Windows%208)).

If the user has a connected account, they can sign out by visiting the Users page in PC Settings.

If this property is **false**, a call to [SignOutUserAsync](onlineidauthenticator_signoutuserasync_658229157.md) fails with the **ONL_E_CONNECTED_ACCOUNT_CAN_NOT_SIGNOUT** error code.

## -examples
```javascript
var canSignOut = onlineIdAuthenticator.canSignOut;

if (Boolean(canSignOut)){

   // Add a "sign out" link to Charm settings.
}

```

## -see-also

[Windows Account Authorization sample](https://github.com/microsoft/VCSamples/tree/9e1d4475555b76a17a3568369867f1d7b6cc6126/VC2012Samples/Windows%208%20samples/C%2B%2B/Windows%208%20app%20samples/Windows%20account%20authorization%20sample%20(Windows%208))
