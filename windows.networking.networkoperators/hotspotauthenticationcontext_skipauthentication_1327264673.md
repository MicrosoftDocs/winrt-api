---
-api-id: M:Windows.Networking.NetworkOperators.HotspotAuthenticationContext.SkipAuthentication
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SkipAuthentication()
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationContext.SkipAuthentication

## -description
Skips Wireless Internet Service Provider roaming (WISPr) Windows authentication.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
[SkipAuthentication](hotspotauthenticationcontext_SkipAuthentication.md) can be used to implement a proprietary authentication flow. When [SkipAuthentication](hotspotauthenticationcontext_SkipAuthentication.md) is called, Windows checks the current Internet connectivity status over the corresponding network interface. Thus, applications implementing their own authentication should call this API when their authentication sequence is completed.

Once [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md) is called, the authentication context is finalized and [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md), [AbortAuthentication](hotspotauthenticationcontext_abortauthentication.md), or [SkipAuthentication](hotspotauthenticationcontext_SkipAuthentication.md) should not be called again.

## -examples

## -see-also
