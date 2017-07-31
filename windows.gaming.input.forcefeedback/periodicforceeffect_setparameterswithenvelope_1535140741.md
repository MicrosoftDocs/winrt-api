---
-api-id: M:Windows.Gaming.Input.ForceFeedback.PeriodicForceEffect.SetParametersWithEnvelope(Windows.Foundation.Numerics.Vector3,System.Single,System.Single,System.Single,System.Single,System.Single,System.Single,Windows.Foundation.TimeSpan,Windows.Foundation.TimeSpan,Windows.Foundation.TimeSpan,Windows.Foundation.TimeSpan,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public void SetParametersWithEnvelope(Windows.Foundation.Numerics.Vector3 vector, System.Single frequency, System.Single phase, System.Single bias, System.Single attackGain, System.Single sustainGain, System.Single releaseGain, Windows.Foundation.TimeSpan startDelay, Windows.Foundation.TimeSpan attackDuration, Windows.Foundation.TimeSpan sustainDuration, Windows.Foundation.TimeSpan releaseDuration, System.UInt32 repeatCount)
-->

# Windows.Gaming.Input.ForceFeedback.PeriodicForceEffect.SetParametersWithEnvelope

## -description
Sets the parameters for the effect and sets an envelope for the effect.

## -parameters
### -param vector
A vector describing the direction and magnitude of the effect on each axis. Each individual axis has a range of -1.0 to 1.0 and is independent of the other axes. Specifying a negative value for an axis reverses the input values from the axis.

### -param frequency
The number of times the periodic wave occurs in one second.

### -param phase
The phase offset from the origin of the periodic waveform, where 0.0 equals zero degrees of offset, and 1.0 equals 360 degrees of offset. For example, a phase value of 0.25 would correspond to a phase offset of 90 degrees.

### -param bias
The adjustment to add to the magnitude after calculating the wave and before applying the ramp or gain. Range is between -1 and 1.

### -param attackGain
Percentage by which to reduce the strength of the effect when it is ramping up.

### -param sustainGain
Percentage by which to reduce the strength of the effect when it is sustaining.

### -param releaseGain
Percentage by which to reduce the strength of the effect when it is ramping down.

### -param startDelay
Time to delay the effect before starting.

### -param attackDuration
Time to ramp up to the effect's full strength.

### -param sustainDuration
Time to maintain the effect at full strength.

### -param releaseDuration
Time to ramp down from full strength to zero.

### -param repeatCount
The number of times to repeat the effect.

## -remarks

## -examples

## -see-also
