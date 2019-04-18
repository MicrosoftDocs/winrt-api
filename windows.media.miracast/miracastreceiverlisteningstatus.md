---
-api-id: T:Windows.Media.Miracast.MiracastReceiverListeningStatus
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum MiracastReceiverListeningStatus : int 
-->

# Windows.Media.Miracast.MiracastReceiverListeningStatus

## -description

Describes the status of the Miracast Receiver as it pertains to its ability to listen for incoming conections.

## -enum-fields
### -field TemporarilyDisabled:5

The Miracast Receiver is temporarily disabled while other network activity is in progress.

### -field NotListening:0

The Miracast Receiver is not currently listening for incoming connections.

### -field Listening:1

The Miracast Receiver is listening for incoming connections.

### -field DisabledByPolicy:4

The Miracast Receiver has been disabled by administrative policy.

### -field ConnectionPending:2

The Miracast Receiver has received an incoming connection and is waiting for the app to accept or reject the connection.

### -field Connected:3

At least one Miracast Transmitter is currently connected.

## -remarks

Attempting to use the PC as a Miracast Transmitter will cause the Miracast Receiver on the same PC, if enabled, to enter TemporarilyDisabled state. The Miracast Receiver will revert to its previous state once the PC is no longer transmitting.
If the MiracastReceiverListeningStatus is Connected or ConnectionPending, the Miracast Receiver may also be listening for additional connections, if the Wi-Fi hardware supports multiple simulatenous connections, and if that functionality has been enabled.

## -see-also

## -examples

