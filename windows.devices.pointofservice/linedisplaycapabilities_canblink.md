---
-api-id: P:Windows.Devices.PointOfService.LineDisplayCapabilities.CanBlink
-api-type: winrt property
---

<!-- Property syntax.
public LineDisplayTextAttributeGranularity CanBlink { get; }
-->

# Windows.Devices.PointOfService.LineDisplayCapabilities.CanBlink

## -description
Indicates whether the line display supports blinking.

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

+ NotSupported: the device does not support blinking
+ EntireDisplay: the device supports blinking of the entire display
+ PerCharacter: the device supports blinking of individual characters

## -remarks

## -see-also

## -examples
