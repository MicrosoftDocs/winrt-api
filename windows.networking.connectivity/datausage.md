---
-api-id: T:Windows.Networking.Connectivity.DataUsage
-api-type: winrt class
---

<!-- Class syntax.
public class DataUsage : Windows.Networking.Connectivity.IDataUsage
-->

# Windows.Networking.Connectivity.DataUsage

## -description
> [!NOTE]
> DataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use [NetworkUsage](networkusage.md)

Represents data usage information returned by the [ConnectionProfile.GetLocalUsage](connectionprofile_getlocalusage_2102872925.md) method.

## -remarks
`DataUsage` values are available only when the platform implements `GetLocalUsage`. For Windows 10 and later you should
prefer [ConnectionProfile.GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md), which returns
richer [NetworkUsage](networkusage.md) data and supports per-app attribution.

When `GetLocalUsage` succeeds, treat the result as a coarse aggregate for the requested time range. The reported bytes may
lag behind real traffic and might not match the current metered plan counters exposed by the network operator.

## -examples

## -see-also

