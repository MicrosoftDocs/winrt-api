---
-api-id: T:Windows.Networking.Connectivity.ConnectionProfileFilter
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectionProfileFilter : Windows.Networking.Connectivity.IConnectionProfileFilter, Windows.Networking.Connectivity.IConnectionProfileFilter2
-->

# Windows.Networking.Connectivity.ConnectionProfileFilter

## -description
Defines properties used to filter results from [FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_358252851.md).
At least one property must be set; otherwise the filter is ignored.

## -remarks
### Purpose
Use **ConnectionProfileFilter** to narrow enumeration returned by
[FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_358252851.md) instead of processing the
entire set from [GetConnectionProfiles](networkinformation_getconnectionprofiles_1348266395.md) or relying solely on
the current internet profile.

### Guidance
- Start minimal; add properties only as needed to avoid over-constraining.
- Prefer **IsWlanConnectionProfile** / **IsWwanConnectionProfile** over parsing names to detect technology.
- Retrieve usage after filtering by calling
  [ConnectionProfile.GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md) rather than inferring it
  from filter inputs.
- Combine cost and connectivity level constraints only when necessary; connectivity can fluctuate during transitions.

### Purpose / Service provider GUID
Use **PurposeGuid** (or **ServiceProviderGuid**) only when you possess a valid value (carrier provisioning / enterprise
policy). An incorrect GUID silently yields zero results.

#### Purpose GUID sources
Purpose GUIDs are standardized identifiers surfaced by the Windows WWAN stack (MBIM context type GUIDs) and
appear on provisioned cellular profiles created by carrier/OEM provisioning or enterprise (MDM) policy. Do **not**
invent or randomize values; use only those delivered through official provisioning channels.

For the complete list of purpose GUIDs, see [PurposeGroupGuid](https://learn.microsoft.com/windows/win32/mbn/element-purposegroupguid).

> [!NOTE]  
> These GUIDs map to underlying MBIM context types. If a profile was not provisioned with a given purpose, filtering
> with that GUID returns no results (silent empty set).

Typical usage scenarios:
- Selecting a specialized IMS profile for voice/video service enablement.
- Isolating SUPL (assisted GPS) data contexts for cost or routing decisions.

Keep filtering logic narrow: specify **PurposeGuid** plus **IsWwanConnectionProfile** only; add other constraints
(e.g., connectivity level) only if required.

### Cost / connectivity considerations
Applying multiple cost states (for example forcing a specific [NetworkCostType](networkcosttype.md) plus roaming flags)
can remove legitimate candidates. After selecting profiles, inspect each profile's
[ConnectionCost](connectioncost.md) for adaptive behavior.

### Common pitfalls
| Pitfall | Result | Recommendation |
| -- | -- | -- |
| Setting both **IsWlanConnectionProfile** and **IsWwanConnectionProfile** to true expecting OR | Empty result (AND logic) | Leave both false for "any technology" or run two queries |
| Reusing a filter instance with leftover properties | Unexpectedly empty result | Create a new filter per query scenario |
| Supplying invalid **PurposeGuid** | Silent no matches | Validate GUID presence beforehand |
| Over-constraining with multiple cost flags | Zero profiles | Filter broadly, refine post-selection |

### Functional selection examples
- All currently connected profiles across technologies: set **IsConnected** = `true`; leave technology flags unset.
- Separate technology + provider logic: run distinct queries per technology when **ServiceProviderGuid** is involved (no OR across technologies in a single filter).

> [!NOTE]  
> Construct a fresh filter per query path; do not toggle properties on a shared instance between calls.


## -examples
Carrier / service provider filtering (C#):

```csharp
using Windows.Networking.Connectivity;

var carrierId = Guid.Parse("f68cd4bf-a388-4e8b-91ea-54dd6dd901c0"); // Replace with your known service provider GUID

// WWAN profiles
var wwanFilter = new ConnectionProfileFilter
{
    IsWwanConnectionProfile = true,
    ServiceProviderGuid = carrierId
};
var wwanProfiles = await NetworkInformation.FindConnectionProfilesAsync(wwanFilter);

// WLAN offload (create a new filter instead of mutating the prior one)
var wlanFilter = new ConnectionProfileFilter
{
    IsWlanConnectionProfile = true,
    ServiceProviderGuid = carrierId
};
var wlanProfiles = await NetworkInformation.FindConnectionProfilesAsync(wlanFilter);
```

### Selecting a cellular profile with minimum connectivity level

```csharp
using Windows.Networking.Connectivity;

var filter = new ConnectionProfileFilter
{
    IsWwanConnectionProfile = true,
    NetworkConnectivityLevel = NetworkConnectivityLevel.InternetAccess
};

var cellularProfiles = await NetworkInformation.FindConnectionProfilesAsync(filter);
```

### Filtering by IMS purpose GUID (C++/WinRT)

```cpp
#include <winrt/Windows.Networking.Connectivity.h>
using namespace winrt;
using namespace Windows::Networking::Connectivity;

IAsyncAction FindImsProfilesAsync()
{
    ConnectionProfileFilter filter;
    filter.IsWwanConnectionProfile(true);
    // IMS purpose GUID (authoritative WWAN context type)
    filter.PurposeGuid(winrt::guid{ L"{21610D01-3074-4BCE-9425-B53A07D697D6}" });

    auto profiles = co_await NetworkInformation::FindConnectionProfilesAsync(filter);

    for (auto const& profile : profiles)
    {
        auto details = profile.WwanConnectionProfileDetails();
        if (!details) continue;

        for (auto const& g : details.PurposeGuids())
        {
            if (g == winrt::guid{ L"{21610D01-3074-4BCE-9425-B53A07D697D6}" })
            {
                // App-specific: prioritize or attach IMS services for this profile
            }
        }
    }
}
```

> [!NOTE]  
> If no profiles were provisioned with the IMS purpose GUID the result set is empty; this is expected and not an error.

## -see-also
[CM_CellularEntries CSP](https://learn.microsoft.com/windows/client-management/mdm/cm-cellularentries-csp),
[ConnectionProfile](connectionprofile.md),
[ConnectionProfileFilter.PurposeGuid](connectionprofilefilter_purposeguid.md),
[FindConnectionProfilesAsync](networkinformation_findconnectionprofilesasync_358252851.md),
[PurposeGroups](https://learn.microsoft.com/windows/win32/mbn/element-purposegroups),
[WwanConnectionProfileDetails.PurposeGuids](wwanconnectionprofiledetails_purposeguids.md)
