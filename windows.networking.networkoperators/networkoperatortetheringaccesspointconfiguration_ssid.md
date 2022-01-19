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
Gets or sets the SSID to be used for the tethering network.

> [!NOTE]
> The SSID is encoded using the Microsoft code page for the system's default locale. This SSID may appear differently in the Windows network selection UI on a system that uses a different system locale. It is highly recommended that you set the value using characters from the standard ASCII printable character set to avoid any cross-locale inconsistencies.

## -property-value
A string containing the SSID to be used for the tethering network. An SSID is the name of the Wi-Fi network (as would be displayed in the list of nearby networks, for example). An SSID must be between 1 and 32 characters in length; and the first and last character may not be a space.

## -remarks

## -examples

## -see-also

## -capabilities
wiFiControl
