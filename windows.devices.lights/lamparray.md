---
-api-id: T:Windows.Devices.Lights.LampArray
-api-type: winrt class
---

<!-- Class syntax.
public class LampArray 
-->

# Windows.Devices.Lights.LampArray

## -description
Represents a LampArray device attached the system.  Currently, only HID LampArrays are supported.

LampArray devices have one or more lamp indexes (e.g. lights/LEDs/bulbs, etc…) whose color state can be directly manipulated.  Static information (retrieved from the device) describe supported colors, geometric positions and intended purposes for each lamp index.

These devices can be found as part of composite devices (e.g. keyboard with RGB lighting) or as standalone.

An application can set lamp state at any time, but state will only be applied by the system while application is in focus.

## -remarks
LampArrays are enumerated by [DeviceWatcher](../windows.devices.enumeration/devicewatcher.md), and the retrieved via [FromIdAsync](lamparray_fromidasync_1322863552.md).

## -see-also
[Lighting and Illumination](http://www.usb.org/developers/hidpage/HUTRR84_-_Lighting_and_Illumination_Page.pdf) USB HID review request.

## -examples