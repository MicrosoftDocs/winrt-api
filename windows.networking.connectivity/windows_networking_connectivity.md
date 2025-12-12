---
-api-id: N:Windows.Networking.Connectivity
-api-type: winrt namespace
---

# Windows.Networking.Connectivity

## -description

Retrieves connection profiles that provide connectivity, usage, and data plan information for established network connections. This data can be used by a connected application to take appropriate action when operating in challenging network scenarios or abiding by data plan limits set by a network provider.

## -remarks

Use this namespace to assess connectivity across WLAN, WWAN, and Ethernet interfaces, read cost and data plan metadata,
and react to network state changes. Key entry points include:

- [NetworkInformation](networkinformation.md) for discovering active and historical connection profiles and subscribing to status changes.
- [ConnectionProfile](connectionprofile.md) for inspecting cost, adapter, and plan details on a specific interface.
- [ConnectionCost](connectioncost.md) and [DataPlanStatus](dataplanstatus.md) for making cost-aware decisions before transferring data.

## -examples

## -see-also

[NetworkConnectivity sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/NetworkConnectivity),
[NetworkCostType](networkcosttype.md)
