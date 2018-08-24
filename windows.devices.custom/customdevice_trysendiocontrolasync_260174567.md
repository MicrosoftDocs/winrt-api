---
-api-id: M:Windows.Devices.Custom.CustomDevice.TrySendIOControlAsync(Windows.Devices.Custom.IIOControlCode,Windows.Storage.Streams.IBuffer,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TrySendIOControlAsync(Windows.Devices.Custom.IIOControlCode ioControlCode, Windows.Storage.Streams.IBuffer inputBuffer, Windows.Storage.Streams.IBuffer outputBuffer)
-->

# Windows.Devices.Custom.CustomDevice.TrySendIOControlAsync

## -description
Sends an IO control code. A return value indicates whether the operation succeeded.

## -parameters
### -param ioControlCode
The IO control code.

### -param inputBuffer
The input buffer.

### -param outputBuffer
The output buffer.

## -returns
**true** if the operation is successful; otherwise, **false**.

## -remarks
[TrySendIOControlAsync](customdevice_trysendiocontrolasync_260174567.md) is like [SendIOControlAsync](customdevice_sendiocontrolasync_1607685722.md), except this method doesn't throw an exception if the operation fails. Instead, it returns **false**. If you want to handle any exceptions that occur during the operation, use the [SendIOControlAsync](customdevice_sendiocontrolasync_1607685722.md) method.

## -examples

## -see-also
