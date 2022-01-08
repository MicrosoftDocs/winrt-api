---
-api-id: P:Windows.Networking.NetworkOperators.NetworkOperatorTetheringAccessPointConfiguration.Ssid
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string Ssid { get;  set; }
-->

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringAccessPointConfiguration.Ssid

## -description
Gets or sets the network account ID, in the form of a GUID.

A network account is one of the mobile operator accounts available on the device (configured when the user inserts a SIM). You can retrieve a list of the IDs of the network accounts available on a device by accessing the [MobileBroadbandAccount.AvailableNetworkAccountIds](/uwp/api/windows.networking.networkoperators.mobilebroadbandaccount.availablenetworkaccountids) property.

> [!NOTE]
> The SSID is encoded using the Microsoft code page for the system's default locale. This SSID may appear differently in the Windows network selection UI on a system that uses a different system locale. It is highly recommended that you set the value using characters from the standard ASCII printable character set to avoid any cross-locale inconsistencies.

## -property-value
The network account ID

## -remarks

## -examples

## -see-also

## -capabilities
wiFiControl
