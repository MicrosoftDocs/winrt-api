---
-api-id: T:Windows.Networking.Connectivity.ConnectionProfile
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectionProfile : Windows.Networking.Connectivity.IConnectionProfile, Windows.Networking.Connectivity.IConnectionProfile2, Windows.Networking.Connectivity.IConnectionProfile3
-->

# Windows.Networking.Connectivity.ConnectionProfile

## -description
Represents a network connection, which includes either the currently connected network or prior network connections. Provides information about the connection status and connectivity statistics.

## -remarks
ConnectionProfile represents a snapshot of a specific network interface's connectivity attributes (WLAN, WWAN,
Ethernet, etc.). Re-query the profile when you receive a network status change event because cached profile objects
may be obsolete or contain stale properties.

Connectivity level evolution:

* A single `ConnectionProfile` instance can progress through `LocalAccess`, `ConstrainedInternetAccess`, and
  `InternetAccess` states as the network becomes fully usable. Always call `GetNetworkConnectivityLevel()` at the
  decision point instead of assuming the level when the profile was first retrieved.

Common tasks:

* Determine effective connectivity level ([GetNetworkConnectivityLevel](connectionprofile_getnetworkconnectivitylevel_1968047035.md)).
* Inspect data plan and metering ([GetConnectionCost](connectionprofile_getconnectioncost_1946735978.md), [GetDataPlanStatus](connectionprofile_getdataplanstatus_1468491499.md)).
* Get adapter and network names ([NetworkAdapter](connectionprofile_networkadapter.md), [ProfileName](connectionprofile_profilename.md)).
* Retrieve per-profile usage statistics ([GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md), [GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md)).
* Identify WLAN SSID (WlanConnectionProfileDetails.GetConnectedSsid) or WWAN home/roaming state
  (WwanConnectionProfileDetails).
* Determine if the profile can be deleted (e.g., user saved Wi-Fi profile) via CanDelete / TryDeleteAsync.

Cost / data usage considerations:

* Respect metered networks: If connectionCost.NetworkCostType is not Unrestricted, delay large background transfers
  unless the user initiates them.
* If connectionCost.Roaming is true, avoid non-critical sync to prevent unexpected charges.
* If OverDataLimit or ApproachingDataLimit is set, surface a UI warning or reduce quality (for example, lower bitrate streaming).

Deletion guidance:

TryDeleteAsync succeeds only for user-removable profiles (for example, some WLAN profiles) and when the caller has
appropriate permissions. Always check the returned ConnectionProfileDeleteStatus and handle DeniedBySystem or
UnknownError gracefully.

Performance tips:

* Avoid calling usage APIs ([GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md)) too frequently; aggregate intervals (for example, per 15 minutes) for telemetry.
* Dispose of large usage collections promptly; enumerate and summarize rather than storing raw entries.
* For background tasks, check cost state late (immediately before transfer) to ensure freshness.

Interoperability note: Classic desktop components may still use NLM (INetworkListManager) or DUSM cost APIs directly;
the WinRT surface (ConnectionProfile, NetworkInformation) abstracts these for most app scenarios.

Independent cost flag changes:

* Flags such as `Roaming`, `OverDataLimit`, or `ApproachingDataLimit` may change while `NetworkCostType` remains
  constant. Re-evaluate individual flags when behavior depends on them; do not rely solely on `NetworkCostType` transitions.

Domain authentication:

Some enterprise networks can be domain-authenticated via classic Active Directory (LDAP) or via a TLS-based mechanism
configured through device management policy. Use IsDomainAuthenticatedBy(DomainAuthenticationKind.Ldap) or
IsDomainAuthenticatedBy(DomainAuthenticationKind.Tls) to differentiate the method. Only one method reports true (LDAP
takes precedence when both could succeed). Treat IsDomainAuthenticatedBy(DomainAuthenticationKind.None) as "not domain
authenticated". Re-query after network status change events rather than caching earlier results because authentication
state can change with network transitions.

Relationship to DomainConnectivityLevel:

`GetDomainConnectivityLevel()` reports the broader domain trust state (None / Unauthenticated / Authenticated) while
`IsDomainAuthenticatedBy(...)` identifies which mechanism (LDAP or TLS) established that trust. Typically you first
ensure `GetDomainConnectivityLevel()` returns `Authenticated` and then branch on the authentication kind if you need to
distinguish behavior or telemetry.

