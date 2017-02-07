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
The following example function demonstrates how retrieve data from a [ConnectionProfile](connectionprofile.md).





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

For more examples of how these class methods are implemented to access connection information, see [Quickstart: Retrieving network connection information](http://msdn.microsoft.com/library/ef383500-f2a9-4b93-8f6b-1f87560305d8).

## -examples

## -see-also