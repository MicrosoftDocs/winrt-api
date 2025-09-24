---
-api-id: T:Windows.Networking.Connectivity.WwanConnectionProfileDetails
-api-type: winrt class
---

<!-- Class syntax.
public class WwanConnectionProfileDetails : Windows.Networking.Connectivity.IWwanConnectionProfileDetails
-->

# Windows.Networking.Connectivity.WwanConnectionProfileDetails

## -description
Provides WWAN (cellular) specific details for a connection profile: carrier identifiers, registration state, current data class, IP kind, and purpose GUIDs.

## -remarks
### Retrieval
Access via [ConnectionProfile.WwanConnectionProfileDetails](connectionprofile_wwanconnectionprofiledetails.md) when
[ConnectionProfile.IsWwanConnectionProfile](connectionprofile_iswwanconnectionprofile.md) is `true`.

### Key properties
| Area | Property / Method | Purpose |
| -- | -- | -- |
| Carrier ID | [HomeProviderId](wwanconnectionprofiledetails_homeproviderid.md) | MCC+MNC identifying the home carrier |
| APN | [AccessPointName](wwanconnectionprofiledetails_accesspointname.md) | APN used for this data session |
| Registration | [GetNetworkRegistrationState](wwanconnectionprofiledetails_getnetworkregistrationstate_117061146.md) | Current network registration state |
| Data technology | [GetCurrentDataClass](wwanconnectionprofiledetails_getcurrentdataclass_1355956130.md) | Active cellular data class (flags) |
| IP protocol | [IPKind](wwanconnectionprofiledetails_ipkind.md) | IPv4 / IPv6 / dual‑stack configuration |
| Purpose tagging | [PurposeGuids](wwanconnectionprofiledetails_purposeguids.md) | Scenario / policy identifiers applied to the profile |

### Registration states
Returned by `GetNetworkRegistrationState`:
| State | Meaning |
| -- | -- |
| Home | Registered on home network |
| Roaming | Registered on a roaming network |
| Partner | Registered on preferred partner network |
| Searching | Scanning for service |
| Denied | Registration rejected (entitlement / SIM / network) |
| None | Not registered / no capability |

### Data class (examples)
`GetCurrentDataClass` returns a bitmask; common groupings:
| Generation | Flags (non exhaustive) |
| -- | -- |
| 5G | NewRadioNonStandalone, NewRadioStandalone |
| 4G / LTE | LteAdvanced |
| 3G | Umts, Hsdpa, Hsupa |
| 2G | Gprs, Edge |
| CDMA | (Various CDMA flags) |

> [!NOTE]  
> Reported value is the currently active technology, not necessarily the modem's peak capability.

### Usage patterns
| Scenario | Relevant members | Notes |
| -- | -- | -- |
| Show carrier + technology badge | HomeProviderId, GetCurrentDataClass | Map bitmask to UI string (e.g., 5G / LTE) |
| Enforce roaming policy | GetNetworkRegistrationState, ConnectionCost | Combine roaming state + metering |
| APN diagnostics | AccessPointName, PurposeGuids | PurposeGuids distinguishes specialized carrier profiles |
| IPv6 readiness | IPKind | Decide whether to prefer IPv6 endpoints |

### Best practices
- Re-query on network status change events; WWAN tech can shift (e.g., LTE -> 5G NSA).
- Do not hard-code assumptions about future data classes; handle unknown flags gracefully.
- Treat roaming + metered cost as a trigger to reduce background transfer volume.
- For analytics, log normalized technology buckets (2G/3G/4G/5G) rather than raw flag sets.

### Version additions
| Windows version | Added |
| -- | -- |
| 1803 | IPKind, PurposeGuids |
| 1903+ | 5G data class flags (NR NSA / SA) |


## -examples
### Display current WWAN technology and roaming (C#)
```csharp
using Windows.Networking.Connectivity;

var profile = NetworkInformation.GetInternetConnectionProfile();
if (profile?.IsWwanConnectionProfile == true)
{
    var details = profile.WwanConnectionProfileDetails;
    var reg = details.GetNetworkRegistrationState();
    var dataClass = details.GetCurrentDataClass();
    var cost = profile.GetConnectionCost();

    bool isRoaming = reg == WwanNetworkRegistrationState.Roaming;
    string tech = dataClass.ToString(); // Map or bucket as needed

    System.Diagnostics.Debug.WriteLine(
        $"Carrier={details.HomeProviderId} APN={details.AccessPointName} Tech={tech} Roaming={isRoaming} Metered={cost.Roaming || cost.OverDataLimit}");
}
```

### Check dual‑stack capability (C#)
```csharp
var p = NetworkInformation.GetInternetConnectionProfile();
if (p?.IsWwanConnectionProfile == true)
{
    var ipKind = p.WwanConnectionProfileDetails.IPKind;
    bool hasIpv6 = ipKind == WwanNetworkIPKind.Ipv6 ||
                   ipKind == WwanNetworkIPKind.Ipv4v6;
    // Adjust endpoint selection accordingly
}
```

## -see-also
[ConnectionProfile.IsWwanConnectionProfile](connectionprofile_iswwanconnectionprofile.md),
[ConnectionProfile.WwanConnectionProfileDetails](connectionprofile_wwanconnectionprofiledetails.md),
[NetworkInformation](networkinformation.md),
[WwanDataClass](wwandataclass.md),
[WwanNetworkIPKind](wwannetworkipkind.md),
[WwanNetworkRegistrationState](wwannetworkregistrationstate.md)
