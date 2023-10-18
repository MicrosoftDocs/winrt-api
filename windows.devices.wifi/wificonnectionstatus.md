---
-api-id: T:Windows.Devices.WiFi.WiFiConnectionStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.WiFi.WiFiConnectionStatus : int
-->

# WiFiConnectionStatus

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Status of the connection attempt.

## -enum-fields
### -field UnspecifiedFailure:0
Connection failed for a reason other than those in this list.

### -field Success:1
Connection succeeded.

### -field AccessRevoked:2
Connection failed because access to the network has been revoked.

### -field InvalidCredential:3
Connection failed because an invalid credential was presented.

### -field NetworkNotAvailable:4
Connection failed because the network is not available.

### -field Timeout:5
Connection failed because the connection attempt timed out.

### -field UnsupportedAuthenticationProtocol:6
Connection failed because the authentication protocol is not supported.


## -remarks

## -examples

## -see-also
[WiFiConnectionResult.ConnectionStatus](wificonnectionresult_connectionstatus.md)