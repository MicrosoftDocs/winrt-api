---
-api-id: T:Windows.Devices.Lights.Lamp
-api-type: winrt class
---

<!-- Class syntax.
public class Lamp : Windows.Devices.Lights.ILamp, Windows.Foundation.IClosable
-->

# Windows.Devices.Lights.Lamp

## -description
Represents a lamp device.

## -remarks
A common scenario for using this class is adding a flashlight feature to your app that allows the user to manually turn on and off a device's camera torch light, if one is available.

The underlying device that this Lamp API represents is often shared with the device's camera flash and video light. 
If the Lamp is shared device, the camera use cases have priority over the underlying lamp device. 
Thus, simultaneous camera usage will result [AvailabilityChanged](lamp_availabilitychanged.md) event to be fired for the corresponding Lamp device, and reporting the device being unavailable.

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md)