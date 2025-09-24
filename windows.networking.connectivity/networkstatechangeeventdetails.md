---
-api-id: T:Windows.Networking.Connectivity.NetworkStateChangeEventDetails
-api-type: winrt class
---

<!-- Class syntax.
public class NetworkStateChangeEventDetails : Windows.Networking.Connectivity.INetworkStateChangeEventDetails, Windows.Networking.Connectivity.INetworkStateChangeEventDetails2
-->

# Windows.Networking.Connectivity.NetworkStateChangeEventDetails

## -description
Provides detailed information about what network properties changed when a network state change event occurs, allowing applications 
to respond appropriately to specific types of connectivity changes.

## -remarks
[NetworkStateChangeEventDetails](networkstatechangeeventdetails.md) is used in conjunction with the 
[NetworkInformation.NetworkStatusChanged](networkinformation_networkstatuschanged.md) event to provide detailed information about 
what aspects of network connectivity have changed. This allows applications to respond selectively to different types of network 
changes rather than re-evaluating all network conditions.

[!IMPORTANT]
When handling network state change events, always re-query current network information using 
[NetworkInformation](networkinformation.md) methods rather than caching previous state. The event details indicate what changed, 
but the current values should be obtained through fresh API calls.

### Available change indicators

The class provides Boolean properties to indicate specific types of changes:

**Core connectivity changes:**
- [HasNewInternetConnectionProfile](networkstatechangeeventdetails_hasnewinternetconnectionprofile.md): Internet connection 
  profile availability changed
- [HasNewNetworkConnectivityLevel](networkstatechangeeventdetails_hasnewnetworkconnectivitylevel.md): Network connectivity 
  level changed (None, LocalAccess, ConstrainedInternetAccess, InternetAccess)
- [HasNewConnectionCost](networkstatechangeeventdetails_hasnewconnectioncost.md): Network cost information changed

**Extended connectivity information:**
- [HasNewDomainConnectivityLevel](networkstatechangeeventdetails_hasnewdomainconnectivitylevel.md): Domain authentication 
  status changed
- [HasNewHostNameList](networkstatechangeeventdetails_hasnewhostnamelist.md): Available host names changed
- [HasNewWwanRegistrationState](networkstatechangeeventdetails_hasnewwwanregistrationstate.md): Cellular registration 
  state changed

**Tethering and mobile hotspot (Windows 10 version 1511 and later):**
- [HasNewTetheringOperationalState](networkstatechangeeventdetails_hasnewtetheringoperationalstate.md): Mobile hotspot 
  state changed
- [HasNewTetheringClientCount](networkstatechangeeventdetails_hasnewtetheringclientcount.md): Number of connected 
  tethering clients changed

[!NOTE]
The [NetworkStateChangeEventDetails](networkstatechangeeventdetails.md) object is not directly created by applications. It is 
provided by the system when network state change events occur through background tasks or event handlers.

## -examples

### Efficient event handling

Use the specific change indicators to minimize unnecessary work in event handlers:

```csharp
private void OnNetworkStatusChanged(object sender)
{
    // Get current network information
    var internetProfile = NetworkInformation.GetInternetConnectionProfile();
    
    // Only check cost information if it might have changed
    if (eventDetails.HasNewConnectionCost && internetProfile != null)
    {
        var cost = internetProfile.GetConnectionCost();
        UpdateCostUI(cost);
    }
    
    // Only update connectivity UI if connectivity level changed
    if (eventDetails.HasNewNetworkConnectivityLevel)
    {
        var connectivityLevel = internetProfile?.GetNetworkConnectivityLevel();
        UpdateConnectivityUI(connectivityLevel);
    }
}
```

## -see-also
[ConnectionCost](connectioncost.md),
[ConnectionProfile](connectionprofile.md),
[NetworkConnectivity sample](https://github.com/Microsoft/Windows-universal-samples/tree/main/Samples/NetworkConnectivity),
[NetworkConnectivityLevel](networkconnectivitylevel.md),
[NetworkInformation](networkinformation.md),
[NetworkInformation.NetworkStatusChanged](networkinformation_networkstatuschanged.md)
