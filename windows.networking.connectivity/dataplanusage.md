---
-api-id: T:Windows.Networking.Connectivity.DataPlanUsage
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class DataPlanUsage : Windows.Networking.Connectivity.IDataPlanUsage
-->

# Windows.Networking.Connectivity.DataPlanUsage

## -description
Represents data plan specific data usage information for a connection.

## -remarks
Retrieve this object from [ConnectionProfile.GetDataPlanStatus](connectionprofile_getdataplanstatus_2024938217.md). The
reported values reflect data that the operator exposes to Windows and can lag behind real-time traffic. Treat the
numbers as guidance instead of an absolute truth when deciding whether to throttle transfers.

> [!IMPORTANT]
> `DataPlanUsage` can be `null` even when `DataPlanStatus` is present. Guard for a missing value before reading
> `MegabytesUsed` to avoid null reference exceptions.

## -examples
Check monthly usage (C#):

```csharp
using Windows.Networking.Connectivity;

var profile = NetworkInformation.GetInternetConnectionProfile();
var status = profile?.GetDataPlanStatus();
var usage = status?.DataPlanUsage;
if (usage != null)
{
    // App-specific: compare usage.MegabytesUsed against your alert threshold.
}
```

## -see-also

[DataPlanStatus](dataplanstatus.md),
[NetworkConnectivity sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/NetworkConnectivity)
