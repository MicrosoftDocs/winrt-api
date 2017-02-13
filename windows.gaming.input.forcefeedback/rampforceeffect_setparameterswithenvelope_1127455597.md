---
-api-id: M:Windows.Gaming.Input.ForceFeedback.RampForceEffect.SetParametersWithEnvelope(Windows.Foundation.Numerics.Vector3,Windows.Foundation.Numerics.Vector3,System.Single,System.Single,System.Single,Windows.Foundation.TimeSpan,Windows.Foundation.TimeSpan,Windows.Foundation.TimeSpan,Windows.Foundation.TimeSpan,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public void SetParametersWithEnvelope(Windows.Foundation.Numerics.Vector3 startVector, Windows.Foundation.Numerics.Vector3 endVector, System.Single attackGain, System.Single sustainGain, System.Single releaseGain, Windows.Foundation.TimeSpan startDelay, Windows.Foundation.TimeSpan attackDuration, Windows.Foundation.TimeSpan sustainDuration, Windows.Foundation.TimeSpan releaseDuration, System.UInt32 repeatCount)
-->

# Windows.Gaming.Input.ForceFeedback.RampForceEffect.SetParametersWithEnvelope

## -description
Sets the parameters for the effect and sets an envelope for the effect.

## -parameters
### -param startVector
The start vector of the effect.

### -param endVector
The end vector of the effect.

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
