---
-api-id: T:Windows.Devices.WiFi.WiFiAccessStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.WiFi.WiFiAccessStatus : int
-->

# WiFiAccessStatus

## -description

> [!IMPORTANT]
> Location consent is now required for Wi-Fi BSSID access. For details on how this affects apps using Wi-Fi or location APIs,
> see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Used to report the results of an attempt to request access to a Wi-Fi adapter.

## -enum-fields
### -field Unspecified:0
The asynchronous request has not completed yet.

### -field Allowed:1
Access has been allowed.

### -field DeniedByUser:2
Access has been denied by the user, through the user interface.

### -field DeniedBySystem:3
Access has been denied by the system.


## -remarks

## -examples

## -see-also
[WiFiAdapter.RequestAccessAsync](wifiadapter_requestaccessasync_380675631.md)
