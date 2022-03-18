---
-api-id: P:Windows.Devices.Input.MouseCapabilities.VerticalWheelPresent
-api-type: winrt property
---

<!-- Property syntax
public int VerticalWheelPresent { get; }
-->

# Windows.Devices.Input.MouseCapabilities.VerticalWheelPresent

## -description
Gets a value indicating whether any of the mice connected to the computer have a scroll wheel that rolls up and down (usually for vertical scrolling).

## -property-value
The number of vertical wheels detected. Typically 0 or 1.

## -remarks

## -examples
The following code shows how to use this method.

```html
    function getMouseCapabilities() {
        var mouseCapabilities = new Windows.Devices.Input.MouseCapabilities();
        id("verticalWheelPresent").innerHTML = mouseCapabilities.VerticalWheelPresent;
    }
```



## -see-also
[Quickstart: Identifying input devices](/windows/uwp/design/input/identify-input-devices)