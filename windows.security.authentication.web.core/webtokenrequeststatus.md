---
-api-id: T:Windows.Security.Authentication.Web.Core.WebTokenRequestStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Authentication.Web.Core.WebTokenRequestStatus : int
-->

# WebTokenRequestStatus

## -description
Represents the status of a web token request.

## -enum-fields
### -field Success:0
The request was successful.

### -field UserCancel:1
The request was cancelled by the user.

### -field AccountSwitch:2
The account associated with the request has switched. This status occurs when you attempt to use one web account, but the user indicates they wish to use a different web account instead.

### -field UserInteractionRequired:3
User interaction is required to complete the request. This option is only applicable to requests made with [GetTokenSilentlyAsync](webauthenticationcoremanager_gettokensilentlyasync_1117329698.md). If this status is returned, repeat the request with [RequestTokenAsync](webauthenticationcoremanager_requesttokenasync_1777535178.md).

### -field AccountProviderNotAvailable:4
The account provider was not available.

### -field ProviderError:5
There was a provider error. For information on how to handle this error, consult the provider's documentation.


## -remarks

## -examples

## -see-also
[Connect to identity providers with Web Account Manager](/windows/uwp/security/web-account-manager), [Web account management sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebAccountManagement)
