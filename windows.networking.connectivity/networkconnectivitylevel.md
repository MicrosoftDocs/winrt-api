---
-api-id: T:Windows.Networking.Connectivity.NetworkConnectivityLevel
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Connectivity.NetworkConnectivityLevel : int
-->

# NetworkConnectivityLevel

## -description
Defines the level of connectivity currently available.

## -enum-fields
### -field None:0
No connectivity.

### -field LocalAccess:1
Local network access only.

### -field ConstrainedInternetAccess:2
Limited internet access.

This value is an indication that the connection is constrained, possibly due to a captive portal. Or possibly due to some other reason; for example, a proxy between the client and the internet that's modifying the HTTP header in some unknown way. In the case of captive portal connectivity, local access to a web portal is provided, but access to the internet requires that specific credentials are provided via the portal.

This level of connectivity (limited internet access) is generally encountered when using connections hosted in public locations (for example, coffee shops and book stores).

> [!NOTE]
> As mentioned, this doesn't necessarily mean that a captive portal has been detected. You should also test whether the captive portal can be reached by using a URL for the captive portal, or by attempting access to a public web site, which will then redirect to the captive portal when Windows reports **LocalAccess** as the current NetworkConnectivityLevel.

### -field InternetAccess:3
Local and internet access.

## -remarks

> [!IMPORTANT]
> The network status reported by Windows APIs is only a hint - its accuracy may vary depending on the local network
> topology and conditions. Apps should attempt to connect to their services whenever LocalAccess or higher connectivity
> is reported.

For a complete implementation demonstrating connection attempts with any level of local connectivity, see the 
[NetworkConnectivity sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/NetworkConnectivity).

## -examples

## -see-also
[NetworkInformation](networkinformation.md),
[Quickstart: Managing connection events and changes in availability](/previous-versions/windows/apps/hh700376(v=win.10))
