---
-api-id: T:Windows.Networking.BackgroundTransfer.BackgroundTransferStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.BackgroundTransfer.BackgroundTransferStatus : int
-->

# BackgroundTransferStatus

## -description
Defines transfer operation status values.

## -enum-fields
### -field Idle:0
The application is idle.

### -field Running:1
The transfer is currently in progress.

### -field PausedByApplication:2
The application has paused the transfer operation.

### -field PausedCostedNetwork:3
The transfer operation is paused due to cost policy (for example, transitioned to a costed network).

### -field PausedNoNetwork:4
The transfer operation is paused due to a lack of network connectivity.

### -field Completed:5
The transfer operation has completed.

### -field Canceled:6
The transfer operation has been cancelled.

### -field Error:7
An error was encountered during the transfer operation.

### -field PausedSystemPolicy:32
The transfer is paused by the system due to resource constraints. Examples of constraints include the system being on Battery Saver when the application is not in the foreground. In Windows Phone, transfers will have this status if Battery Saver is activated, if the background task can't get enough memory, CPU, power resources to run, or if the network condition is 2G and the app is not in the foreground

### -field PausedRecoverableWebErrorStatus:8
One of the app-configured recoverable web error statuses ([RecoverableWebErrorStatuses](downloadoperation_recoverableweberrorstatuses.md)). 

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | PausedRecoverableWebErrorStatus |

## -examples

## -see-also
[RecoverableWebErrorStatuses](downloadoperation_recoverableweberrorstatuses.md)
