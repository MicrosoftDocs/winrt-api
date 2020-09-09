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
The following example function demonstrates how to retrieve data from a ConnectionProfile.

```javascript
function getConnectionProfileInfo(connectionProfile) {
     
     returnString += "Connection Cost Information:\n\r";
     returnString += "===============\n\r";
     var connectionCost = connectionProfile.getConnectionCost();
     returnString += "Cost Type: " + getCostType(connectionCost.networkCostType) + "\n\r";
     returnString += "Roaming: " + connectionCost.roaming + "\n\r";
     returnString += "Over Datalimit: " + connectionCost.overDataLimit + "\n\r";
     returnString += "Approaching Datalimit: " + connectionCost.approachingDataLimit + "\n\r";
}

```

For more examples of how these class methods are implemented to access connection information, see [Quickstart: Retrieving network connection information](/previous-versions/windows/apps/hh452990(v=win.10)).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | GetProviderNetworkUsageAsync |
| 1809 | 17763 | CanDelete |
| 1809 | 17763 | TryDeleteAsync |

## -examples

## -see-also
[NetworkInformation.FindConnectionProfilesAsync](/uwp/api/windows.networking.connectivity.networkinformation#Windows_Networking_Connectivity_NetworkInformation_FindConnectionProfilesAsync_Windows_Networking_Connectivity_ConnectionProfileFilter_)
