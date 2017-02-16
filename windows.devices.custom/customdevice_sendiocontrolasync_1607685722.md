---
-api-id: M:Windows.Devices.Custom.CustomDevice.SendIOControlAsync(Windows.Devices.Custom.IIOControlCode,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<uint> SendIOControlAsync(Windows.Devices.Custom.IIOControlCode ioControlCode, Windows.Storage.Streams.IBuffer inputBuffer, Windows.Storage.Streams.IBuffer outputBuffer)
-->

# Windows.Devices.Custom.CustomDevice.SendIOControlAsync

## -description
Sends an IO control code.

## -parameters
### -param ioControlCode
The IO control code.

### -param inputBuffer
The input buffer.

### -param outputBuffer
The output buffer.

## -returns
The result of the async operation.

## -remarks
[SendIOControlAsync](customdevice_sendiocontrolasync.md) is like [TrySendIOControlAsync](customdevice_trysendiocontrolasync.md), except this method throws an exception if the operation fails. If you want to handle any exceptions that occur during the operation, use the [SendIOControlAsync](customdevice_sendiocontrolasync.md) method. If you just want to be notified whether the operation is successful, but not handle any specific exceptions, use [TrySendIOControlAsync](customdevice_trysendiocontrolasync.md).

## -examples

## -see-also
