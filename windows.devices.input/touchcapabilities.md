---
-api-id: T:Windows.Devices.Input.TouchCapabilities
-api-type: winrt class
---

<!-- Class syntax.
public class TouchCapabilities : Windows.Devices.Input.ITouchCapabilities
-->

# Windows.Devices.Input.TouchCapabilities

## -description

Supports the ability to determine the touch capabilities of any connected touch digitizers.

## -remarks

The values returned by the properties discussed here are based on the total number of touch digitizers connected: Boolean properties return true if one digitizer supports a specific capability and numeric properties return the maximum value exposed by all digitizers.

The [Device Capabilities Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Device%20capabilities%20sample) demonstrates how to detect the presence of input devices and retrieve the capabilities and attributes of each device.

The following code shows how to use this class to determine touch capabilities.

```html
    function getTouchCapabilities() {
        var touchCapabilities = new Windows.Devices.Input.TouchCapabilities();
        id("contacts").innerHTML = touchCapabilities.Contacts;
    }
```

## -examples

## -see-also

[Windows.Devices.Input](windows_devices_input.md), [Quickstart: Identifying input devices](/windows/uwp/design/input/identify-input-devices), [Basic input sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BasicInput)
