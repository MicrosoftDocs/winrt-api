---
-api-id: T:Windows.Media.Miracast.MiracastReceiverSessionStartStatus
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum MiracastReceiverSessionStartStatus : int 
-->

# Windows.Media.Miracast.MiracastReceiverSessionStartStatus

## -description

The status of a [Start](miracastreceiversession_start_1587696324.md) or [StartAsync](miracastreceiversession_startasync_1931900819.md) operation.

## -enum-fields
### -field UnknownFailure:1

The Miracast Receiver Session could not be started due an unknown error.

### -field Success:0

The Miracast Receiver started successfully.

### -field MiracastNotSupported:2

The Miracast Receiver Session cannot start because Miracast is not supported on the current device.

### -field AccessDenied:3

The app is not allowed to start a Miracast Receiver Session.

## -remarks

Store apps must declare the PrivateNetworkClientServer capability in their manifest in order to be allowed to start a Miracast Receiver Session. If the capability is missing, it results in an AccessDenied error.

Use [MiracastReceiverStatus.ListeningStatus](miracastreceiverstatus_listeningstatus.md) to determine if the Miracast Receiver is actually listening for incoming connections, as starting a MiracastReceiverSession does not guarantee that the Miracast Receiver is listening for connections.

## -see-also

[Start](miracastreceiversession_start_1587696324.md),
[StartAsync](miracastreceiversession_startasync_1931900819.md)

## -examples

