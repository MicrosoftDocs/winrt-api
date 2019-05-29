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

This value indicates captive portal connectivity, where local access to a web portal is provided, but access to the Internet requires that specific credentials are provided via the portal. This level of connectivity is generally encountered when using connections hosted in public locations (e.g. coffee shops and book stores).

> [!NOTE]
> This doesn't guarantee detection of a captive portal. UWP apps should also test if the captive portal can be reached using a URL for the captive portal, or by attempting access to a public web site which will then redirect to the captive portal when Windows reports **LocalAccess** as the current NetworkConnectivityLevel.

### -field InternetAccess:3
Local and Internet access.


## -remarks
For an example of how these values are used to indicate connection changes, see [Quickstart: Managing connection events and changes in availability](https://docs.microsoft.com/previous-versions/windows/apps/hh700376(v=win.10)).

## -examples

## -see-also
[Quickstart: Managing connection events and changes in availability](https://docs.microsoft.com/previous-versions/windows/apps/hh700376(v=win.10))
