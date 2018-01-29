---
-api-id: P:Windows.Security.Credentials.WebAccountProvider.IsSystemProvider
-api-type: winrt property
---

<!-- Property syntax.
public bool IsSystemProvider { get; }
-->

# Windows.Security.Credentials.WebAccountProvider.IsSystemProvider

## -description
Gets the value describing whether the given ID provider supports system-wide authentication tokens.

## -property-value
**True** if the WebAccountProvider allows system-wide authentication tokens. Otherwise **False**.

## -remarks
The device token feature is intended for cases in which a service needs to connect to cloud resources before a user ever signs into the device (for example, in out-of-box experiences where there are System Center Configuration Manager (SCCM) policies that must be applied right away). Only first-party ID providers (Xbox, MSA, AAD) allow device-wide tokens; other ID providers do not.

## -see-also
**[FindSystemAccountProviderAsync](../windows.security.authentication.web.core/webauthenticationcoremanager_findsystemaccountproviderasync_325444417.md)**

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
