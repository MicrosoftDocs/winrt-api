---
-api-id: M:Windows.Devices.WiFi.WiFiAdapter.ConnectAsync(Windows.Devices.WiFi.WiFiAvailableNetwork,Windows.Devices.WiFi.WiFiReconnectionKind,Windows.Security.Credentials.PasswordCredential)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.WiFi.WiFiConnectionResult> ConnectAsync(Windows.Devices.WiFi.WiFiAvailableNetwork availableNetwork, Windows.Devices.WiFi.WiFiReconnectionKind reconnectionKind, Windows.Security.Credentials.PasswordCredential passwordCredential)
-->

# Windows.Devices.WiFi.WiFiAdapter.ConnectAsync

## -description
Connect this Wi-Fi device to the specified network, with the specified passphrase and reconnection policy.

## -parameters
### -param availableNetwork
Specifies the Wi-Fi network to connect to.

### -param reconnectionKind
Describes how to reconnect to the network if connection is lost.

### -param passwordCredential
The passphrase to be used to connect to the access point.

## -returns
An asynchronous connect operation. On successful conclusion of the operation, returns an object that describes the result of the connect operation.

## -remarks

## -examples

## -see-also
[ConnectAsync(WiFiAvailableNetwork, WiFiReconnectionKind)](wifiadapter_connectasync_1064651212.md), [ConnectAsync(WiFiAvailableNetwork, WiFiReconnectionKind, PasswordCredential, String)](wifiadapter_connectasync_1798151424.md)