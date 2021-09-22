---
-api-id: M:Windows.Devices.Haptics.SimpleHapticsController.SendHapticFeedbackForDuration(Windows.Devices.Haptics.SimpleHapticsControllerFeedback,System.Double,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax.
public void SimpleHapticsController.SendHapticFeedbackForDuration(SimpleHapticsControllerFeedback feedback, Double intensity, TimeSpan playDuration)
-->

# Windows.Devices.Haptics.SimpleHapticsController.SendHapticFeedbackForDuration

## -description

Start haptic feedback by the input device and continue for the specified amount of time.

## -parameters

### -param feedback

The type of haptic feedback.

### -param intensity

The strength of the haptic feedback based on the capability of the input device.

- 0 disables haptic feedback
- 1.0 is maximum strength

### -param playDuration

The time period expressed in 100-nanosecond units (1 = 100ns).

## -remarks

## -see-also

## -examples
