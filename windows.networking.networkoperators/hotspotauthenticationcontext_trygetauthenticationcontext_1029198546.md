---
-api-id: M:Windows.Networking.NetworkOperators.HotspotAuthenticationContext.TryGetAuthenticationContext(System.String,Windows.Networking.NetworkOperators.HotspotAuthenticationContext@)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool TryGetAuthenticationContext(System.String evenToken, Windows.Networking.NetworkOperators.HotspotAuthenticationContext context)
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationContext.TryGetAuthenticationContext

## -description
Gets the context of an authentication attempt.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -parameters
### -param evenToken
The event token retrieved from the network operator hotspot authentication [event](hotspotauthenticationeventdetails.md). The token is a GUID in string format.

### -param context
The network operator hotspot authentication context.

## -returns
If **true**, the authentication context was retrieved. The authentication context can only be retrieved if the calling application matches the application ID specified in the hotspot profile of the underlying WLAN connection and if the authentication hasn’t be completed by the corresponding context already or timed out.

## -remarks

## -examples

## -see-also
