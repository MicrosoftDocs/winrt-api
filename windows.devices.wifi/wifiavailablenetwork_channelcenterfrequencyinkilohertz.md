---
-api-id: P:Windows.Devices.WiFi.WiFiAvailableNetwork.ChannelCenterFrequencyInKilohertz
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public int ChannelCenterFrequencyInKilohertz { get; }
-->

# Windows.Devices.WiFi.WiFiAvailableNetwork.ChannelCenterFrequencyInKilohertz

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Gets the channel center frequency of the band on which the 802.11 Beacon or Probe Response was received.

## -property-value
The channel center frequency of the band on which the 802.11 Beacon or Probe Response frame was received. The value of this property is in units of kilohertz (kHz). Note that this member is only valid for PHY types that are not frequency-hopping spread spectrum (FHSS). In all other cases the value returned is zero.

## -remarks

## -examples

## -see-also
