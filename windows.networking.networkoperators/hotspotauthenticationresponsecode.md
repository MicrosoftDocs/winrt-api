---
-api-id: T:Windows.Networking.NetworkOperators.HotspotAuthenticationResponseCode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.HotspotAuthenticationResponseCode : int
-->

# HotspotAuthenticationResponseCode

## -description
Defines values used to indicate status of connection authentication with a mobile hotspot. Provides the response code from the WISPr server for an authentication attempt.

Possible values are defined in the .

## -enum-fields
### -field NoError:0
No response returned.

### -field LoginSucceeded:50
Hotspot authentication successful.

### -field LoginFailed:100
Hotspot authentication failed.

### -field RadiusServerError:102
No response from authentication server.

### -field NetworkAdministratorError:105
An error occurred that requires contacting the network administrator.

### -field LoginAborted:151
The authentication request was aborted.

### -field AccessGatewayInternalError:255
An internal error occurred in the access gateway.


## -remarks

## -examples

## -see-also
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
