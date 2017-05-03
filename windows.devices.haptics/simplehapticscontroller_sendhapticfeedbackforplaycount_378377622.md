---
-api-id: M:Windows.Devices.Haptics.SimpleHapticsController.SendHapticFeedbackForPlayCount(Windows.Devices.Haptics.SimpleHapticsControllerFeedback,System.Double,System.Int32,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax.
public void SimpleHapticsController.SendHapticFeedbackForPlayCount(SimpleHapticsControllerFeedback feedback, Double intensity, Int32 playCount, TimeSpan replayPauseInterval)
-->

# Windows.Devices.Haptics.SimpleHapticsController.SendHapticFeedbackForPlayCount

## -description
Start haptic feedback by the input device and repeat for the specified number of times.

## -parameters

### -param feedback
The type of haptic feedback.

### -param intensity
The relative strength of the haptic feedback as a percentage of the capability of the input device.
- 0 disables haptic feedback
- 100 is maximum strength 

### -param playCount
The number of times to repeat the haptic feedback.

### -param replayPauseInterval
The time period between feedback cycles, expressed in 100-nanosecond units.

## -remarks

## -see-also

## -examples

