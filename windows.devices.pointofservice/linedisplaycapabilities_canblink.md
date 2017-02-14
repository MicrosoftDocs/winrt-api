---
-api-id: P:Windows.Devices.PointOfService.LineDisplayCapabilities.CanBlink
-api-type: winrt property
---

<!-- Property syntax.
public LineDisplayTextAttributeGranularity CanBlink { get; }
-->

# Windows.Devices.PointOfService.LineDisplayCapabilities.CanBlink

## -description
Gets whether

## -property-value
This read-only property describes if the device supports blinking of either each individual displayed character or of the entire screen. The property can have one of the following values:

```CSharp
typedef enum LineDisplayTextAttributeGranularity
{
  NotSupported = 0,
  EntireDisplay,
  PerCharacter
} LineDisplayTextAttributeGranularity;
```

A value of NotSupported means that the device does not support blinking.

## -remarks

## -see-also

## -examples
