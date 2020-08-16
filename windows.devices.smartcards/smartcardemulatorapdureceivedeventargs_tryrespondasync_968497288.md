---
-api-id: M:Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs.TryRespondAsync(Windows.Storage.Streams.IBuffer,Windows.Foundation.IReference{System.UInt32})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryRespondAsync(Windows.Storage.Streams.IBuffer responseApdu, Windows.Foundation.IReference<System.UInt32> nextState)
-->

# Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs.TryRespondAsync

## -description
Attempts to respond to an APDU.

## -parameters
### -param responseApdu
A buffer containing the response.

### -param nextState
A reference containing the next state.

## -returns
Returns an asynchronous operation that returns a boolean when the operation completes. The boolean is true if the operation completed successfully and false otherwise.

## -remarks

## -examples

## -see-also
[TryRespondAsync(IBuffer)](smartcardemulatorapdureceivedeventargs_tryrespondasync_1062726120.md), [Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
