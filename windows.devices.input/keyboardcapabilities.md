---
-api-id: T:Windows.Devices.Input.KeyboardCapabilities
-api-type: winrt class
---

<!-- Class syntax.
public class KeyboardCapabilities : Windows.Devices.Input.IKeyboardCapabilities
-->

# Windows.Devices.Input.KeyboardCapabilities

## -description

Provides the ability to determine the capabilities of any connected hardware keyboards.

## -remarks

The [Device Capabilities Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Device%20capabilities%20sample) demonstrates how to detect the presence of input devices and retrieve the capabilities and attributes of each device.

The following code shows how to create an instance of this class and use it to determine if a keyboard is present.

```javascript
function getKeyboardCapabilities() {
  var keyboardCapabilities = new Windows.Devices.Input.KeyboardCapabilities();
  id("keyboardPresent").innerHTML = keyboardCapabilities.keyboardPresent;
}

```

## -examples

## -see-also

[Identify input devices](/windows/uwp/design/input/identify-input-devices), [Basic input sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BasicInput)
