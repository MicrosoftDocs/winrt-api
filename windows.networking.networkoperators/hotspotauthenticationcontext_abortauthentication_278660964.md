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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

## -parameters
### -param markAsManual
If **true**, Windows disables the auto-connect property for the corresponding WLAN profile and avoids future auto-connects to this hotspot. Otherwise, **false**.

## -remarks
[AbortAuthentication](hotspotauthenticationcontext_abortauthentication.md) should be called when authentication credentials can not be provided through [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md). Once [AbortAuthentication](hotspotauthenticationcontext_abortauthentication.md) is called, the authentication context is finalized and [IssueCredentials](hotspotauthenticationcontext_issuecredentials.md), [AbortAuthentication](hotspotauthenticationcontext_abortauthentication.md), or [SkipAuthentication](hotspotauthenticationcontext_SkipAuthentication.md) should not be called again.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
