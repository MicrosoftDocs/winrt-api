---
-api-id: T:Windows.Devices.Sensors.ProximitySensorDisplayOnOffController
-api-type: winrt class
---

<!-- Class syntax.
public class ProximitySensorDisplayOnOffController : Windows.Foundation.IClosable
-->

# Windows.Devices.Sensors.ProximitySensorDisplayOnOffController

## -description
Provides a controller responsible for turning on or off the phone display based on the readings from the [ProximitySensor](proximitysensor.md).

## -remarks
This class will have no effect if your app is running on a platform that doesn't support a controller for the display state. For example, this class has no effect on applications running on a desktop because the desktop platform does not support a controller cycling the display.

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md)