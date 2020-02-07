---
-api-id: M:Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs.TryRespondAsync(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryRespondAsync(Windows.Storage.Streams.IBuffer responseApdu)
-->

# Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs.TryRespondAsync

## -description
Attempts to respond to an APDU.

## -parameters
### -param responseApdu
A buffer containing the response.

## -returns
Returns an asynchronous operation that returns a boolean when the operation completes indicating. The boolean will be true if the operation was successful and false otherwise.

## -remarks

## -examples

## -see-also
[TryRespondAsync(IBuffer, IReference(UInt32))](smartcardemulatorapdureceivedeventargs_tryrespondasync_968497288.md), [Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
