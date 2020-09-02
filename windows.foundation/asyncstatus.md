---
-api-id: T:Windows.Foundation.AsyncStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.AsyncStatus : int
-->

# AsyncStatus

## -description
Specifies the status of an asynchronous operation.

## -enum-fields
### -field Canceled:2
The operation was canceled.

### -field Completed:1
The operation has completed.

### -field Error:3
The operation has encountered an error.

### -field Started:0
The operation has started.


## -remarks
This enumeration is used as a value for [IAsyncInfo.Status](iasyncinfo_status.md) (the basic status reporting mechanism for asynchronous operations) and also by specific operation implementations (for example [GetSmsDeviceOperation.Status](../windows.devices.sms/getsmsdeviceoperation_status.md)).

## -examples

## -see-also
[IAsyncInfo.Status](iasyncinfo_status.md), [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
