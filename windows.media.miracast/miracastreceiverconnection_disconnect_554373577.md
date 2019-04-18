---
-api-id: M:Windows.Media.Miracast.MiracastReceiverConnection.Disconnect(Windows.Media.Miracast.MiracastReceiverDisconnectReason,System.String)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void MiracastReceiverConnection.Disconnect(MiracastReceiverDisconnectReason reason, String message)
-->

# Windows.Media.Miracast.MiracastReceiverConnection.Disconnect

## -description

Closes the connection and immediately disconnects the connected [MiracastTransmitter](miracasttransmitter.md).

## -parameters
### -param reason

A value from the [MiracastReceiverDisconnectReason](miracastreceiverdisconnectreason.md) enumeration specifying the reason for disconnecting the Miracast Transmitter.

### -param message

A human-readable message, stating a reason for disconnecting the Miracast Transmitter.

## -remarks

The value of the message parameter is not necessarily displayed to the user but can assist in analyzing the cause of session disconnect.

## -see-also

[Disconnect](miracastreceiverconnection_disconnect_1844911223.md),
[MiracastTransmitter](miracasttransmitter.md)

## -examples

