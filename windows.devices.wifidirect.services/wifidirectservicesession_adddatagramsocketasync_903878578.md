---
-api-id: M:Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSession.AddDatagramSocketAsync(Windows.Networking.Sockets.DatagramSocket)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction AddDatagramSocketAsync(Windows.Networking.Sockets.DatagramSocket value)
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSession.AddDatagramSocketAsync

## -description
Adds a [DatagramSocket](../windows.networking.sockets/datagramsocket.md) to the session. Your code creates the DatagramSocket before calling this method. Associating a socket to the session causes port information to be sent to the remote device(s) in the session. (In terms of this API, a [RemotePortAdded](wifidirectservicesession_remoteportadded.md) event is raised on each remote device in the session, specifying the UDP protocol.) A remote device can use that information to open a socket and connect back to the local machine.

## -parameters
### -param value
The DatagramSocket instance to associate with this session.

## -returns
An asynchronous association action. Returns on successful completion of the association.

## -remarks

## -examples

## -see-also
