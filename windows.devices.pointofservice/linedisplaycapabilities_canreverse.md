---
-api-id: P:Windows.Devices.PointOfService.LineDisplayCapabilities.CanReverse
-api-type: winrt property
---

<!-- Property syntax.
public LineDisplayTextAttributeGranularity CanReverse { get; }
-->

# Windows.Devices.PointOfService.LineDisplayCapabilities.CanReverse

## -description
Indicates whether the line display supports reversing the video display.

## -property-value
This property can have one of the following values:

```CSharp
typedef enum LineDisplayTextAttributeGranularity
{
  NotSupported = 0,
  EntireDisplay,
  PerCharacter
} LineDisplayTextAttributeGranularity;
```

+ NotSupported: that the device does not support reversing the display
+ EntireDisplay: the device supports reversing the entire screen
+ PerCharacter: the device supports reversing each individual character

## -remarks

## -see-also

## -examples