For more examples, see: [Quickstart: Retrieving network connection information](/previous-versions/windows/apps/hh452990(v=win.10)) and the connectivity samples referenced below.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | GetProviderNetworkUsageAsync |
| 1809 | 17763 | CanDelete |
| 1809 | 17763 | TryDeleteAsync |

## -examples
Summarize active internet profile (C#):

```csharp
using Windows.Networking.Connectivity;

ConnectionProfile profile = NetworkInformation.GetInternetConnectionProfile();
if (profile != null)
{
     var level = profile.GetNetworkConnectivityLevel();
     var cost = profile.GetConnectionCost();
     var plan = profile.GetDataPlanStatus();
     bool metered = cost.NetworkCostType != NetworkCostType.Unrestricted || cost.Roaming || cost.OverDataLimit;
     // Use 'metered' flag to gate background sync
}
```

Enumerate usage over last hour (C++/WinRT):

```cpp
IAsyncAction LogUsage(ConnectionProfile const& profile)
{
     auto endTime = DateTime::clock::now();
     auto startTime = endTime - std::chrono::hours(1);
     NetworkUsageStates states; // default (all)
     auto usages = co_await profile.GetNetworkUsageAsync(startTime, endTime, DataUsageGranularity::PerMinute, L"{}");
     for (auto const& u : usages)
     {
          auto bytes = u.BytesSent() + u.BytesReceived();
          // Aggregate or log bytes
     }
}
```

Log cost state (C++/WinRT):

```cpp
void LogCost(ConnectionProfile const& profile)
{
     if (!profile) return;
     auto cost = profile.GetConnectionCost();

     std::wcout << L"CostType=" << static_cast<int>(cost.NetworkCostType())
                  << L" roaming=" << (cost.Roaming() ? L"true" : L"false")
                  << L" overLimit=" << (cost.OverDataLimit() ? L"true" : L"false")
                  << L" approachingLimit=" << (cost.ApproachingDataLimit() ? L"true" : L"false")
                  << L" backgroundRestricted=" << (cost.BackgroundDataUsageRestricted() ? L"true" : L"false")
                  << std::endl;
}
```

Delete a removable Wi-Fi profile if allowed (C#):

```csharp
using Windows.Networking.Connectivity;

var profiles = await NetworkInformation.FindConnectionProfilesAsync(new ConnectionProfileFilter{ IsWlanConnectionProfile = true });
foreach (var p in profiles)
{
     if (p.CanDelete == TriStates.Yes)
     {
          var status = await p.TryDeleteAsync();
          // Check status (Success, DeniedBySystem, UnknownError)
     }
}
```

Query attributed usage for a specific app (C++/WinRT snippet pattern):

```cpp
IAsyncAction LogAttributedUsage(ConnectionProfile const& profile)
{
     if (!profile) co_return;
     auto endTime = clock::now();
     auto startTime = endTime - std::chrono::minutes(30);
     NetworkUsageStates states; // no roaming/shared constraints

     // Optional: attribute by a set of host names (e.g., your service endpoints)
     std::vector<HostName> hosts { HostName{ L"api.contoso.com" }, HostName{ L"cdn.contoso.com" } };
     auto hostView = single_threaded_vector(std::move(hosts)).GetView();

     // Per-app usage
     auto appUsages = co_await profile.GetAttributedNetworkUsageAsync(startTime, endTime, states);
     for (auto const& u : appUsages)
     {
          auto total = u.BytesSent() + u.BytesReceived();
          // u.AttributionId() identifies the bucket
     }
}
```

Check domain authentication mechanism (C#):

```csharp
using Windows.Networking.Connectivity;

var profile = NetworkInformation.GetInternetConnectionProfile();
if (profile != null)
{
     bool isLdap = profile.IsDomainAuthenticatedBy(DomainAuthenticationKind.Ldap);
     bool isTls  = profile.IsDomainAuthenticatedBy(DomainAuthenticationKind.Tls);
     if (isLdap || isTls)
     {
          // Enable enterprise-only resources; optionally branch on LDAP vs TLS
     }
}
```

## -see-also
[NetworkInformation.FindConnectionProfilesAsync](/uwp/api/windows.networking.connectivity.networkinformation#Windows_Networking_Connectivity_NetworkInformation_FindConnectionProfilesAsync_Windows_Networking_Connectivity_ConnectionProfileFilter_)
