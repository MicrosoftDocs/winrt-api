---
-api-id: P:Windows.Security.Authentication.OnlineId.UserIdentity.Tickets
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Security.Authentication.OnlineId.OnlineIdServiceTicket> Tickets { get; }
-->

# Windows.Security.Authentication.OnlineId.UserIdentity.Tickets

## -description
Contains an array of tickets that identify the user. If your app uses the JWT policy, only one ticket is returned. This value is only available to Microsoft application partners.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -property-value
An array of tickets that identify the user.

## -remarks

## -examples

## -see-also
[OnlineIdServiceTicket](onlineidserviceticket.md)