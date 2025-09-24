---
-api-id: P:Windows.Networking.Connectivity.NetworkStateChangeEventDetails.HasNewTetheringClientCount
-api-type: winrt property
---

<!-- Property syntax
public bool HasNewTetheringClientCount { get; }
-->

# Windows.Networking.Connectivity.NetworkStateChangeEventDetails.HasNewTetheringClientCount

## -description
Indicates whether the tethering (mobile hotspot) client count may have changed for the current network status change event.

## -property-value
True if the tethering client count may have changed; otherwise false. Treat true as a hint to re-query the authoritative tethering / hotspot API for the current count.

## -remarks
### Usage
Check inside a [NetworkInformation.NetworkStatusChanged](networkinformation_networkstatuschanged.md) handler (after retrieving
[NetworkStateChangeEventDetails](networkstatechangeeventdetails.md)) to decide whether to refresh displayed hotspot / tethering
client counts.

### Guidance
- Hint semantics: A true value signals you SHOULD re-query; it does not embed the new count.
- Debounce: Avoid tight polling—rely on the event. Short propagation delays between attach/detach and this flag are expected.
- Disabled scenarios: If policy disables tethering mid-session you may not receive further client count change flags; handle a
  disabled / zero-client state defensively.
- Reconciliation: Keep a cached last-known count. If the refreshed count equals the cache, treat as benign duplicate.

### Pattern
1. Cache initial count during feature initialization (if feature needed).
2. On status change:
   - If `HasNewTetheringClientCount` true, query current count.
   - If changed, update UI / telemetry.
3. (Optional) Periodic slow cadence verification to cover rare missed events.

> [!NOTE]  
> Pair with [HasNewTetheringOperationalState](networkstatechangeeventdetails_hasnewtetheringoperationalstate.md) to determine
> whether tethering remains active before surfacing client count changes.


## -examples
### Example: Reacting to tethering client count changes (C#)
```csharp
NetworkInformation.NetworkStatusChanged += async (s) =>
{
    var evt = NetworkInformation.GetNetworkStateChangeEventDetails();
    if (evt?.HasNewTetheringClientCount == true)
    {
        int newCount = await TetheringHelper.GetCurrentClientCountAsync(); // app-specific helper
        if (newCount != _cachedCount)
        {
            _cachedCount = newCount;
            UpdateClientCountDisplay(newCount);
        }
    }
};
```

## -see-also
[NetworkStateChangeEventDetails](networkstatechangeeventdetails.md),  
[NetworkStateChangeEventDetails.HasNewTetheringOperationalState](networkstatechangeeventdetails_hasnewtetheringoperationalstate.md),  
[NetworkInformation.NetworkStatusChanged](networkinformation_networkstatuschanged.md)
