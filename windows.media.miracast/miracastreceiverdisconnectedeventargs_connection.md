---
-api-id: P:Windows.Media.Miracast.MiracastReceiverDisconnectedEventArgs.Connection
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public MiracastReceiverConnection Connection { get; }
-->

# Windows.Media.Miracast.MiracastReceiverDisconnectedEventArgs.Connection

## -description

Returns the [MiracastReceiverConnection](miracastreceiverconnection.md) object of the connection that has been disconnected.

## -property-value

The MiracastReceiverConnection object of the connection that has been disconnected.

## -remarks

Since a [MiracastReceiverSession](miracastreceiversession.md) can operate on multiple connections, use the Connection property to determine which connection the event refers to.

## -see-also

[MiracastReceiverConnection](miracastreceiverconnection.md),
[MiracastReceiverSession](miracastreceiversession.md)

## -examples

