---
-api-id: T:Windows.Networking.Connectivity.NetworkUsage
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class NetworkUsage : Windows.Networking.Connectivity.INetworkUsage
-->

# Windows.Networking.Connectivity.NetworkUsage

## -description
Represents network usage statistics returned by the [ConnectionProfile](connectionprofile.md).[GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md) method.

## -remarks
Each `NetworkUsage` entry represents aggregated usage over a contiguous interval defined by the granularity supplied to `ConnectionProfile.GetNetworkUsageAsync`.

Behavioral notes:

* Entries are returned in chronological order.
* If the requested time span is not an exact multiple of the granularity, the final entry may represent a shorter, partial interval.
* Intervals with zero traffic may still appear (depending on provider data), but callers should not rely on explicitly receiving every possible quiet interval.
* Reported byte counts are estimates with accounting latency; they should not be used for real‑time throttling at sub‑minute precision.
* Always treat an empty result set from `GetNetworkUsageAsync` as “no data for that window” rather than a failure; the underlying provider may not have records yet.


## -examples

## -see-also
