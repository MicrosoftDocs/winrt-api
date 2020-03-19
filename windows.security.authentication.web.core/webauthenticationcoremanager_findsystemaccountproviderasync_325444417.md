---
-api-id: M:Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.FindSystemAccountProviderAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<WebAccountProvider> WebAuthenticationCoreManager.FindSystemAccountProviderAsync(String webAccountProviderId, String authority)
-->

# Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.FindSystemAccountProviderAsync

## -description
Asynchronously attempts to find a web account provider for device-wide authentication.

## -parameters
### -param webAccountProviderId
The Id of the web account provider to find.

### -param authority
The authority of the web account provider to find.

## -returns
An asynchronous find operation. On successful completion, contains a [WebAccountProvider](../windows.security.credentials/webaccountprovider.md) object representing the found web account provider.

## -remarks
The device token feature is intended for cases in which a service needs to connect to cloud resources before a user ever signs into the device (for example, in out-of-box experiences where there are System Center Configuration Manager (SCCM) policies that must be applied right away). Only first-party ID providers (Xbox, MSA, AAD) allow device-wide tokens; other ID providers do not.

## -see-also
[IsSystemProvider](../windows.security.credentials/webaccountprovider_issystemprovider.md)

## -examples
The following is an example of this special case of device-wide token retrieval.

```csharp
// create a WebTokenRequest with device-wide authentication
WebTokenRequest CreateWebTokenRequestForAad(WebAccountProvider provider){
    // check if the ID provider allows system-wide scope, and construct token request accordingly:
    return new WebTokenRequest(
        provider,
        provider.IsSystemProvider ? "systemInfo" : "userInfo",
        "<InsertClientID>");
    )
}

// retrieve a device-wide auth token for Azure Active Directory
string GetAadToken() {
    var provider = WebAuthenticationCoreManager.FindSystemAccountProviderAsync(
        "https://login.microsoft.com","organizations");
    var request = CreateWebTokenRequestForAad(provider);
    var result = WebAuthenticationCoreManager.GetTokenSilentlyAsync(request);

    // handle the request result in the usual way.
    if (result.ResponseStatus == WebTokenRequestStatus.Success){ 
        return result.ResponseData[0].Token; 
    } else { 
        throw new Exception(result.ResponseError.ErrorMessage); 
    }     
} 
```
