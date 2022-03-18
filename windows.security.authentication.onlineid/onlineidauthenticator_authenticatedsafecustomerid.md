---
-api-id: P:Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.AuthenticatedSafeCustomerId
-api-type: winrt property
---

<!-- Property syntax
public string AuthenticatedSafeCustomerId { get; }
-->

# Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.AuthenticatedSafeCustomerId

## -description
Returns the ID of a user who has been successfully authenticated for your app.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -property-value
The ID of a user who has been successfully authenticated for your app.

## -remarks
This property returns the same user ID as the [UserIdentity.SafeCustomerId](useridentity_safecustomerid.md) property.

If the user was not successfully authenticated for your app, this property value is empty.

If your app stores local data based on the user's identity, you must check the authenticatedSafeCustomerId property to ensure there were no changes since the last authentication for your app. Check this property when your app is launched or activated, before getting the user identity and associated tickets.

## -examples

```csharp
string authenticatedSafeCustomerId = onlineIdAuthenticator.authenticatedSafeCustomerId;
if (authenticatedSafeCustomerId != string.Empty)
{
    // use
}

```

## -see-also
