---
-api-id: M:Windows.Networking.NetworkOperators.HotspotAuthenticationContext.IssueCredentials(System.String,System.String,System.String,System.Boolean)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void IssueCredentials(System.String userName, System.String password, System.String extraParameters, System.Boolean markAsManualConnectOnFailure)
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationContext.IssueCredentials

## -description
Provides credentials to Windows for hotspot authentication

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

Windows does not cache these credentials and another authentication event will be raised when the system connects to the same hotspot again.

## -parameters
### -param userName
The *UserName* parameter of the Wireless Internet Service Provider roaming (WISPr) authentication protocol. [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md) performs URL encoding before submitting the value to the server. If this string is empty, the corresponding authentication parameter is skipped.

### -param password
The *Password* parameter of the WISPr authentication protocol. [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md) performs URL encoding before submitting the value to the server. If this string is empty, the corresponding authentication parameter is skipped.

### -param extraParameters
Additional parameters to be appended to the authentication string. [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md) appends this parameter after an "&amp;" character to the HTTP POST string as is without any encoding. This can be used to add multiple parameters. The default for this parameter is an empty string.

### -param markAsManualConnectOnFailure
If **true**, an application permanently disables the auto-connect property on a connection. If authentication fails, the connection will be disconnected and not retried in the current user session. Otherwise, **false**.

## -remarks
Once [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md) is called, the authentication context is finalized and [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md), [AbortAuthentication](hotspotauthenticationcontext_abortauthentication.md), or [SkipAuthentication](hotspotauthenticationcontext_SkipAuthentication.md) should not be called again.

## -examples

## -see-also
