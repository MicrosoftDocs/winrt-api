---
-api-id: P:Windows.ApplicationModel.Background.RfcommConnectionTrigger.InboundConnection
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Bluetooth.Background.RfcommInboundConnectionInformation InboundConnection { get; }
-->

# Windows.ApplicationModel.Background.RfcommConnectionTrigger.InboundConnection

## -description
Gets or sets the [RfcommInboundConnectionInformation](../windows.devices.bluetooth.background/rfcomminboundconnectioninformation.md) object that describes how the system will advertise and listen for inbound connections on behalf of the app.

## -property-value
The [RfcommInboundConnectionInformation](../windows.devices.bluetooth.background/rfcomminboundconnectioninformation.md) object that describes how the system will advertise and listen for inbound connections on behalf of the app. The default is null.

## -remarks
If this property is null, the system will not listen for incoming connections.

At least one of the [InboundConnection](rfcommconnectiontrigger_inboundconnection.md) and [OutboundConnection](rfcommconnectiontrigger_outboundconnection.md) properties must be non-null.

## -examples

## -see-also
