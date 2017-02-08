---
-api-id: P:Windows.Media.Audio.AudioGraphSettings.DesiredSamplesPerQuantum
-api-type: winrt property
---

<!-- Property syntax
public int DesiredSamplesPerQuantum { get;  set; }
-->

# Windows.Media.Audio.AudioGraphSettings.DesiredSamplesPerQuantum

## -description
Gets or sets the desired number of samples per quantum defined for the audio graph.

## -property-value
The number of samples per quantum.

## -remarks
Note that this property value is only valid if the [QuantumSizeSelectionMode](audiographsettings_quantumsizeselectionmode.md) property is set to **ClosestToDesired**.

If the audio graph you created is intended to be used exclusively with files, it is strongly recommended that you set the [QuantumSizeSelectionMode](audiographsettings_quantumsizeselectionmode.md) to **SystemDefault**.

Setting this property does not guarantee that the specified value will be used by the created audio graph. To determine the actual value used, check the [AudioGraph.SamplesPerQuantum](audiograph_samplesperquantum.md) property of the audio graph after it has been created.

## -examples

## -see-also
