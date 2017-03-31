---
-api-id: M:Windows.Networking.NetworkOperators.HotspotAuthenticationContext.AbortAuthentication(System.Boolean)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void AbortAuthentication(System.Boolean markAsManual)
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationContext.AbortAuthentication

## -description
Aborts the current authentication attempt and disconnects the WLAN interface from the hotspot.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -parameters
### -param markAsManual
If **true**, Windows disables the auto-connect property for the corresponding WLAN profile and avoids future auto-connects to this hotspot. Otherwise, **false**.

## -remarks
[AbortAuthentication](hotspotauthenticationcontext_abortauthentication.md) should be called when authentication credentials can not be provided through [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md). Once [AbortAuthentication](hotspotauthenticationcontext_abortauthentication.md) is called, the authentication context is finalized and [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md), [AbortAuthentication](hotspotauthenticationcontext_abortauthentication.md), or [SkipAuthentication](hotspotauthenticationcontext_SkipAuthentication.md) should not be called again.

## -examples

## -see-also
