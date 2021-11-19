---
-api-id: T:Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SmartCardEmulatorApduReceivedEventArgs : Windows.Devices.SmartCards.ISmartCardEmulatorApduReceivedEventArgs, Windows.Devices.SmartCards.ISmartCardEmulatorApduReceivedEventArgs2, Windows.Devices.SmartCards.ISmartCardEmulatorApduReceivedEventArgsWithCryptograms
-->

# Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs

## -description
Provides data for the [ApduReceived](smartcardemulator_apdureceived.md) event.

## -remarks
The system generates an instance of this class and passes it as an argument to the application's [ApduReceived](smartcardemulator_apdureceived.md) event handler.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | State |
| 1511 | 10586 | TryRespondAsync(IBuffer,Nullable&lt;UInt32&gt;) |
| 1511 | 10586 | TryRespondWithCryptogramsAsync(IBuffer,IEnumerable&lt;SmartCardCryptogramPlacementStep&gt;) |
| 1511 | 10586 | TryRespondWithCryptogramsAsync(IBuffer,IEnumerable&lt;SmartCardCryptogramPlacementStep&gt;,Nullable&lt;UInt32&gt;)

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
