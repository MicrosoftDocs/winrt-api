---
-api-id: T:Windows.Devices.WiFi.WiFiAdapter
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WiFiAdapter : Windows.Devices.WiFi.IWiFiAdapter
-->

# Windows.Devices.WiFi.WiFiAdapter

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Use this class to enumerate local Wi-Fi adapters, initiate Wi-Fi scans, enumerate scan results, and to connect or disconnect individual adapters.

## -remarks
Your code uses the static methods of this class.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | ConnectAsync(WiFiAvailableNetwork,WiFiReconnectionKind,PasswordCredential,String,WiFiConnectionMethod) |
| 1709 | 16299 | GetWpsConfigurationAsync |

## -examples

## -see-also
