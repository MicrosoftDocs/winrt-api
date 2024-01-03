---
-api-id: T:Windows.Networking.NetworkOperators.TetheringWiFiAuthenticationKind
-api-type: winrt enum
---

# Windows.Networking.NetworkOperators.TetheringWiFiAuthenticationKind

<!--
public enum TetheringWiFiAuthenticationKind
-->


## -description

Defines constants that specify the wireless authentication algorithm to be used for the Wi-Fi tethering connection.

## -enum-fields

### -field Wpa2: 0

Specifies that the Wi-Fi adapter should use only the WPA2 authentication kind. Supported by all current hardware.

### -field Wpa3TransitionMode: 1

Specifies that the Wi-Fi adapter should choose WPA3 if available; and otherwise will fall back to WPA2 for each individual client/peer connection. This is supported only on hardware that supports WPA3, and it's meant to allow WPA2 clients to also be able to connect to WPA3 hardware. Also known as WPA3 Transitional or WPA3 Transition Mode.

### -field Wpa3: 2

Specifies that the Wi-Fi adapter should use only the WPA3 authentication kind.

## -remarks

Older Wi-Fi adapters don't support WPA3. Call [Windows.Networking.NetworkOperators.NetworkOperatorTetheringAccessPointConfiguration.IsAuthenticationKindSupported]() to find out whether your adapter supports a specific authentication kind.

Use Wpa3TransitionMode to let the adapter automatically fall back to WPA2 if WPA3 is not supported.

## -see-also

## -examples

## -capabilities
wiFiControl
