---
-api-id: P:Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest.Service
-api-type: winrt property
---

<!-- Property syntax
public string Service { get; }
-->

# Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest.Service

## -description
Identifies the service your app uses. The service name must match the DNS name you supplied when registering your app on [http://go.microsoft.com/fwlink/p/?linkid=241860](https://account.live.com/developers/applications/index). Tickets are issued only for this service. For apps that are requesting user consent to access stored in Live, you must pass the offers to which your app needs access. The available list of offers can be found at our [Scopes and Permissions](/office/) page. The ticket can then be used with the Live Connect REST apis to access data that a user has consented to give to the app. Check out our [REST APIs](/office/) topic to learn more. Alternatively, the app can use the Live Connect SDK which will make these calls itself.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -property-value
A string that represents the service.

## -remarks

## -examples

## -see-also