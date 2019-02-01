---
-api-id: T:Windows.Devices.Input.KeyboardCapabilities
-api-type: winrt class
---

<!-- Class syntax.
public class KeyboardCapabilities : Windows.Devices.Input.IKeyboardCapabilities
-->

# Windows.Devices.Input.KeyboardCapabilities

## -description

Supports the ability to determine the capabilities of any connected hardware keyboards.

## -remarks

The [Device Capabilities Sample](https://go.microsoft.com/fwlink/p/?linkid=231530) demonstrates how to detect the presence of input devices and retrieve the capabilities and attributes of each device.

The following code shows how to create an instance of this class, and use it to determine if a keyboard is present.

```javascript
function getKeyboardCapabilities() {
  var keyboardCapabilities = new Windows.Devices.Input.KeyboardCapabilities();
  id("keyboardPresent").innerHTML = keyboardCapabilities.keyboardPresent;
}

```

## -examples

## -see-also

[Identify input devices](https://docs.microsoft.com/windows/uwp/design/input/identify-input-devices), [Basic input sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620514)
