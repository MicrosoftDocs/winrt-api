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

It is an asynchronous version of [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md). It takes the same parameters, but the asynchronous operation only completes when the authentication is completed. In contrast, the [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md) API returns as soon as the authentication is started. On completion of this method, the results object may be examined to check the status of the authentication attempt.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -parameters
### -param userName
The *UserName* parameter of the Wireless Internet Service Provider roaming (WISPr) authentication protocol. [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md) performs URL encoding before submitting the value to the server. If this string is empty, the corresponding authentication parameter is skipped.

### -param password
The *Password* parameter of the WISPr authentication protocol. [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md) performs URL encoding before submitting the value to the server. If this string is empty, the corresponding authentication parameter is skipped.

### -param extraParameters
Additional parameters to be appended to the authentication string. [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md) appends this parameter after an "&amp;" character to the HTTP POST string as is without any encoding. This can be used to add multiple parameters. The default for this parameter is an empty string.

### -param markAsManualConnectOnFailure
If **true**, an application permanently disables the auto-connect property on a connection. If authentication fails, the connection will be disconnected and not retried in the current user session. Otherwise, **false**.

## -returns
Results of the Hotspot authentication request.

## -remarks

## -examples

## -see-also
