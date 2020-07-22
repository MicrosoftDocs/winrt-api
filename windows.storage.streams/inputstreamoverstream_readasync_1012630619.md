---
-api-id: M:Windows.Storage.Streams.InputStreamOverStream.ReadAsync(Windows.Storage.Streams.IBuffer,System.UInt32,Windows.Storage.Streams.InputStreamOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Storage.Streams.IBuffer, uint> ReadAsync(Windows.Storage.Streams.IBuffer buffer, System.UInt32 count, Windows.Storage.Streams.InputStreamOptions options)
-->

# Windows.Storage.Streams.InputStreamOverStream.ReadAsync

## -description

Returns an asynchronous byte reader object.

## -parameters

### -param buffer

The buffer into which the asynchronous read operation places the bytes that are read.

### -param count

The number of bytes to read that is less than or equal to the [Capacity](ibuffer_capacity.md) value.

### -param options

Specifies the type of the asynchronous read operation.

## -returns

The asynchronous operation.

## -remarks

## -examples

See the code example in [ControlChannelTrigger with WebSockets](/windows/uwp/networking/network-communications-in-the-background#controlchanneltrigger-with-websockets).

## -see-also

[ControlChannelTrigger with WebSockets](/windows/uwp/networking/network-communications-in-the-background#controlchanneltrigger-with-websockets)
