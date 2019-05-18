---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.GetNetworkConnectivityLevel
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.Connectivity.NetworkConnectivityLevel GetNetworkConnectivityLevel()
-->

# Windows.Networking.Connectivity.ConnectionProfile.GetNetworkConnectivityLevel

## -description
Gets the network connectivity level for this connection. This value indicates what network resources, if any, are currently available.

## -returns
The level of network connectivity.

## -remarks
The GetNetworkConnectivityLevel method may take time in some cases to determine the current value of the network connectivity level. The recommended process for determining the network connectivity level is to register a handler for the [NetworkStatusChanged](networkinformation_networkstatuschanged.md) event on the [NetworkInformation](networkinformation.md) class. When a notification is received of a network status change, obtain the new connectivity level by calling the GetNetworkConnectivityLevel method on the profile returned by the [GetInternetConnectionProfile](networkinformation_getinternetconnectionprofile_255647281.md) method. The returned network connectivity level can then be stored for later use when needed. This also ensures that the correct [ConnectionProfile](connectionprofile.md) is checked.

## -examples

## -see-also
[GetInternetConnectionProfile](networkinformation_getinternetconnectionprofile_255647281.md), [NetworkInformation](networkinformation.md), [NetworkStatusChanged](networkinformation_networkstatuschanged.md)
