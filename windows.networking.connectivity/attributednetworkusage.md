---
-api-id: T:Windows.Networking.Connectivity.AttributedNetworkUsage
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class AttributedNetworkUsage : Windows.Networking.Connectivity.IAttributedNetworkUsage
-->

# Windows.Networking.Connectivity.AttributedNetworkUsage

## -description
Provides access to property values containing information on current usage of the attributed network connection.

## -remarks
Instances are produced by calling `ConnectionProfile.GetAttributedNetworkUsageAsync` for a specified time window.

Behavioral clarifications:

* `AttributionId` identifies the app or logical bucket; system / service traffic can appear under an aggregated identifier.
* Byte counts are aggregated over the interval used in the originating query and represent estimates (not real‑time counters).
* Some buckets may report only sent or only received traffic depending on activity; zero values are valid.
* Absence of an expected attribution ID in a given interval does not imply uninstall—only that no usage was recorded during that window.
* Do not cache instances long term; re‑query to reflect new usage.

## -examples

## -see-also
[ConnectionProfile](connectionprofile.md), [GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md)
