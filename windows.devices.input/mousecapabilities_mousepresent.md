---
-api-id: P:Windows.Devices.Input.MouseCapabilities.MousePresent
-api-type: winrt property
---

<!-- Property syntax
public int MousePresent { get; }
-->

# Windows.Devices.Input.MouseCapabilities.MousePresent

## -description
Gets a value that indicates whether a mouse device is detected.

## -property-value
The number of mouse devices detected. Typically 0 or 1.

## -remarks

## -examples
The following code shows how to use this method.

```html
    function getMouseCapabilities() {
        var mouseCapabilities = new Windows.Devices.Input.MouseCapabilities();
        id("mousePresent").innerHTML = mouseCapabilities.MousePresent;
    }
```



## -see-also
[Quickstart: Identifying input devices](/windows/uwp/design/input/identify-input-devices)