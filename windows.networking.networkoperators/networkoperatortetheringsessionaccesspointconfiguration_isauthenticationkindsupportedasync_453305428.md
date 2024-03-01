---
-api-id: M:Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration.IsAuthenticationKindSupportedAsync(Windows.Networking.NetworkOperators.TetheringWiFiAuthenticationKind)
-api-type: winrt method
---

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration.IsAuthenticationKindSupportedAsync(Windows.Networking.NetworkOperators.TetheringWiFiAuthenticationKind)

<!--
public Windows.Foundation.IAsyncOperation<bool> IsAuthenticationKindSupportedAsync (Windows.Networking.NetworkOperators.TetheringWiFiAuthenticationKind authenticationKind);
-->


## -description

Asynchronously gets a value indicating whether the Wi-Fi adapter allows configuring the tethering hotspot with a specific authentication kind. Similar to [NetworkOperatorTetheringAccessPointConfiguration.IsAuthenticationKindSupportedAsync](./networkoperatortetheringaccesspointconfiguration_isauthenticationkindsupportedasync_453305428.md).

## -parameters

### -param authenticationKind

Specifies the authentication kind to query for.

## -returns

An asynchronous operation object which, when it completes, contains the value `true` if the authentication kind is supported; otherwise, `false`.

## -remarks

## -see-also

## -examples

## -capabilities
wiFiControl
