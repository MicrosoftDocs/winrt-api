---
-api-id: M:Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.AuthenticateUserAsync(Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.Authentication.OnlineId.UserAuthenticationOperation AuthenticateUserAsync(Windows.Security.Authentication.OnlineId.OnlineIdServiceTicketRequest request)
-->

# Windows.Security.Authentication.OnlineId.OnlineIdAuthenticator.AuthenticateUserAsync

## -description
Starts the asynchronous authentication request with one [OnlineIdServiceTicketRequest](onlineidserviceticketrequest.md) by showing the credential prompt if needed to collect credentials or consent and get the ticket. If a user is signed into a Windows 8 system with a Microsoft account, this user will be used for the authentication request.

> [!NOTE]
> If you are developing for Windows 10 or greater, use the [Windows.Security.Authentication.Web.Core](../windows.security.authentication.web.core/windows_security_authentication_web_core.md) APIs instead. For more information, see [Web account manager](/windows/uwp/security/web-account-manager).

## -parameters
### -param request
A request object that provides the ability for an app to specify the service and policy used to authenticate a Live user to obtain identity properties and tickets.

## -returns
An object representing the authentication operation.

## -remarks
<!-- The following is from the PM. Needs to be rewritten after Beta. -->
When using these methods, consider the following error-handling guidelines:
+ If the asynchronous authentication request fails, the error is captured in the errorcode of the [IAsyncInfo](/windows/desktop/api/asyncinfo/nn-asyncinfo-iasyncinfo) object.
+ If the asynchronous authentication requests starts and some of the tickets were obtained but some of them failed, the response is S_OK.
+ If the authentication request itself succeeded but individual tickets couldn’t be requested, [IAsyncInfo](/windows/desktop/api/asyncinfo/nn-asyncinfo-iasyncinfo) returns S_OK but [OnlineIdServiceTicket.ErrorCode](onlineidserviceticket_errorcode.md) captures individual ticket error codes.
+ If all of the ticket requests failed, the [IAsyncInfo](/windows/desktop/api/asyncinfo/nn-asyncinfo-iasyncinfo) will contain the actual error code.
+ If all calls succeeded and all of the tickets were successfully obtained, the error code will be S_OK indicating no error occurred .


## -examples

## -see-also
[AuthenticateUserAsync(IIterable(OnlineIdServiceTicketRequest), CredentialPromptType)](onlineidauthenticator_authenticateuserasync_1604613812.md)