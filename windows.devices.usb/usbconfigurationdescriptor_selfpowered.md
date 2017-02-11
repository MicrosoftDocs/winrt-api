---
-api-id: P:Windows.Devices.Usb.UsbConfigurationDescriptor.SelfPowered
-api-type: winrt property
---

<!-- Property syntax
public bool SelfPowered { get; }
-->

# Windows.Devices.Usb.UsbConfigurationDescriptor.SelfPowered

## -description
Gets the D6 bit of the **bmAttributes** field in the USB configuration. This value indicates whether the device is drawing power from a local source or the bus.

## -property-value
True, if the device is drawing power from a local source; false indicates that the device is only drawing power from the bus.

## -remarks
If **SelfPowered** is true, the device is drawing power from a local source, and also some power from the bus. Get the **MaxPowerMilliamps** property value to determine the amount of power the device is drawing from the bus.

## -examples

## -see-also
