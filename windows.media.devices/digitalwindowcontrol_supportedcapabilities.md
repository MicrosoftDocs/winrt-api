---
-api-id: P:Windows.Media.Devices.DigitalWindowControl.SupportedCapabilities
-api-type: winrt property
---

# Windows.Media.Devices.DigitalWindowControl.SupportedCapabilities

<!--
public System.Collections.Generic.IReadOnlyList<Windows.Media.Devices.DigitalWindowCapability> SupportedCapabilities { get; }
-->


## -description

Gets a read-only list of [DigitalWindowCapability](digitalwindowcapability.md) objects describing the capabilities of the capture device.

## -property-value

A read-only list of [DigitalWindowCapability](digitalwindowcapability.md) objects.

## -remarks

The digital window capabilities of the capture device may vary depending on the resolution at which frames are captured. The **DigitalWindowCapability** objects returned by this method specify the width and height for which the capabilities are supported. To get the capabilities for a specific resolution, call [DigitalWindowControl.GetCapabilityForSize](digitalwindowcontrol_getcapabilityforsize_1381309850.md).

## -see-also

## -examples


