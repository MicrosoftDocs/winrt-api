---
-api-id: M:Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs.TryRespondWithCryptogramsAsync(Windows.Storage.Streams.IBuffer,Windows.Foundation.Collections.IIterable{Windows.Devices.SmartCards.SmartCardCryptogramPlacementStep})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.SmartCards.SmartCardCryptogramGeneratorOperationStatus> TryRespondWithCryptogramsAsync(Windows.Storage.Streams.IBuffer responseTemplate, Windows.Foundation.Collections.IIterable<Windows.Devices.SmartCards.SmartCardCryptogramPlacementStep> cryptogramPlacementSteps)
-->

# Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs.TryRespondWithCryptogramsAsync

## -description
Attempts to respond to an APDU, placing cryptograms in the outgoing message as instructed by the placement steps.

## -parameters
### -param responseTemplate
A buffer containing a template response.

### -param cryptogramPlacementSteps
A collection that contains the cryptogram steps.

## -returns
Returns an asynchronous operation that completes with an operation status.

## -remarks

## -examples

## -see-also
[TryRespondWithCryptogramsAsync(IBuffer, IIterable(SmartCardCryptogramPlacementStep), IReference(UInt32))](smartcardemulatorapdureceivedeventargs_tryrespondwithcryptogramsasync_429873224.md), [Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
