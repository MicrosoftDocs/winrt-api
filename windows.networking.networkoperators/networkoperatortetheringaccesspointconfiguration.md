---
-api-id: T:Windows.Networking.NetworkOperators.NetworkOperatorTetheringAccessPointConfiguration
-api-type: winrt class
---

<!-- Class syntax.
public class NetworkOperatorTetheringAccessPointConfiguration : Windows.Networking.NetworkOperators.INetworkOperatorTetheringAccessPointConfiguration
-->

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringAccessPointConfiguration

## -description
Provides the ability to configure and create an object that contains a specific tethering network SSID, and specifies the passphrase used to authenticate clients trying to establish a network connection to the tethering network.

Tethering allows a Windows device to function as a mobile hotspot providing internet connections over Wi-Fi or Bluetooth. Properties can be configured on the Wi-Fi access point such as the network SSID, the password, and the wireless frequency band.

## -remarks
Windows 10, version 1607, supports Mobile Hotspot, an enhanced version of the mobile broadband tethering feature. The Mobile Hotspot and Wi-Fi Direct technology can't both run at the same time. Mobile Hotspot takes precedence over all Wi-Fi Direct scenarios. For example, screen projection and tethering can't both run at the same time.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 2004 | 19041 | Band |
| 2004 | 19041 | IsBandSupported |
| 2004 | 19041 | IsBandSupportedAsync |

## -examples

## -see-also

## -capabilities
wiFiControl
