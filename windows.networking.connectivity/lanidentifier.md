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
Represents physical identification data for a specific [NetworkAdapter](networkadapter.md) object.

## -remarks
Location data is expressed either as a BSSID if the network adapter media type is Wireless LAN, or as a tuple &lt;ChassisId, Port Number&gt; if the network adapter type is Ethernet. The data is represented according to the LLDP protocol.

For examples of how to retrieve data represented by a [LanIdentifier](lanidentifier.md) object, see [How to retrieve network adapter and locality information](http://msdn.microsoft.com/library/385cbc7b-92eb-4c6b-97e0-c669333b39e3).

## -examples

## -see-also