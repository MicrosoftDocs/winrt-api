---
-api-id: P:Windows.Devices.Input.MouseCapabilities.HorizontalWheelPresent
-api-type: winrt property
---

<!-- Property syntax
public int HorizontalWheelPresent { get; }
-->

# Windows.Devices.Input.MouseCapabilities.HorizontalWheelPresent

## -description
Gets a value indicating whether any of the mice connected to the computer have a scroll wheel that tilts left and right (usually for horizontal scrolling).

## -property-value
The number of horizontal wheels detected. Typically 0 or 1.

## -remarks


## -examples
The following code shows how to use this method.

```html
    function getMouseCapabilities() {
        var mouseCapabilities = new Windows.Devices.Input.MouseCapabilities();
        id("horizontalWheelPresent").innerHTML = mouseCapabilities.HorizontalWheelPresent;
    }
```



## -see-also
[Quickstart: Identifying input devices](/windows/uwp/design/input/identify-input-devices)