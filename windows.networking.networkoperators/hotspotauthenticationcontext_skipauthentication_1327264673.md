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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations). 

## -remarks
[SkipAuthentication](hotspotauthenticationcontext_SkipAuthentication.md) can be used to implement a proprietary authentication flow. When [SkipAuthentication](hotspotauthenticationcontext_SkipAuthentication.md) is called, Windows checks the current Internet connectivity status over the corresponding network interface. Thus, applications implementing their own authentication should call this API when their authentication sequence is completed.

Once [IssueCredentials](hotspotauthenticationcontext_issuecredentials_808909449.md) is called, the authentication context is finalized and [IssueCredentials](hotspotauthenticationcontext_issuecredentials_808909449.md), [AbortAuthentication](hotspotauthenticationcontext_abortauthentication_278660964.md), or [SkipAuthentication](hotspotauthenticationcontext_SkipAuthentication.md) should not be called again.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
