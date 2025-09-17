---
-api-id: T:Windows.Networking.Connectivity.NetworkCostType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Connectivity.NetworkCostType : int
-->

# NetworkCostType

## -description
Defines the network cost types.

## -enum-fields
### -field Unknown:0
Cost information is not available.

### -field Unrestricted:1
The connection is unlimited and has unrestricted usage charges and capacity constraints.

### -field Fixed:2
The use of this connection is unrestricted up to a specific limit.

### -field Variable:3
The connection is costed on a per-byte basis.


## -remarks
Use `NetworkCostType` together with `ConnectionCost` boolean flags (`Roaming`, `OverDataLimit`, `ApproachingDataLimit`, `BackgroundDataUsageRestricted`) to decide whether to:

* Delay or throttle large background transfers (`Fixed` or `Variable`).
* Provide UI to the user before streaming HD media when not `Unrestricted`.
* Automatically pause sync if `OverDataLimit`.

Decision example (C#):

```csharp
var profile = NetworkInformation.GetInternetConnectionProfile();
var cost = profile?.GetConnectionCost();
bool allowLargeTransfer = false;
if (cost != null)
{
	allowLargeTransfer = cost.NetworkCostType == NetworkCostType.Unrestricted && !cost.Roaming && !cost.OverDataLimit;
}
```

Classic desktop components might query NLM / DUSM directly, but WinRT apps should rely on these abstractions. For samples that illustrate reacting to cost changes, see the Network Cost (DUSM) classic sample and the UWP connectivity sample.

For additional scenario guidance, see [Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10)).

## -examples

## -see-also
[Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10))
