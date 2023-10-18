---
-api-id: T:Windows.Devices.WiFi.WiFiWpsConfigurationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum WiFiWpsConfigurationStatus : int 
-->

# Windows.Devices.WiFi.WiFiWpsConfigurationStatus

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Describes the status of the [GetWpsConfigurationAsync](wifiadapter_getwpsconfigurationasync_1613138554.md) call.
## -enum-fields
### -field UnspecifiedFailure:0
Connection failed for a reason other than those in this list.
### -field Timeout:2
Connection failed because the connection attempt timed out.
### -field Success:1
Connection succeeded.
## -remarks

## -see-also
[GetWpsConfigurationAsync](wifiadapter_getwpsconfigurationasync_1613138554.md)

## -examples
