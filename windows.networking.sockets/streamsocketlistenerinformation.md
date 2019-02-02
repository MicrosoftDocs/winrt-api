---
-api-id: T:Windows.Networking.Sockets.StreamSocketListenerInformation
-api-type: winrt class
---

<!-- Class syntax.
public class StreamSocketListenerInformation : Windows.Networking.Sockets.IStreamSocketListenerInformation
-->

# Windows.Networking.Sockets.StreamSocketListenerInformation

## -description
Provides socket information on a [StreamSocketListener](streamsocketlistener.md) object.

## -remarks
The [StreamSocketListenerInformation](streamsocketlistenerinformation.md) class retrieves information on a [StreamSocketListener](streamsocketlistener.md) and can be called any time after the [StreamSocketListener](streamsocketlistener.md) has been created.

A [StreamSocketListenerInformation](streamsocketlistenerinformation.md) object is automatically created with the parent [StreamSocketListener](streamsocketlistener.md) object. The [StreamSocketListener.Information](streamsocketlistener_information.md) property provides access to the associated [StreamSocketListenerControl](streamsocketlistenercontrol.md) object.

## -examples

## -see-also
[Connecting with sockets ](https://msdn.microsoft.com/library/67cfa78f-570f-4dd4-a0f2-cd6c891f5446), [Connecting with sockets ](https://msdn.microsoft.com/library/2a6448d0-e21f-4963-bca5-aae001ae4fc7), [How to use advanced socket controls ](https://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](https://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [StreamSocketListener](streamsocketlistener.md), [StreamSocketListener.Information](streamsocketlistener_information.md), [Bluetooth Rfcomm Chat sample](https://go.microsoft.com/fwlink/p/?LinkID=306047), [ControlChannelTrigger StreamSocket sample](https://go.microsoft.com/fwlink/p/?linkid=243039), [Proximity sample](https://go.microsoft.com/fwlink/p/?linkid=245082), [StreamSocket sample](https://go.microsoft.com/fwlink/p/?linkid=243037)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
