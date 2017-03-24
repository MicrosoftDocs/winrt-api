---
-api-id: P:Windows.Devices.Bluetooth.Background.RfcommOutboundConnectionInformation.RemoteServiceId
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Devices.Bluetooth.Rfcomm.RfcommServiceId RemoteServiceId { get;  set; }
-->

# Windows.Devices.Bluetooth.Background.RfcommOutboundConnectionInformation.RemoteServiceId

## -description
Gets or sets the service UUID of the remote service to which the system will connect on behalf of the app.

## -property-value
The service UUID of the remote service to which the system will connect on behalf of the app. This value must be set. When the system creates outgoing connections for the app, it will connect to any remote service that lists the specified UUID in its ServiceClassIDList.

## -remarks

## -examples

## -see-also
