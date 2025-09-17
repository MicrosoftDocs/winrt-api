---
-api-id: T:Windows.Networking.Connectivity.DataPlanStatus
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class DataPlanStatus : Windows.Networking.Connectivity.IDataPlanStatus
-->

# Windows.Networking.Connectivity.DataPlanStatus

## -description
Represents the current status information for the data plan associated with a connection.

## -remarks
Use this object (obtained from `ConnectionProfile.GetDataPlanStatus()`) to adapt behavior based on provisioning / quota information, for example:

* Defer large background sync if `DataPlanUsage` is near `DataLimitInMegabytes`.
* Show remaining quota to the user using `DataLimitInMegabytes - DataPlanUsage.MegabytesUsed` (when both present).
* Reduce media quality when approaching limit or when `MaxTransferSizeInMegabytes` is low.
* Anticipate quota reset by checking `NextBillingCycle`.

Properties can be null / unspecified depending on the operator or connection type; always null‑check before using values.

Example (C#):

```csharp
var profile = NetworkInformation.GetInternetConnectionProfile();
var status = profile?.GetDataPlanStatus();
if (status?.DataPlanUsage != null && status.DataLimitInMegabytes != null)
{
	var remaining = status.DataLimitInMegabytes.Value - status.DataPlanUsage.MegabytesUsed;
	if (remaining < 200) // threshold
	{
		// Warn user or throttle background operations
	}
}
```

Example (C++/WinRT):

```cpp
auto profile = NetworkInformation::GetInternetConnectionProfile();
if (profile)
{
	auto status = profile.GetDataPlanStatus();
	if (status && status.DataPlanUsage())
	{
		auto usage = status.DataPlanUsage();
		if (status.DataLimitInMegabytes())
		{
			auto remaining = status.DataLimitInMegabytes().Value() - usage.MegabytesUsed();
			if (remaining < 200) { /* warn */ }
		}
	}
}
```

For more information on using cost data to manage connectivity, see [Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10)).

## -examples

## -see-also
[Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10))
