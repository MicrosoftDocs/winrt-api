---
-api-id: M:Windows.Devices.WiFi.WiFiAdapter.ConnectAsync(Windows.Devices.WiFi.WiFiAvailableNetwork,Windows.Devices.WiFi.WiFiReconnectionKind)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.WiFi.WiFiConnectionResult> ConnectAsync(Windows.Devices.WiFi.WiFiAvailableNetwork availableNetwork, Windows.Devices.WiFi.WiFiReconnectionKind reconnectionKind)
-->

# Windows.Devices.WiFi.WiFiAdapter.ConnectAsync

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Connect this Wi-Fi device to the specified network, with the specified reconnection policy.

## -parameters
### -param availableNetwork
Describes the Wi-Fi network to be connected.

### -param reconnectionKind
Specifies how to reconnect if the connection is lost.

## -returns
An asynchronous connect operation. On successful conclusion of the operation, returns an object that describes the result of the connect operation.

## -remarks

## -examples

## -see-also
[ConnectAsync(WiFiAvailableNetwork, WiFiReconnectionKind, PasswordCredential)](wifiadapter_connectasync_1490922496.md), [ConnectAsync(WiFiAvailableNetwork, WiFiReconnectionKind, PasswordCredential, String)](wifiadapter_connectasync_1798151424.md)