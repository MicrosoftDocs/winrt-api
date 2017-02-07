---
-api-id: T:Windows.Devices.Input.PointerDeviceType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Input.PointerDeviceType : int
-->

# PointerDeviceType

## -description
Enumerates pointer device types.

## -enum-fields
### -field Touch:0
A touch-enabled device

### -field Pen:1
Pen

### -field Mouse:2
Mouse


## -remarks

## -examples
The following example shows how to use the [PointerDeviceType](pointerdevicetype.md) enumeration.

```html
    function getPointerDeviceType(pdt)
    {
        switch(pdt)
        {
            case Windows.Devices.Input.PointerDeviceType.touch:
                return "Touch";

            case Windows.Devices.Input.PointerDeviceType.pen:
                return "Pen";

            case Windows.Devices.Input.PointerDeviceType.mouse:
                return "Mouse";
        }
        return "Undefined";
    }
```



## -see-also