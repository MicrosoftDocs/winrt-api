---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionMessageChannelReliability
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum RemoteSystemSessionMessageChannelReliability : int 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionMessageChannelReliability

## -description
Contains values that describe the reliability type of a remote session messaging channel.

## -enum-fields
### -field Unreliable:1
The channel is connectionless. Delivery of packets is not guaranteed.

### -field Reliable:0
The channel is connection-based. Delivery of packets is guaranteed as long as the connection remains open.

## -remarks
The ordering of messages is not guaranteed for channels of either reliability type.

## -see-also

## -examples

