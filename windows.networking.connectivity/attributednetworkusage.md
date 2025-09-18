---
- api-id: T:Windows.Networking.Connectivity.AttributedNetworkUsage
- api-type: winrt class
- api-device-family-note: xbox
---

<!-- Class syntax.
public class AttributedNetworkUsage : Windows.Networking.Connectivity.IAttributedNetworkUsage
-->

# Windows.Networking.Connectivity.AttributedNetworkUsage

## -description
Provides access to property values containing information on current usage of the attributed network connection.

## -remarks
Instances are produced by calling [ConnectionProfile](connectionprofile.md).[GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md) for a specified time window.

Usage considerations:

* Identity: AttributionId may map to an app, a system bucket, or an aggregated service bucket.
* Coverage: Some buckets can show only sent or only received bytes; zero values are valid.
* Accounting: Values are aggregated for the requested window and reflect provider accounting latency (not real‑time counters).
* Lifetime: Re‑query when you need fresh usage instead of holding instances long term.
* Absence: Missing an expected identifier for a window means no recorded usage in that interval, not necessarily uninstall.

## -examples

## -see-also
[ConnectionProfile](connectionprofile.md), [GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md)
