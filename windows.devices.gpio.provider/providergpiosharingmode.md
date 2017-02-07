---
-api-id: T:Windows.Devices.Gpio.Provider.ProviderGpioSharingMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Gpio.Provider.ProviderGpioSharingMode : int
-->

# ProviderGpioSharingMode

## -description
Describes the modes in which you can open a general-purpose I/O (GPIO) pin. These modes determine whether other connections to the GPIO pin can be opened while you have the pin open.

## -enum-fields
### -field Exclusive:0
Opens the GPIO pin exclusively, so that no other connection to the pin can be opened.

### -field SharedReadOnly:1
Opens the GPIO pin as shared, so that other connections in **SharedReadOnly** mode to the pin can be opened. Only operations that do not change the state of the pin can be performed.


## -remarks

## -examples

## -see-also
[GpioSharingMode](../windows.devices.gpio/gpiosharingmode.md)