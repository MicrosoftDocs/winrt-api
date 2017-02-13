---
-api-id: P:Windows.Devices.Input.MouseCapabilities.NumberOfButtons
-api-type: winrt property
---

<!-- Property syntax
public uint NumberOfButtons { get; }
-->

# Windows.Devices.Input.MouseCapabilities.NumberOfButtons

## -description
Gets a value representing the number of buttons on the mouse. If multiple mice are present, it returns the number of buttons of the mouse which has maximum number of buttons.

## -property-value
A value representing the number of buttons on the mouse. If multiple mice are present, it returns the number of buttons of the mouse which has maximum number of buttons.

## -remarks

## -examples
The following code shows how to use this method.

```html
    function getMouseCapabilities() {
        var mouseCapabilities = new Windows.Devices.Input.MouseCapabilities();
        id("numberOfButtons").innerHTML = mouseCapabilities.NumberOfButtons;
    }
```



## -see-also
[Quickstart: Identifying input devices](http://msdn.microsoft.com/library/7001b56d-081b-4683-84bb-24c361397c08)