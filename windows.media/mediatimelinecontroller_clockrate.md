---
-api-id: P:Windows.Media.MediaTimelineController.ClockRate
-api-type: winrt property
---

<!-- Property syntax
public double ClockRate { get;  set; }
-->

# Windows.Media.MediaTimelineController.ClockRate

## -description
Gets or sets the speed at which the position of the [MediaTimelineController](mediatimelinecontroller.md) changes, expressed as a ratio to normal playback speed. For example, setting a value of 1.0 will result in normal playback speed, a value of 4.0 will result in a playback speed 4 times the normal speed.

## -property-value
The speed at which the position of the [MediaTimelineController](mediatimelinecontroller.md) changes.

## -remarks
Only positive values are supported for **ClockRate**. Attempting to set a negative value will result in an argument exception.

## -examples

## -see-also
