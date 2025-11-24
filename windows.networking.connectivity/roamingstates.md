---
-api-id: T:Windows.Networking.Connectivity.RoamingStates
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Connectivity.RoamingStates : uint
-->

# RoamingStates

## -description
Defines the roaming states.

## -enum-fields
### -field None:0
No roaming information.

### -field NotRoaming:1
The connection is not currently roaming.

### -field Roaming:2
The connection is currently roaming.

## -remarks
`RoamingStates` values appear on [ConnectionCost.Roaming](connectioncost_roaming.md). The flag indicates whether the
current connection is incurring roaming fees. Treat `Roaming` as a warning signal rather than an automatic off switch; a
user might consciously continue foreground work even when roaming.

Apps should pair the roaming state with [NetworkCostType](networkcosttype.md) and the various
[ConnectionCost](connectioncost.md) limit indicators to decide how aggressively to sync data.



## -examples
Skip non-essential background sync while roaming (C#):

```csharp
using Windows.Networking.Connectivity;

var profile = NetworkInformation.GetInternetConnectionProfile();
var cost = profile?.GetConnectionCost();
if (cost?.Roaming == true)
{
    // App-specific: defer scheduled uploads or prompt the user.
}
```

## -see-also

