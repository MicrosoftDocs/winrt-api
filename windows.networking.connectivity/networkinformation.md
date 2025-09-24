---
-api-id: T:Windows.Networking.Connectivity.NetworkInformation
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class NetworkInformation
-->

# Windows.Networking.Connectivity.NetworkInformation

## -description
Provides access to network connection information for the local machine.

## -remarks
NetworkInformation provides static methods to query network connectivity state and monitor changes:

* Call [NetworkInformation.GetInternetConnectionProfile](networkinformation_getinternetconnectionprofile_1892430619.md)() to get the current active connection profile (may return null if offline).
* Call [NetworkInformation.FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_649346237.md)(filter) with a
  [ConnectionProfileFilter](connectionprofilefilter.md) to enumerate additional profiles (for example, other WLAN interfaces,
  WWAN, or prior connections).
* Subscribe to the [NetworkInformation.NetworkStatusChanged](networkinformation_networkstatuschanged.md) event to be notified when connectivity changes instead of polling.

The returned [ConnectionProfile](connectionprofile.md) instances expose cost, data plan, adapter, and technology-specific
detail objects ([WlanConnectionProfileDetails](wlanconnectionprofiledetails.md),
[WwanConnectionProfileDetails](wwanconnectionprofiledetails.md)). Always re-query inside the status changed event handler
because previously cached profile objects are not live-updating.

For examples of how NetworkInformation class methods are implemented, see [Quickstart: Retrieving network connection information](/previous-versions/windows/apps/hh452990(v=win.10)).

Use this class to:

* Retrieve LAN/WLAN/WWAN specific details (for example, WlanConnectionProfileDetails, WwanConnectionProfileDetails).
* Obtain localized names or signal / data plan information through the associated profile objects.

Important guidance:

* If your scenario depends on cost awareness (metered vs unrestricted), query
  `connectionCost = profile?.GetConnectionCost()` and check `connectionCost.NetworkCostType` before large background
  transfers.
* For power efficiency, unsubscribe from events when your foreground component is not active.
* Connectivity level can upgrade (for example from `ConstrainedInternetAccess` to `InternetAccess`) without the internet
  profile reference changing. Re-check `GetNetworkConnectivityLevel()` inside each event invocation.

Event handling best practices:

> [!IMPORTANT]
> Always re-query [GetInternetConnectionProfile](networkinformation_getinternetconnectionprofile_1892430619.md)() inside the event handler. Do not cache an old profile instance and assume it's updated automatically.

* The event can fire frequently (for example, captive portal transitions, cost policy changes). Keep handlers lightweight and debounce expensive work.
* If using background tasks with `NetworkStateChangeEventDetails`, inspect flags (HasNewConnectionCost, HasNewNetworkConnectivityLevel, HasNewDomainConnectivityLevel, etc.) to selectively re-query only what changed.

Related classic (Win32) technologies include Network List Manager (NLM / INetworkListManager) and Data Usage & Subscription
Management (DUSM). Most UWP / WinRT apps should prefer NetworkInformation and ConnectionProfile over directly invoking
classic APIs; consult classic samples only for desktop bridge or advanced diagnostics scenarios.

For broader scenario guidance, see:

* [Network connectivity UWP sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/NetworkConnectivity)

## -examples
Event subscription pattern (C#):

```csharp
using Windows.Networking.Connectivity;

NetworkStatusChangedEventHandler handler = sender =>
{
    var profile = NetworkInformation.GetInternetConnectionProfile();
    var level = profile?.GetNetworkConnectivityLevel();
    if (level == NetworkConnectivityLevel.InternetAccess)
    {
        // Safe to (re)try outbound requests
    }
};

NetworkInformation.NetworkStatusChanged += handler;
```

Selective re-query pattern (C# pseudo-code):

```csharp
void OnNetworkStatusChanged(NetworkStateChangeEventDetails details)
{
    var profile = NetworkInformation.GetInternetConnectionProfile();
    if (details.HasNewNetworkConnectivityLevel || details.HasNewInternetConnectionProfile)
    {
        var level = profile?.GetNetworkConnectivityLevel();
    }
    if (details.HasNewConnectionCost)
    {
        var cost = profile?.GetConnectionCost();
    }
    if (details.HasNewDomainConnectivityLevel)
    {
        bool tls = profile?.IsDomainAuthenticatedBy(DomainAuthenticationKind.Tls) == true;
    }
    if (details.HasNewHostNameList)
    {
        // Refresh host name dependent routing logic
    }
}
```

Filtering example (C#):

```csharp
using Windows.Networking.Connectivity;

var filter = new ConnectionProfileFilter
{
    IsConnected = true,
    IsWlanConnectionProfile = true
};
var wifiProfiles = await NetworkInformation.FindConnectionProfilesAsync(filter);
```

Determine if the device currently has internet access and is on an unrestricted network (C#):

```csharp
using Windows.Networking.Connectivity;

var profile = NetworkInformation.GetInternetConnectionProfile();
bool hasInternet = profile?.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
bool unrestricted = false;
if (profile != null)
{
    var cost = profile.GetConnectionCost();
    unrestricted = cost.NetworkCostType == NetworkCostType.Unrestricted && !cost.Roaming && !cost.OverDataLimit;
}

// Use hasInternet/unrestricted to decide whether to start background sync
```

Enumerate all connected WLAN profiles (C++/WinRT):

```cpp
#include <winrt/Windows.Networking.Connectivity.h>
using namespace winrt; using namespace Windows::Networking::Connectivity;

IAsyncAction ListWifiProfiles()
{
    ConnectionProfileFilter filter;
    filter.IsWlanConnectionProfile(true);
    filter.IsConnected(true);
    auto profiles = co_await NetworkInformation::FindConnectionProfilesAsync(filter);
    for (auto const& p : profiles)
    {
        if (auto wlan = p.WlanConnectionProfileDetails())
        {
            auto ssid = wlan.GetConnectedSsid();
            // Log or display ssid
        }
    }
}
```

Subscribe to network status change (C++/WinRT):

```cpp
#include <winrt/Windows.Foundation.h>
#include <winrt/Windows.Networking.Connectivity.h>
using namespace winrt; using namespace Windows::Networking::Connectivity;

struct NetworkWatcher
{
    winrt::event_token token;
    void Start()
    {
        token = NetworkInformation::NetworkStatusChanged({ this, &NetworkWatcher::OnChanged });
    }
    void Stop()
    {
        if (token.value) NetworkInformation::NetworkStatusChanged(token);
    }
    void OnChanged(IInspectable const&)
    {
        auto profile = NetworkInformation::GetInternetConnectionProfile();
        if (profile && profile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel::InternetAccess)
        {
            // Online logic
        }
    }
};
```

## -see-also

[Network Cost sample](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/NetworkCost),
[Network List Manager sample](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/NetworkListManager),
[NetworkConnectivity sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/NetworkConnectivity)
