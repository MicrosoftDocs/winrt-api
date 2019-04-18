---
-api-id: P:Windows.Media.Miracast.MiracastReceiverConnectionCreatedEventArgs.Connection
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public MiracastReceiverConnection Connection { get; }
-->

# Windows.Media.Miracast.MiracastReceiverConnectionCreatedEventArgs.Connection

## -description

Gets the [MiracastReceiverConnection](miracastreceiverconnection.md) object of the newly created connection.

## -property-value

The **MiracastReceiverConnection** object.

## -remarks

The new connection is considered accepted when the event handler returns, or when the deferral is completed. To reject an unwanted connection, invoke [MiracastReceiverConnection.Disconnect](miracastreceiverconnection_disconnect_554373577.md).

## -see-also

[MiracastReceiverConnection](miracastreceiverconnection.md),
[MiracastReceiverConnection.Disconnect](miracastreceiverconnection_disconnect_554373577.md)

## -examples

