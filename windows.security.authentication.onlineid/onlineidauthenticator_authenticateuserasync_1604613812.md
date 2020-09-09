---
-api-id: M:Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.AuthenticateUserAsync(Windows.Foundation.Collections.IIterable{Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest},Windows.Security.Authentication.OnlineId.CredentialPromptType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Authentication.OnlineId.UserAuthenticationOperation AuthenticateUserAsync(Windows.Foundation.Collections.IIterable<Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest> requests, Windows.Security.Authentication.OnlineId.CredentialPromptType credentialPromptType)
-->

# Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.AuthenticateUserAsync

## -description
Starts the async authentication request with multiple [OnlineIdServiceTicketRequests](onlineidserviceticketrequest.md) and provides the ability to control the user experience by setting the [CredentialPromptType](credentialprompttype.md) to get the tickets. If a user is signed into a Windows 8 system with a Microsoft account, this user will be used for the authentication request.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -parameters
### -param requests
A collection of requests.

### -param credentialPromptType
The type of credentials.

## -returns
An object representing the authentication operation.

## -remarks

## -examples

## -see-also
[AuthenticateUserAsync(OnlineIdServiceTicketRequest)](onlineidauthenticator_authenticateuserasync_1571862957.md)