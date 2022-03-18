---
-api-id: M:Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs.TryRespondWithCryptogramsAsync(Windows.Storage.Streams.IBuffer,Windows.Foundation.Collections.IIterable{Windows.Devices.SmartCards.SmartCardCryptogramPlacementStep},Windows.Foundation.IReference{System.UInt32})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.SmartCards.SmartCardCryptogramGeneratorOperationStatus> TryRespondWithCryptogramsAsync(Windows.Storage.Streams.IBuffer responseTemplate, Windows.Foundation.Collections.IIterable<Windows.Devices.SmartCards.SmartCardCryptogramPlacementStep> cryptogramPlacementSteps, Windows.Foundation.IReference<System.UInt32> nextState)
-->

# Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs.TryRespondWithCryptogramsAsync

## -description
Returns an asynchronous operation that completes with an operation status.

## -parameters
### -param responseTemplate
A buffer that contains a template response.

### -param cryptogramPlacementSteps
A collection that contains the cryptogram steps.

### -param nextState
A reference that contains the next state.

## -returns
Returns an asynchronous operation that completes with an operation status.

## -remarks

## -examples

## -see-also
[TryRespondWithCryptogramsAsync(IBuffer, IIterable(SmartCardCryptogramPlacementStep))](smartcardemulatorapdureceivedeventargs_tryrespondwithcryptogramsasync_340048536.md), [Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
