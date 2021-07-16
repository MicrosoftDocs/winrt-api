---
-api-id: P:Windows.Media.Miracast.MiracastReceiverSession.AllowConnectionTakeover
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool AllowConnectionTakeover { get;  set; }
-->

# Windows.Media.Miracast.MiracastReceiverSession.AllowConnectionTakeover

## -description

Specifies if the app allows a new connection to take over an in-progress Miracast Connection.

## -property-value

True if the app allows a new connection is allowed to take over an in-progress connection.

## -remarks

When a connection is taken over, the old connection is automatically disconnected and [MiracastReceiverSession.Disconnected](miracastreceiversession_disconnected.md) event will be raised for the old connection, and [MiracastReceiverSession.ConnectionCreated](miracastreceiversession_connectioncreated.md) will be raised for the new connection.

The app must set this property before invoking the [MiracastReceiverSession.Start](miracastreceiversession_start_1587696324.md) or [MiracastReceiverSession.StartAsync](miracastreceiversession_startasync_1931900819.md) method in order for the setting to take effect.

If the Wi-Fi hardware does not support multiple simultaneous connections, it will not be possible for a new connection to take over an in-progress connection. Use [MiracastReceiverStatus.IsConnectionTakeoverSupported](miracastreceiverstatus_isconnectiontakeoversupported.md) to check if connection take-over is possible.

## -see-also

## -examples

