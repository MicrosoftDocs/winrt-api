---
-api-id: M:Windows.Networking.NetworkOperators.HotspotAuthenticationContext.IssueCredentialsAsync(System.String,System.String,System.String,System.Boolean)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.NetworkOperators.HotspotCredentialsAuthenticationResult> IssueCredentialsAsync(System.String userName, System.String password, System.String extraParameters, System.Boolean markAsManualConnectOnFailure)
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationContext.IssueCredentialsAsync

## -description
Asynchronously provides credentials to Windows for hotspot authentication Windows does not cache these credentials and another authentication event will be raised when the system connects to the same hotspot again.

It is an asynchronous version of [IssueCredentials](hotspotauthenticationcontext_issuecredentials_808909449.md). It takes the same parameters, but the asynchronous operation only completes when the authentication is completed. In contrast, the [IssueCredentials](hotspotauthenticationcontext_issuecredentials_808909449.md) API returns as soon as the authentication is started. On completion of this method, the results object may be examined to check the status of the authentication attempt.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -parameters
### -param userName
The *UserName* parameter of the Wireless Internet Service Provider roaming (WISPr) authentication protocol. [IssueCredentials](hotspotauthenticationcontext_issuecredentials_808909449.md) performs URL encoding before submitting the value to the server. If this string is empty, the corresponding authentication parameter is skipped.

### -param password
The *Password* parameter of the WISPr authentication protocol. [IssueCredentials](hotspotauthenticationcontext_issuecredentials_808909449.md) performs URL encoding before submitting the value to the server. If this string is empty, the corresponding authentication parameter is skipped.

### -param extraParameters
Additional parameters to be appended to the authentication string. [IssueCredentials](hotspotauthenticationcontext_issuecredentials_808909449.md) appends this parameter after an "&amp;" character to the HTTP POST string as is without any encoding. This can be used to add multiple parameters. The default for this parameter is an empty string.

### -param markAsManualConnectOnFailure
If **true**, an application permanently disables the auto-connect property on a connection. If authentication fails, the connection will be disconnected and not retried in the current user session. Otherwise, **false**.

## -returns
Results of the Hotspot authentication request.

## -remarks

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
