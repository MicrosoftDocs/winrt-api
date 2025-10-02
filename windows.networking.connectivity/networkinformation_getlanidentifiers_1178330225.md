---
-api-id: M:Windows.Networking.Connectivity.NetworkInformation.GetLanIdentifiers
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Networking.Connectivity.LanIdentifier> GetLanIdentifiers()
-->

# Windows.Networking.Connectivity.NetworkInformation.GetLanIdentifiers

## -description

> [!IMPORTANT]
> Location consent is now required for Wi-Fi BSSID access. For details on how this affects apps using Wi-Fi or location APIs,
> see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Gets an array of [LanIdentifier](lanidentifier.md) objects that contain locality information for each [NetworkAdapter](networkadapter.md) object that currently connected to a network.

## -returns
An array of `LanIdentifier` objects.

## -remarks
Use this method when you need link layer metadata, such as wired chassis and port identifiers or Wi-Fi BSSID values, to
correlate connectivity with diagnostics or enterprise provisioning tasks. Access the returned `LanIdentifier` instances
to inspect [LanIdentifier.InfrastructureId](lanidentifier_infrastructureid.md), [LanIdentifier.PortId](lanidentifier_portid.md), and
[LanIdentifier.NetworkAdapterId](lanidentifier_networkadapterid.md).

## -examples
Retrieve LAN identifiers (C#):

```csharp
using Windows.Networking.Connectivity;

var identifiers = NetworkInformation.GetLanIdentifiers();
foreach (var id in identifiers)
{
    // App-specific: map id.InfrastructureId and id.PortId to network diagnostics logs.
}
```

## -see-also

