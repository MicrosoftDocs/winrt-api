---
-api-id: T:Windows.Networking.Connectivity.NetworkAdapter
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class NetworkAdapter : Windows.Networking.Connectivity.INetworkAdapter
-->

# Windows.Networking.Connectivity.NetworkAdapter

## -description
Represents a network adapter and provides access to information about its capabilities, connection status, and network properties.

## -remarks
A [NetworkAdapter](networkadapter.md) instance is typically obtained from a [ConnectionProfile](connectionprofile.md) through the 
[NetworkAdapter](connectionprofile_networkadapter.md) property. You can use this object to access details about the physical or virtual 
network interface, including bandwidth capabilities, interface type, and associated network item information.

### Key properties and methods

The [NetworkAdapter](networkadapter.md) class provides several important properties:

- **[OutboundMaxBitsPerSecond](networkadapter_outboundmaxbitspersecond.md)** and 
  **[InboundMaxBitsPerSecond](networkadapter_inboundmaxbitspersecond.md)**: Maximum theoretical bandwidth capabilities.
- **[IanaInterfaceType](networkadapter_ianainterfacetype.md)**: Standard interface type classification.
- **[NetworkAdapterId](networkadapter_networkadapterid.md)**: Unique identifier for the adapter.
- **[NetworkItem](networkadapter_networkitem.md)**: Associated network information.

> [!IMPORTANT]
> The bandwidth values returned by [OutboundMaxBitsPerSecond](networkadapter_outboundmaxbitspersecond.md) and
> [InboundMaxBitsPerSecond](networkadapter_inboundmaxbitspersecond.md) represent the maximum theoretical speeds of the network adapter
> hardware, not the actual available bandwidth on the current connection.

### Getting connection profile information

Use [GetConnectedProfileAsync](networkadapter_getconnectedprofileasync_1956832718.md) to retrieve the 
[ConnectionProfile](connectionprofile.md) associated with this network adapter. This is useful when you have a 
[NetworkAdapter](networkadapter.md) reference and need to access connection-specific information like cost, usage data, or 
connectivity status.

```csharp
var adapter = connectionProfile.NetworkAdapter;
var profile = await adapter.GetConnectedProfileAsync();
// Use profile to access connection-specific information
```

### Interface type classification

The [IanaInterfaceType](networkadapter_ianainterfacetype.md) property returns a numeric value corresponding to IANA interface types. 
Common values include:
- 6: Ethernet
- 24: Loopback interface
- 71: IEEE 802.11 wireless LAN
- 243: WWAN (cellular/mobile broadband)

For a complete list, refer to the IANA Interface Types registry.

## -examples

## -see-also
[ConnectionProfile](connectionprofile.md),
[ConnectionProfile.NetworkAdapter](connectionprofile_networkadapter.md),
[NetworkConnectivity sample](https://github.com/Microsoft/Windows-universal-samples/tree/main/Samples/NetworkConnectivity),
[NetworkInformation](networkinformation.md),
[NetworkItem](networkitem.md)
