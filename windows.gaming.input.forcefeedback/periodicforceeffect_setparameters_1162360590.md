---
-api-id: M:Windows.Gaming.Input.ForceFeedback.PeriodicForceEffect.SetParameters(Windows.Foundation.Numerics.Vector3,System.Single,System.Single,System.Single,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public void SetParameters(Windows.Foundation.Numerics.Vector3 vector, System.Single frequency, System.Single phase, System.Single bias, Windows.Foundation.TimeSpan duration)
-->

# Windows.Gaming.Input.ForceFeedback.PeriodicForceEffect.SetParameters

## -description
Sets the parameters for the force feedback effect.

## -parameters
### -param vector
A vector describing the direction and magnitude of the effect on each axis. Each individual axis has a range of -1.0 to 1.0 and is independent of the other axes. Specifying a negative value for an axis reverses the input values from the axis.

### -param frequency
The number of times the periodic wave occurs in one second.

### -param phase
The phase offset from the origin of the periodic waveform, where 0.0 equals zero degrees of offset, and 1.0 equals 360 degrees of offset. For example, a phase value of 0.25 would correspond to a phase offset of 90 degrees.

### -param bias
The adjustment to add to the magnitude after calculating the wave and before applying the ramp or gain. Range is between -1 and 1.

### -param duration
The duration of the effect.

## -remarks

## -examples

## -see-also
