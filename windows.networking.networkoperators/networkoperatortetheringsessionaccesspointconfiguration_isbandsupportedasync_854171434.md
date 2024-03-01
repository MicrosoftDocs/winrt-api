---
-api-id: M:Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration.IsBandSupportedAsync(Windows.Networking.NetworkOperators.TetheringWiFiBand)
-api-type: winrt method
---

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration.IsBandSupportedAsync(Windows.Networking.NetworkOperators.TetheringWiFiBand)

<!--
public Windows.Foundation.IAsyncOperation<bool> IsBandSupportedAsync (Windows.Networking.NetworkOperators.TetheringWiFiBand band);
-->


## -description

Asynchronously gets a value indicating whether the Wi-Fi adapter allows configuring the tethering hotspot with a specific frequency band. Similar to [NetworkOperatorTetheringAccessPointConfiguration.IsBandSupportedAsync](./networkoperatortetheringaccesspointconfiguration_isbandsupportedasync_854171434.md).

## -parameters

### -param band

Specifies the frequency band to query for.

## -returns

An asynchronous operation object which, when it completes, contains the value `true` if the frequency band is supported; otherwise, `false`.

## -remarks

## -see-also

## -examples

## -capabilities
wiFiControl
