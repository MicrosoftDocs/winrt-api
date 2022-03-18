---
-api-id: P:Windows.Networking.Sockets.DatagramSocketControl.QualityOfService
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.SocketQualityOfService QualityOfService { get;  set; }
-->

# Windows.Networking.Sockets.DatagramSocketControl.QualityOfService

## -description
Gets or sets the quality of service on a [DatagramSocket](datagramsocket.md) object.

## -property-value
The quality of service on a [DatagramSocket](datagramsocket.md) object. The default is **normal**.

## -remarks
This QualityOfService property is the quality of service that [DatagramSocket](datagramsocket.md) object should provide. The default value is **normal**.

When the property is set to a value other than **normal**, the socket will follow a policy to provide the specified quality of service. When the property is set to **lowLatency**, this sets the thread priority of the incoming packets to a higher value. The **lowLatency** value would commonly be used for audio or similar apps that are timing sensitive. This property is not normally set for other apps.

This property may be set before the [DatagramSocket](datagramsocket.md) is bound or connected. After the [DatagramSocket](datagramsocket.md) is bound or connected, setting this property will result in an error.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [DatagramSocket](datagramsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
