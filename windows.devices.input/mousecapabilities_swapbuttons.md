---
-api-id: P:Windows.Devices.Input.MouseCapabilities.SwapButtons
-api-type: winrt property
---

<!-- Property syntax
public int SwapButtons { get; }
-->

# Windows.Devices.Input.MouseCapabilities.SwapButtons

## -description
Gets a value indicating whether any of the mice connected to the computer has swapped left and right buttons.

## -property-value
A value indicating whether any of the mice connected to the computer has swapped left and right buttons.

## -remarks

## -examples
The following code shows how to use this method.

```html
    function getMouseCapabilities() {
        var mouseCapabilities = new Windows.Devices.Input.MouseCapabilities();
        id("swapButtons").innerHTML = mouseCapabilities.SwapButtons;
    }
```



## -see-also
[Quickstart: Identifying input devices](/windows/uwp/design/input/identify-input-devices)