---
-api-id: T:Windows.Networking.Connectivity.NetworkCostType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Connectivity.NetworkCostType : int
-->

# NetworkCostType

## -description
Defines values for cost limits on a network connection.

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
Use ConnectionProfile.GetConnectionCost to obtain the ConnectionCost object and inspect its properties
(NetworkCostType, Roaming, OverDataLimit, ApproachingDataLimit) before deciding how aggressively to transfer data.

Scenario guidance:

1. If NetworkCostType is Unrestricted you can perform full-fidelity sync operations. Still check Roaming to respect
    user metering preferences when on certain enterprise or roaming scenarios that may not strictly enforce cost.
2. If NetworkCostType is Fixed set conservative background transfer sizes and respect MaxTransferSizeInMegabytes if
    provided via the associated DataPlanStatus.
3. If NetworkCostType is Variable treat the connection similarly to a fixed cost near its limit: batch
    opportunistically and provide user controls to defer high-volume tasks.
4. Always gate large downloads on Roaming == false and OverDataLimit == false to avoid surprise charges.
5. For real-time streaming, adapt bitrate based on NetworkCostType and remaining quota (if available) rather than
    hard disabling features.

## -examples
Decision pseudo-logic:

```csharp
var cost = profile.GetConnectionCost();
if (cost.NetworkCostType == NetworkCostType.Unrestricted && !cost.Roaming)
{
    EnableHighBandwidthFeatures();
}
else
{
    EnterConservativeMode();
    if (cost.OverDataLimit || cost.Roaming)
    {
        SuspendBackgroundVideo();
    }
}
```

## -see-also
ConnectionProfile.GetConnectionCost, [ConnectionCost](connectioncost.md), [DataPlanStatus](dataplanstatus.md),
[Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10))
