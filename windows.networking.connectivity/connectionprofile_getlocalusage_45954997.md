---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.GetLocalUsage(Windows.Foundation.DateTime,Windows.Foundation.DateTime,Windows.Networking.Connectivity.RoamingStates)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.Connectivity.DataUsage GetLocalUsage(Windows.Foundation.DateTime StartTime, Windows.Foundation.DateTime EndTime, Windows.Networking.Connectivity.RoamingStates States)
-->

# Windows.Networking.Connectivity.ConnectionProfile.GetLocalUsage

## -description
> [!NOTE]
> GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use [GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md)

Gets the estimated data usage for a connection over a specific period of time and roaming state.



## -parameters
### -param StartTime
The start date/time for the usage data request.

### -param EndTime
The end date/time for the usage data request.

### -param States
The roaming state to scope the request to.

## -returns
The requested local data usage information.

## -remarks
For an example of how this method is used, see [How to retrieve connection usage data for a specific period of time](/previous-versions/windows/apps/hh465162(v=win.10)).

## -examples

## -see-also
[GetLocalUsage(DateTime, DateTime)](connectionprofile_getlocalusage_2102872925.md)
