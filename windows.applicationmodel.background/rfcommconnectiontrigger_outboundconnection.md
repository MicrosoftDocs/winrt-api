---
-api-id: P:Windows.ApplicationModel.Background.RfcommConnectionTrigger.OutboundConnection
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Bluetooth.Background.RfcommOutboundConnectionInformation OutboundConnection { get; }
-->

# Windows.ApplicationModel.Background.RfcommConnectionTrigger.OutboundConnection

## -description
Gets or sets the [RfcommOutboundConnectionInformation](../windows.devices.bluetooth.background/rfcommoutboundconnectioninformation.md) object that describes how the system will create outgoing connections on behalf of the app.

## -property-value
The [RfcommOutboundConnectionInformation](../windows.devices.bluetooth.background/rfcommoutboundconnectioninformation.md) object that describes how the system will create outgoing connections on behalf of the app. The default is null.

## -remarks
If this property is null, the system will not create outgoing connections.

At least one of the [InboundConnection](rfcommconnectiontrigger_inboundconnection.md) and OutboundConnection properties must be non-null.

## -examples

## -see-also
