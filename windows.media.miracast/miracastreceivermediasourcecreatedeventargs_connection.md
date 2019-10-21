---
-api-id: P:Windows.Media.Miracast.MiracastReceiverMediaSourceCreatedEventArgs.Connection
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public MiracastReceiverConnection Connection { get; }
-->

# Windows.Media.Miracast.MiracastReceiverMediaSourceCreatedEventArgs.Connection

## -description

Returns the [MiracastReceiverConnection](miracastreceiverconnection.md) object of the associated connection.

## -property-value

The MiracastReceiverConnection object.

## -remarks

Since a [MiracastReceiverSession](miracastreceiversession.md) can operate on multiple connections, use the Connection property to determine which connection the event refers to.

## -see-also

[MiracastReceiverConnection](miracastreceiverconnection.md),
[MiracastReceiverSession](miracastreceiversession.md)

## -examples

