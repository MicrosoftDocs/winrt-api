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
| 1511 | 10586 | TryRespondAsync(IBuffer,Nullable<UInt32>) |
| 1511 | 10586 | TryRespondWithCryptogramsAsync(IBuffer,IEnumerable<SmartCardCryptogramPlacementStep>) |
| 1511 | 10586 | TryRespondWithCryptogramsAsync(IBuffer,IEnumerable<SmartCardCryptogramPlacementStep>,Nullable<UInt32>) |

## -examples

## -see-also
[Create an NFC Smart Card app](https://docs.microsoft.com/windows/uwp/devices-sensors/host-card-emulation)
