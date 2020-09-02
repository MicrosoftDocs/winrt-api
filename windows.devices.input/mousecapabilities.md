---
-api-id: T:Windows.Devices.Input.MouseCapabilities
-api-type: winrt class
---

<!-- Class syntax.
public class MouseCapabilities : Windows.Devices.Input.IMouseCapabilities
-->

# Windows.Devices.Input.MouseCapabilities

## -description

Supports the ability to determine the capabilities of any connected mouse devices.

## -remarks

The values returned by the properties discussed here are based on the total number of mice connected: Boolean properties return true if one mouse supports a specific capability and numeric properties return the maximum value exposed by all mice.

The [Device Capabilities Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Device%20capabilities%20sample) demonstrates how to detect the presence of input devices and retrieve the capabilities and attributes of each device.

## -examples

## -see-also

[Windows.Devices.Input](windows_devices_input.md), [Quickstart: Identifying input devices](/windows/uwp/design/input/identify-input-devices), [Basic input sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BasicInput)
