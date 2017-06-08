---
-api-id: M:Windows.Media.Audio.AudioNodeEmitterDecayModel.CreateCustom(System.Double,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Audio.AudioNodeEmitterDecayModel CreateCustom(System.Double minGain, System.Double maxGain)
-->

# Windows.Media.Audio.AudioNodeEmitterDecayModel.CreateCustom

## -description
Creates a new [AudioNodeEmitterDecayModel](audionodeemitterdecaymodel.md) that uses the specified minimum and maximum gain values to compute distance-based attenuation of a signal from an [AudioNodeEmitter](audionodeemitter.md).

## -parameters
### -param minGain
The minimum gain level for the signal.

### -param maxGain
The maximum gain level for the signal.

## -returns
The created decay model.

## -remarks
The *minGain* parameter value must be greater than or equal to 1.58439*10<sup>-5</sup>, and the *maxGain* parameter must be less than or equal to 3.98. In decibels, these limits map to a range of -96 dB to 12 dB. Convert from a decibel value to amplitude scale using the equation *gain = 10<sup>(dB/20)</sup>* where *dB* is the decibel value you wish to convert. 

## -examples

## -see-also
