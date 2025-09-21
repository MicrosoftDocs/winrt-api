---
-api-id: P:Windows.Networking.Connectivity.NetworkStateChangeEventDetails.HasNewTetheringClientCount
-api-type: winrt property
---

<!-- Property syntax
public bool HasNewTetheringClientCount { get; }
-->

# Windows.Networking.Connectivity.NetworkStateChangeEventDetails.HasNewTetheringClientCount

## -description
Gets a value indicating whether the network state change event shows a new tethering client count.

## -property-value
When true, the tethering client count has changed.

## -remarks
Use this flag inside a `NetworkInformation.NetworkStatusChanged` handler (after casting the event details) to decide
whether you need to refresh the tethering client list / count.

Guidance:

* Event selectivity: Not every underlying link or session change produces this flag; it is raised when the effective
    number of connected tethering clients is observed to differ from the previously reported value.
* Race avoidance: Treat the flag as a prompt to re-query the authoritative tethering manager / hotspot API rather than
    assuming you know the new count implicitly.
* Aggregation latency: Short delays can occur between a client attaching/detaching and the flag being surfaced. Avoid
    tight polling loops; rely on the event to minimize power/network scans.
* Policy / entitlement: If policy disables tethering between two client transitions, this flag might not appear again
    until tethering is re-enabled; code should handle a disabled feature even if the prior state reported active
    clients.
* Reconciliation: Maintain your own last committed count; if the flag is true but the re-queried count matches your
    cache, treat it as a benign transient and keep listening.

Typical pattern (pseudo):

1. On startup, query current client count and cache it.
2. On network status change, if `HasNewTetheringClientCount` is true, re-query count.
3. If different, update UI / accounting; if identical, ignore (possible transient duplicate trigger).
4. Periodically (optional) re-query on a long cadence (e.g., every few minutes) to cover rare missed events.

## -examples
### Example: Reacting to tethering client count changes (C#)
```csharp
NetworkInformation.NetworkStatusChanged += async (s) =>
{
    var details = NetworkInformation.GetNetworkStateChangeEventDetails();
    if (details?.HasNewTetheringClientCount == true)
    {
        // Re-query authoritative source (placeholder API call)
        int newCount = await TetheringHelper.GetCurrentClientCountAsync();
        if (newCount != _cachedCount)
        {
            _cachedCount = newCount;
            UpdateClientCountDisplay(newCount);
        }
    }
};
```

## -see-also
