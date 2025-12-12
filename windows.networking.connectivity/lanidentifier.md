---
-api-id: T:Windows.Networking.Connectivity.LanIdentifier
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class LanIdentifier : Windows.Networking.Connectivity.ILanIdentifier
-->

# Windows.Networking.Connectivity.LanIdentifier

## -description
Represents physical identification data for a specific [NetworkAdapter](networkadapter.md) object. Retrieve
`LanIdentifier` instances through [NetworkInformation.GetLanIdentifiers](networkinformation_getlanidentifiers_1178330225.md).


## -remarks
Location data is expressed either as a BSSID if the network adapter media type is Wireless LAN, or as a tuple &lt;ChassisId, Port Number&gt; if the network adapter type is Ethernet. The data is represented according to the LLDP protocol.

## -examples
Enumerate LAN identifiers (C#):

```csharp
using Windows.Networking.Connectivity;

var identifiers = NetworkInformation.GetLanIdentifiers();
foreach (var id in identifiers)
{
    var infra = id.InfrastructureId;
    var port = id.PortId;
    var type = id.NetworkAdapterId;
    // App-specific: correlate infra/port values with diagnostics telemetry.
}
```

## -see-also

[LanIdentifierData](lanidentifierdata.md)
