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



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations). 

## -parameters
### -param markAsManual
If **true**, Windows disables the auto-connect property for the corresponding WLAN profile and avoids future auto-connects to this hotspot. Otherwise, **false**.

## -remarks
AbortAuthentication should be called when authentication credentials can not be provided through [IssueCredentials](hotspotauthenticationcontext_issuecredentials_808909449.md). Once AbortAuthentication is called, the authentication context is finalized and [IssueCredentials](hotspotauthenticationcontext_issuecredentials_808909449.md), AbortAuthentication, or [SkipAuthentication](hotspotauthenticationcontext_SkipAuthentication.md) should not be called again.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
