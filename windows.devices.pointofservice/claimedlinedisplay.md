---
-api-id: T:Windows.Devices.PointOfService.ClaimedLineDisplay
-api-type: winrt class
---

<!-- Class syntax.
public class ClaimedLineDisplay : IClosable
-->

# Windows.Devices.PointOfService.ClaimedLineDisplay

## -description
Represents a claimed line display device.

## -remarks
This object is created when the [LineDisplay.ClaimAsync](linedisplay_claimasync.md) method completes. Unlike other peripherals, the EnableAsync() method has been removed for line displays; Instead, the device is implicitly enabled whenever commands are sent that require the line display to be in an enabled state.

## -see-also

## -examples
