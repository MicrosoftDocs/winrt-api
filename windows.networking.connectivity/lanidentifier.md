---
-api-id: T:Windows.Networking.Connectivity.LanIdentifier
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class LanIdentifier : Windows.Networking.Connectivity.ILanIdentifier
-->

# Windows.Networking.Connectivity.LanIdentifier

## -description
Represents physical identification data for a specific [NetworkAdapter](networkadapter.md) object. For a code example showing how to retrieve data represented by a [LanIdentifier](lanidentifier.md) object, see [How to retrieve network adapter and locality information (XAML)](https://msdn.microsoft.com/library/windows/apps/xaml/Hh465168).


## -remarks
Location data is expressed either as a BSSID if the network adapter media type is Wireless LAN, or as a tuple &lt;ChassisId, Port Number&gt; if the network adapter type is Ethernet. The data is represented according to the LLDP protocol.

## -examples

[How to retrieve network adapter and locality information (XAML)](https://msdn.microsoft.com/library/windows/apps/xaml/Hh465168)

## -see-also