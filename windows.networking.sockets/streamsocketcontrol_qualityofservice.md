---
-api-id: P:Windows.Networking.Sockets.StreamSocketControl.QualityOfService
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.SocketQualityOfService QualityOfService { get;  set; }
-->

# Windows.Networking.Sockets.StreamSocketControl.QualityOfService

## -description
The quality of service on a [StreamSocket](streamsocket.md) object.

## -property-value
The quality of service on a [StreamSocket](streamsocket.md) object.

## -remarks
This property indicates the quality of service that [StreamSocket](streamsocket.md) object should provide. The default value is **normal**.

When the property is set to a value other than **normal**, the socket will follow a policy to provide the specified quality of service. When the property is set to **lowLatency**, the priority of the thread that handles read completions is increased. The **lowLatency** value would commonly be used for audio or similar apps that are timing sensitive. This property is not normally set for other apps.

This property may be set before the [StreamSocket](streamsocket.md) is connected. After the [StreamSocket](streamsocket.md) is connected, setting this property will result in an error.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
