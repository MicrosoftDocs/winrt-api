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

The [Device Capabilities Sample](http://go.microsoft.com/fwlink/p/?linkid=231530) demonstrates how to detect the presence of input devices and retrieve the capabilities and attributes of each device.

## -examples

## -see-also
[Windows.Devices.Input](windows_devices_input.md), [Quickstart: Identifying input devices](http://msdn.microsoft.com/library/7001b56d-081b-4683-84bb-24c361397c08), [Basic input sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620514)