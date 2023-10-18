---
-api-id: M:Windows.Devices.WiFi.WiFiAdapter.ConnectAsync(Windows.Devices.WiFi.WiFiAvailableNetwork,Windows.Devices.WiFi.WiFiReconnectionKind,Windows.Security.Credentials.PasswordCredential,System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.WiFi.WiFiConnectionResult> ConnectAsync(Windows.Devices.WiFi.WiFiAvailableNetwork availableNetwork, Windows.Devices.WiFi.WiFiReconnectionKind reconnectionKind, Windows.Security.Credentials.PasswordCredential passwordCredential, System.String ssid)
-->

# Windows.Devices.WiFi.WiFiAdapter.ConnectAsync

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Connect this Wi-Fi device to a hidden network, with the given passphrase and reconnection policy.

## -parameters
### -param availableNetwork
Describes the Wi-Fi network to connect to.

### -param reconnectionKind
Describes how to reconnect to the network if connection is lost.

### -param passwordCredential
Password or other credential to use to connect to the network.

### -param ssid
When the network SSID is hidden, use this parameter to provide the SSID.

## -returns
An asynchronous connect operation. On successful conclusion of the operation, returns an object that describes the result of the connect operation.

## -remarks

## -examples

## -see-also
[ConnectAsync(WiFiAvailableNetwork, WiFiReconnectionKind)](wifiadapter_connectasync_1064651212.md), [ConnectAsync(WiFiAvailableNetwork, WiFiReconnectionKind, PasswordCredential)](wifiadapter_connectasync_1490922496.md)