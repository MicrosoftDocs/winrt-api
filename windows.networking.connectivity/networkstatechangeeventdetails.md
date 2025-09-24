---
-api-id: T:Windows.Networking.Connectivity.NetworkStateChangeEventDetails
-api-type: winrt class
---

<!-- Class syntax.
public class NetworkStateChangeEventDetails : Windows.Networking.Connectivity.INetworkStateChangeEventDetails, Windows.Networking.Connectivity.INetworkStateChangeEventDetails2
-->

# Windows.Networking.Connectivity.NetworkStateChangeEventDetails

## -description
Indicates which network-related properties changed for the current status change event so handlers can perform targeted (not full) refresh logic.

## -remarks
### Retrieval
Obtained inside a [NetworkInformation.NetworkStatusChanged](networkinformation_networkstatuschanged.md) handler (or related background trigger). The instance is system-supplied; apps do not construct it.

> [!IMPORTANT]  
> Use the flags to decide what to refresh, then re-query current values (e.g., call
> [NetworkInformation.GetInternetConnectionProfile](networkinformation_getinternetconnectionprofile_255647281.md)). Do not rely on cached objects.

### Change indicator flags
Each Boolean property signals that the associated data MAY have changed; re-query only those areas.

| Property | Indicates possible change in |
| -- | -- |
| [HasNewInternetConnectionProfile](networkstatechangeeventdetails_hasnewinternetconnectionprofile.md) | Active Internet connection profile |
| [HasNewNetworkConnectivityLevel](networkstatechangeeventdetails_hasnewnetworkconnectivitylevel.md) | Connectivity level (None / Local / Constrained / Internet) |
| [HasNewConnectionCost](networkstatechangeeventdetails_hasnewconnectioncost.md) | Cost / metering / roaming state |
| [HasNewDomainConnectivityLevel](networkstatechangeeventdetails_hasnewdomainconnectivitylevel.md) | Enterprise domain authentication status |
| [HasNewHostNameList](networkstatechangeeventdetails_hasnewhostnamelist.md) | Host name list (DNS / local names) |
| [HasNewWwanRegistrationState](networkstatechangeeventdetails_hasnewwwanregistrationstate.md) | Cellular (WWAN) registration state |
| [HasNewTetheringOperationalState](networkstatechangeeventdetails_hasnewtetheringoperationalstate.md) | Mobile hotspot (tethering) operational state |
| [HasNewTetheringClientCount](networkstatechangeeventdetails_hasnewtetheringclientcount.md) | Connected tethering client count |

### Usage pattern
1. Event fires.
2. Inspect flags; build a minimal refresh plan.
3. Re-query only needed APIs (e.g., cost, connectivity level, domain auth).
4. Update UI / policy accordingly.
5. Defer heavyweight work (e.g., usage statistics) unless a relevant flag changed.

### Best practices
- Coalesce bursts: if multiple events arrive quickly, debounce UI updates.
- Avoid full refresh on every event; scale work to flags set.
- Treat flags as hints—not guarantees; always trust fresh API return values.
- When `HasNewNetworkConnectivityLevel` is true, re-validate gating features (online sync, telemetry, streaming).
- When cost changed, reassess background transfer strategy.
- When domain connectivity changed, re-check enterprise feature enablement.

### Tethering specifics
Use tethering flags only in scenarios that surface hotspot status or manage tethered client features; ignore them otherwise to keep handlers lean.

### Performance
Flag-driven conditional logic minimizes CPU, battery, and network usage compared to unconditional re-enumeration.

> [!NOTE]  
> Lack of a flag does not promise stability forever—another event will fire when a future change occurs.


## -examples

### Efficient event handling

Use the specific change indicators to minimize unnecessary work in event handlers:

```csharp
private void OnNetworkStatusChanged(object sender)
{
    // Get current network information
    var internetProfile = NetworkInformation.GetInternetConnectionProfile();
    
    // Only check cost information if it might have changed
    if (eventDetails.HasNewConnectionCost && internetProfile != null)
    {
        var cost = internetProfile.GetConnectionCost();
        UpdateCostUI(cost);
    }
    
    // Only update connectivity UI if connectivity level changed
    if (eventDetails.HasNewNetworkConnectivityLevel)
    {
        var connectivityLevel = internetProfile?.GetNetworkConnectivityLevel();
        UpdateConnectivityUI(connectivityLevel);
    }
}
```

## -see-also
[ConnectionCost](connectioncost.md),
[ConnectionProfile](connectionprofile.md),
[NetworkConnectivity sample](https://github.com/Microsoft/Windows-universal-samples/tree/main/Samples/NetworkConnectivity),
[NetworkConnectivityLevel](networkconnectivitylevel.md),
[NetworkInformation](networkinformation.md),
[NetworkInformation.NetworkStatusChanged](networkinformation_networkstatuschanged.md)
