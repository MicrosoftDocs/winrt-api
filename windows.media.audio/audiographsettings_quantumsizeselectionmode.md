---
-api-id: P:Windows.Media.Audio.AudioGraphSettings.QuantumSizeSelectionMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Audio.QuantumSizeSelectionMode QuantumSizeSelectionMode { get;  set; }
-->

# Windows.Media.Audio.AudioGraphSettings.QuantumSizeSelectionMode

## -description
Gets or sets the quantum size selection mode for the audio graph.

## -property-value
An enumeration value indicating the quantum size selection mode. If the audio graph is only to be used with files, it is strongly recommended to use the value SystemDefault.

## -remarks
If the audio graph you created is intended to be used exclusively with files, it is strongly recommended that you set the [QuantumSizeSelectionMode](audiographsettings_quantumsizeselectionmode.md) to **SystemDefault**.

Selecting **QuantumSizeSelectionMode.LowestLatency** can result in different quantum sizes across different devices or audio endpoints.

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
