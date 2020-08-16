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
The StreamSocketListenerInformation class retrieves information on a [StreamSocketListener](streamsocketlistener.md) and can be called any time after the [StreamSocketListener](streamsocketlistener.md) has been created.

A StreamSocketListenerInformation object is automatically created with the parent [StreamSocketListener](streamsocketlistener.md) object. The [StreamSocketListener.Information](streamsocketlistener_information.md) property provides access to the associated [StreamSocketListenerControl](streamsocketlistenercontrol.md) object.

## -examples

## -see-also
[Connecting with sockets ](https://docs.microsoft.com/previous-versions/windows/apps/hh452977(v=win.10)), [Connecting with sockets ](https://docs.microsoft.com/previous-versions/windows/apps/hh452976(v=win.10)), [How to use advanced socket controls ](https://docs.microsoft.com/previous-versions/windows/apps/hh780596(v=win.10)), [How to use advanced socket controls ](https://docs.microsoft.com/previous-versions/windows/apps/jj150598(v=win.10)), [StreamSocketListener](streamsocketlistener.md), [StreamSocketListener.Information](streamsocketlistener_information.md), [Bluetooth Rfcomm Chat sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Bluetooth%20Rfcomm%20Chat), [ControlChannelTrigger StreamSocket sample](https://go.microsoft.com/fwlink/p/?linkid=243039), [Proximity sample](https://go.microsoft.com/fwlink/p/?linkid=245082), [StreamSocket sample](https://go.microsoft.com/fwlink/p/?linkid=243037)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
