---
-api-id: P:Windows.Security.Authentication.OnlineId.UserIdentity.SafeCustomerId
-api-type: winrt property
---

<!-- Property syntax
public string SafeCustomerId { get; }
-->

# Windows.Security.Authentication.OnlineId.UserIdentity.SafeCustomerId

## -description
Gets an obfuscated customer ID specific to the calling application. This ID allows your application to identify the user across sessions but cannot be used to share data between separate applications since each application will receive a distinct SafeCustomerId value for the same Microsoft account.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -property-value
An obfuscated customer ID specific to the calling application.

## -remarks

## -examples

## -see-also
