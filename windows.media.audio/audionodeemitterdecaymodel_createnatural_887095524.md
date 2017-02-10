---
-api-id: M:Windows.Media.Audio.AudioNodeEmitterDecayModel.CreateNatural(System.Double,System.Double,System.Double,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Audio.AudioNodeEmitterDecayModel CreateNatural(System.Double minGain, System.Double maxGain, System.Double unityGainDistance, System.Double cutoffDistance)
-->

# Windows.Media.Audio.AudioNodeEmitterDecayModel.CreateNatural

## -description
Creates an [AudioNodeEmitterDecayModel](audionodeemitterdecaymodel.md) with a natural roll-off model using a distance-squared formula.

## -parameters
### -param minGain
The minimum gain applied to the signal.

### -param maxGain
The maximum gain applied to the signal.

### -param unityGainDistance
The distance at which the gain of the signal is unaffected by decay.

### -param cutoffDistance
The distance at which the gain is *minGain*.

## -returns
The created decay model.

## -remarks
The distance values for *unityGainDistance* and *cutoffDistance* are expressed in meters, but can be scaled by setting the [AudioNodeEmitter.DistanceScale](audionodeemitter_distancescale.md) property.

## -examples

## -see-also
