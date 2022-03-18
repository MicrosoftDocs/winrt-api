---
-api-id: M:Windows.Security.Authentication.Web.Core.WebTokenRequestResult.InvalidateCacheAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction InvalidateCacheAsync()
-->

# Windows.Security.Authentication.Web.Core.WebTokenRequestResult.InvalidateCacheAsync

## -description
Invalidates the current cached [WebTokenRequestResult](webtokenrequestresult.md). See Remarks for proper usage.

## -returns
This method does not return an object or value.

## -remarks
While the default behavior of the Web Account Manager is to automatically remove cached tokens that become stale, there are some scenarios in which a token will stay cached even when it is not valid. If the [WebTokenRequestResult](WebTokenRequestResult.md) indicates that the token was rejected by the server, then this method should be called to remove that token from the WAM cache and a new token should be requested. 

## -examples

## -see-also
[Web account management code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebAccountManagement)
