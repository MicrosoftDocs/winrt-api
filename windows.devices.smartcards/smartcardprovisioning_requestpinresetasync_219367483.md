---
-api-id: M:Windows.Devices.SmartCards.SmartCardProvisioning.RequestPinResetAsync(Windows.Devices.SmartCards.SmartCardPinResetHandler)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestPinResetAsync(Windows.Devices.SmartCards.SmartCardPinResetHandler handler)
-->

# Windows.Devices.SmartCards.SmartCardProvisioning.RequestPinResetAsync

## -description
Resets a smart card's personal identification number (PIN).

## -parameters
### -param handler
The method that handles the smart card PIN reset.

## -returns
After the smart card PIN reset attempt completes, returns true if the smart card's PIN was successfully reset; otherwise false.

## -remarks
When this method is called, it displays a UI to get the PIN from the user.

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
