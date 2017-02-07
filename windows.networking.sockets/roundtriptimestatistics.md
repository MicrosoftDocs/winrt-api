---
-api-id: T:Windows.Networking.Sockets.RoundTripTimeStatistics
-api-type: winrt struct
---

<!-- Structure syntax.
public struct RoundTripTimeStatistics 
-->

# RoundTripTimeStatistics

## -description
Represents round trip time information for a [StreamSocket](streamsocket.md) object.

## -struct-fields

### -field Variance
The round trip time variation, in microseconds, for a [StreamSocket](streamsocket.md) object. This value is used for receive window auto-tuning.

This value is always 0 on systems that do not have extended TCP statistics enabled by default.
    

### -field Max
The maximum sampled round trip time, in microseconds, for a [StreamSocket](streamsocket.md) object.

This value is always 0 on systems that do not have extended TCP statistics enabled by default.
    

### -field Min
The minimum sampled round trip time, in microseconds, for a [StreamSocket](streamsocket.md) object.

This value is always 0 on systems that do not have extended TCP statistics enabled by default.
    

### -field Sum
A smoothed value round trip time, in microseconds, computed from all sampled round trip times for a [StreamSocket](streamsocket.md) object. The smoothing is a weighted additive function that uses the  member.

This value is always 0 on systems that do not have extended TCP statistics enabled by default.
    

## -remarks


## -examples

## -see-also
[StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]