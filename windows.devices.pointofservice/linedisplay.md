---
-api-id: T:Windows.Devices.PointOfService.LineDisplay
-api-type: winrt class
---

<!-- Class syntax.
public class LineDisplay : IClosable
-->

# Windows.Devices.PointOfService.LineDisplay

## -description
Represents a line display device.

## -remarks
This object is created when a [GetDefaultAsync](linedisplay_getdefaultasync.md) or [FromIdAsync](linedisplay_fromidasync.md) method completes. Unlike other peripherals, the EnableAsync() method has been removed for line displays; Instead, the device is implicitly enabled whenever commands are sent that require the line display to be in an enabled state.

## -see-also

## -examples
