---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.GetNetworkUsageAsync(Windows.Foundation.DateTime,Windows.Foundation.DateTime,Windows.Networking.Connectivity.DataUsageGranularity,Windows.Networking.Connectivity.NetworkUsageStates)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Networking.Connectivity.NetworkUsage>> GetNetworkUsageAsync(Windows.Foundation.DateTime startTime, Windows.Foundation.DateTime endTime, Windows.Networking.Connectivity.DataUsageGranularity granularity, Windows.Networking.Connectivity.NetworkUsageStates states)
-->

# Windows.Networking.Connectivity.ConnectionProfile.GetNetworkUsageAsync

## -description
Gets a list of the estimated data traffic and connection duration over a specified period of time, for a specific
network usage state.

[DataUsageGranularity](datausagegranularity.md) is used to indicate the desired granularity of the returned data and
affects the length of the returned list. [NetworkUsageStates](networkusagestates.md) is used to indicate the desired
network usage configuration.

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
When the method completes, it returns a list of [NetworkUsage](networkusage.md) objects, which indicate the sent and
received values, in bytes, and the total amount of time the profile was connected during the corresponding time
interval. The entries are in chronological order, starting at the startTime. If the time span is not an exact multiple
of the granularity, then the last entry will report usage only up to the endTime.

## -remarks
This method returns aggregate network usage data for the connection profile over the specified time window.

### Usage API Best Practices

**Time Window Management:**
* Align startTime and endTime to the granularity boundary (for PerMinute, round down the start to the previous minute) to avoid extra leading or trailing partial buckets.
* An empty vector is a valid result (no recorded usage or provider unavailable) - treat as "no data" rather than an error and retry in the next collection cycle.
* Avoid querying very large spans at fine granularity (e.g., multiple days with PerMinute). Aggregate in your own code if you need rolled-up statistics.

**State Filtering:**
* NetworkUsageStates roaming and shared properties should only be constrained when necessary; leaving them unconstrained yields a complete view.
* Over-restricting state filters can hide legitimate usage data.

**Data Accuracy:**
* This API returns estimated usage, not real-time byte counts; provider accounting can lag actual traffic. For near-real-time display, advance a sliding window but accept that the most recent bucket may later increase when re-queried.
* Periodically re-query recent closed buckets to capture late provider adjustments.

**Incremental Collection:**
* To avoid double counting when doing periodic collection, use a cursor of the last fully closed bucket boundary rather than reusing prior `endTime` values.
* Maintain a cursor aligned to the usage granularity and only commit fully closed buckets.
* Skip provisional/partial buckets that are still accumulating data.

**Incremental Collection Pattern:**

1. Choose a granularity (e.g., PerHour). Compute an aligned initial `startTime` (floor to the granularity boundary) and `endTime = startTime + granularity`.
2. Query usage. Discard the last element if its interval end is after (now - granularity) because it's still accumulating.
3. Persist the boundary (end of the last fully closed bucket) as the new `startTime` for the next run.
4. On the next invocation, set `endTime = now` (or `startTime + N*granularity` if batching) and repeat, summing only newly closed buckets.
5. Periodically (e.g., daily) re-query the recent past (one or two buckets) to reconcile late adjustments.

This pattern minimizes overlap and handles late provider adjustments without double counting.

Reference: [How to retrieve connection usage data for a specific period of time](/previous-versions/windows/apps/hh465162(v=win.10)).

## -examples
### Sliding window (hourly) collection (C#)

```csharp
// Maintains a cursor to avoid overlapping queries.
DateTimeOffset now = DateTimeOffset.UtcNow;
// Load persisted cursor; if none, seed to (now - 24h) aligned to hour.
DateTimeOffset cursor = LoadCursor() ?? new DateTimeOffset(
    now.UtcDateTime.AddHours(-24)).AddMinutes(-(now.Minute)).AddSeconds(-now.Second).AddMilliseconds(-now.Millisecond);

// Always align cursor to the hour boundary.
cursor = new DateTimeOffset(cursor.Year, cursor.Month, cursor.Day, cursor.Hour, 0, 0, TimeSpan.Zero);

// Query up to now; API will return partial last hour which we will treat as provisional.
var usage = await profile.GetNetworkUsageAsync(cursor, now, DataUsageGranularity.PerHour, new NetworkUsageStates());

long bytesReceivedCommitted = 0;
long bytesSentCommitted = 0;

foreach (var entry in usage)
{
    // Determine the interval represented by this entry.
    DateTimeOffset intervalStart = cursor;
    DateTimeOffset intervalEnd = intervalStart.AddHours(1);

    // If intervalEnd extends past (now - 1 hour) this bucket is still "open" and subject to change.
    if (intervalEnd > now.AddHours(-1))
    {
        break; // Skip provisional bucket; will be included on a future run.
    }

    bytesReceivedCommitted += (long)entry.BytesReceived;
    bytesSentCommitted += (long)entry.BytesSent;
    cursor = intervalEnd; // advance cursor
}

PersistCursor(cursor);
Console.WriteLine($"Committed usage since last run: Rcv={bytesReceivedCommitted}B Sent={bytesSentCommitted}B");
```

Key points:
* Avoids double counting by only committing fully closed buckets.
* Allows late adjustments: next run can still pick up changes in the most recent closed hour if you re-query a small overlap (optional reconciliation step).
* Demonstrates aligning start boundary and skipping the partial trailing bucket.

## -see-also
[DataUsageGranularity](datausagegranularity.md), [NetworkUsage](networkusage.md), [NetworkUsageStates](networkusagestates.md)
