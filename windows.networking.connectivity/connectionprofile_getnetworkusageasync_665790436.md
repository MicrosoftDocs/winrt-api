---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.GetNetworkUsageAsync(Windows.Foundation.DateTime,Windows.Foundation.DateTime,Windows.Networking.Connectivity.DataUsageGranularity,Windows.Networking.Connectivity.NetworkUsageStates)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.Connectivity.NetworkUsage>> GetNetworkUsageAsync(Windows.Foundation.DateTime startTime, Windows.Foundation.DateTime endTime, Windows.Networking.Connectivity.DataUsageGranularity granularity, Windows.Networking.Connectivity.NetworkUsageStates states)
-->

# Windows.Networking.Connectivity.ConnectionProfile.GetNetworkUsageAsync

## -description
Retrieves per-interval usage (bytes sent/received and connected duration) for this profile over a specified time
window using the requested [DataUsageGranularity](datausagegranularity.md) and optional
[NetworkUsageStates](networkusagestates.md) filters.

## -parameters

### -param startTime
The start time over which to retrieve data. Can be no more than 60 days prior to the current time. If the specified
*granularity* is PerMinute, then the start time can be no more than 120 minutes prior to the current time.

### -param endTime
The end time over which to retrieve data.
This time must be later than the startTime.

### -param granularity
The desired granularity of the returned usage statistics. Each elements in the list corresponds to the network usage
per the specified granularity; for example, usage per hour.

### -param states
The state of the connection profile for which usage data should be returned.

## -returns
An ordered list (chronological) of [NetworkUsage](networkusage.md) entries. Each entry contains bytes sent, bytes
received, and connected duration for its interval. If the span is not an exact multiple of the granularity the final
entry is partial and ends at endTime.

## -remarks
This method returns aggregate network usage data for the connection profile over the specified time window.

### Usage API best practices

#### Time window management
* Align startTime and endTime to the granularity boundary (for PerMinute, round down the start to the previous minute) to avoid extra leading or trailing partial buckets.
* An empty vector is a valid result (no recorded usage or provider unavailable) - treat as "no data" rather than an error and retry in the next collection cycle.
* Avoid querying very large spans at fine granularity (e.g., multiple days with PerMinute). Aggregate in your own code if you need rolled-up statistics.

#### State filtering
* [NetworkUsageStates](networkusagestates.md) roaming and shared properties should only be constrained when necessary; leaving them unconstrained yields a complete view.
* Over-restricting state filters can hide legitimate usage data.

#### Data accuracy
* This API returns estimated usage, not real-time byte counts; provider accounting can lag actual traffic. For near-real-time display, advance a sliding window but accept that the most recent bucket may later increase when re-queried.
* Periodically re-query recent closed buckets to capture late provider adjustments.

#### Incremental collection
> [!NOTE]
> To avoid double counting when doing periodic collection, use a cursor of the last fully closed bucket boundary rather than reusing prior `endTime` values.

* Maintain a cursor aligned to the usage granularity and only commit fully closed buckets.
* Skip provisional/partial buckets that are still accumulating data.

#### Incremental collection pattern

1. Choose a granularity (e.g., PerHour). Compute an aligned initial `startTime` (floor to the granularity boundary) and `endTime = startTime + granularity`.
2. Query usage. Discard the last element if its interval end is after (now - granularity) because it's still accumulating.
3. Persist the boundary (end of the last fully closed bucket) as the new `startTime` for the next run.
4. On the next invocation, set `endTime = now` (or `startTime + N*granularity` if batching) and repeat, summing only newly closed buckets.
5. Periodically (e.g., daily) re-query the recent past (one or two buckets) to reconcile late adjustments.

This pattern minimizes overlap and handles late provider adjustments without double counting.

## -examples
### Sliding window (hourly) collection (C#)

```csharp
using System;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;

private DateTimeOffset? _usageCursor;

private async Task CollectHourlyUsageAsync()
{
    var profile = NetworkInformation.GetInternetConnectionProfile();
    if (profile == null)
    {
        // App-specific: no active profile. Reschedule collection and exit.
        return;
    }

    var now = DateTimeOffset.UtcNow;

    // Seed cursor to 24 hours ago (aligned) if no persisted value exists yet.
    var cursor = AlignToHour(_usageCursor ?? now.AddHours(-24));

    var usage = await profile.GetNetworkUsageAsync(cursor, now, DataUsageGranularity.PerHour, new NetworkUsageStates());

    long committedRcv = 0;
    long committedSend = 0;

    foreach (var entry in usage)
    {
        var intervalStart = cursor;
        var intervalEnd = intervalStart.AddHours(1);

        // Skip provisional bucket that may still change on provider reconciliation.
        if (intervalEnd > now.AddHours(-1))
        {
            break;
        }

        committedRcv += (long)entry.BytesReceived;
        committedSend += (long)entry.BytesSent;
        cursor = intervalEnd;
    }

    _usageCursor = cursor;

    // App-specific: persist committed totals and the updated cursor to durable storage for next collection.
    // Example: usageRepository.Save(committedRcv, committedSend, cursor);
}

private static DateTimeOffset AlignToHour(DateTimeOffset timestamp)
{
    return new DateTimeOffset(timestamp.Year, timestamp.Month, timestamp.Day, timestamp.Hour, 0, 0, timestamp.Offset);
}
```

Key points:
* Avoids double counting by only committing fully closed buckets.
* Allows late adjustments: next run can still pick up changes in the most recent closed hour if you re-query a small overlap (optional reconciliation step).
* Demonstrates aligning start boundary and skipping the partial trailing bucket.

## -see-also

