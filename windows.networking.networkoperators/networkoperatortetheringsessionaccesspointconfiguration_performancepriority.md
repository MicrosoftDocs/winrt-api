---
-api-id: P:Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration.PerformancePriority
-api-type: winrt property
---

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration.PerformancePriority

<!--
public Windows.Networking.NetworkOperators.TetheringWiFiPerformancePriority PerformancePriority { get; set; }
-->


## -description

Gets or sets the performance priority value to be used for the Wi-Fi tethering connection when the main internet connection is also over Wi-Fi. If the station connection is on a frequency band that interferes with the requested tethering frequency band, then the Wi-Fi chipset will attempt to change the connection's frequency band to another one that won't interfere.

Many Wi-Fi chipsets have a limitation where if the main connection is over a 5 GHz band, then the tethering hotspot can't be configured to use a 6 GHz band. Prioritizing the tethering connection ([TetheringOverStation](./tetheringwifiperformancepriority.md)) will tell the Wi-Fi chipset to attempt to change the main connection over to a 2.4 GHz band, so that there'll no longer be interference with the requested 6 GHz band for the tethering hotspot.

If the frequency band shift isn't possible or allowed by specifying a different performance priority value, then calling [StartTetheringAsync](./networkoperatortetheringmanager_starttetheringasync_1060696031.md) will fail with an appropriate result status (BandInterference).

## -property-value

The enumeration value that specifies how the Wi-Fi chipset should prioritize performance between the tethering hotspot and the station connection.

## -remarks

## -see-also

## -examples

## -capabilities
wiFiControl
