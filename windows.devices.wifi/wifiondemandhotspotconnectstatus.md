---
-api-id: T:Windows.Devices.WiFi.WiFiOnDemandHotspotConnectStatus
-api-type: winrt enum
---

# Windows.Devices.WiFi.WiFiOnDemandHotspotConnectStatus

<!--
public enum WiFiOnDemandHotspotConnectStatus
-->


## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).


Defines constants that specify the status of a connection to a hotspot network.

> [!NOTE]
> If you want to use this API in a UWP app, and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.onDemandHotspotControl_8wekyb3d8bbwe** (the On-Demand Network capability). For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).
>
> The On-Demand Network capability will be made available only to app developers building end-to-end Wi-Fi hotspot scenarios between a tethering-capable hardware device and a Windows PC.

## -enum-fields

### -field UnspecifiedFailure: 0

Specifies that the connection failed in an unspecified way.

### -field Success: 1

Specifies that the connection succeeded.

### -field AppTimedOut: 2

Specifies that the connection timed out.

### -field InvalidCredential: 3

Specifies that the connection failed due to invalid credentials.

### -field NetworkNotAvailable: 4

Specifies that the connection failed due to the network not being available.

### -field UnsupportedAuthenticationProtocol: 5

Specifies that the connection failed due to the authentication protocol not being supported.

### -field BluetoothConnectFailed: 6

Specifies that the connection failed due to a Bluetooth connection failure.

### -field BluetoothTransmissionError: 7

Specifies that the connection failed due to a Bluetooth transmission error.

### -field OperationCanceledByUser: 8

Specifies that the connection failed because the user canceled it.

### -field EntitlementCheckFailed: 9

Specifies that the connection failed because the cellular customer isn't allowed to use the tethering feature based on their entitlement.

### -field NoCellularSignal: 10

Specifies that the connection failed due to no cellular signal.

### -field CellularDataTurnedOff: 11

Specifies that the connection failed due to cellular data being turned off.

### -field WlanConnectFailed: 12

Specifies that the connection failed due to a wireless local-area network (WLAN) failure.

### -field WlanNotVisible: 13

Specifies that the connection failed due to the wireless local-area network (WLAN) not being visible. The PC couldn't see the SSID specified by the [WiFiOnDemandHotspotNetworkProperties.Ssid](wifiondemandhotspotnetworkproperties_ssid.md) property.

### -field AccessPointCannotConnect: 14

Specifies that the connection failed for not being able to connect to the access point.

### -field CellularConnectTimedOut: 15

Specifies that the connection failed due to a cellular connection timeout.

### -field RoamingNotAllowed: 16

Specifies that the connection failed because roaming isn't allowed.

### -field PairingRequired: 17

Specifies that the connection failed because pairing is required.

### -field DataLimitReached: 18

Specifies that the connection failed due to the data limit being reached.

## -remarks

## -see-also

## -examples

## -capabilities
onDemandHotspotControl
