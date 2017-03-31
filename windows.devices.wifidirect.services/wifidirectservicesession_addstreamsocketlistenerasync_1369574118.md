---
-api-id: M:Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSession.AddStreamSocketListenerAsync(Windows.Networking.Sockets.StreamSocketListener)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction AddStreamSocketListenerAsync(Windows.Networking.Sockets.StreamSocketListener value)
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSession.AddStreamSocketListenerAsync

## -description
Adds a [StreamSocketListener](../windows.networking.sockets/streamsocketlistener.md) to the session. Your code creates the StreamSocketListener before calling this method. Associating a socket to the session causes port information to be sent to the remote device(s) in the session. (In terms of this API, a [RemotePortAdded](wifidirectservicesession_remoteportadded.md) event is raised on each remote device in the session, specifying the TCP protocol.) A remote device can use that information to open a socket and connect back to the local machine.

## -parameters
### -param value
The StreamSocketListener instance to be associated with the session.

## -returns
An asynchronous association action. Returns on successful completion of the association.

## -remarks

## -examples

## -see-also
