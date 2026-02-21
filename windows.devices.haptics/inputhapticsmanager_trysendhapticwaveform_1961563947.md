---
-api-id: M:Windows.Devices.Haptics.InputHapticsManager.TrySendHapticWaveform(System.UInt16,System.UInt16)
-api-type: winrt method
---

# Windows.Devices.Haptics.InputHapticsManager.TrySendHapticWaveform(System.UInt16,System.UInt16)

<!--
public bool TrySendHapticWaveform (ushort waveform, ushort waveformFallback);
-->


## -description

Attempts to trigger the specified waveform on the input device that most recently delivered input to the thread. The fallback waveform is used if the first waveform is not supported.

## -parameters

### -param waveform

The waveform to trigger. If 0, a default waveform is chosen for known device types.

### -param waveformFallback

The fallback waveform to use if *waveform* is not supported. If 0, a default waveform is chosen for known device types.

## -returns

**true** if the waveform was successfully triggered; otherwise, **false**.

## -remarks

## -see-also

[InputHapticsManager.TrySendHapticWaveform(UInt16, UInt16, Double)](inputhapticsmanager_trysendhapticwaveform_1337779939.md), [InputHapticsManager.TrySendHapticWaveformForDuration](inputhapticsmanager_trysendhapticwaveformforduration_524404563.md), [InputHapticsManager.TrySendHapticWaveformForPlayCount](inputhapticsmanager_trysendhapticwaveformforplaycount_22977135.md), [InputHapticsManager.TryStopFeedback](inputhapticsmanager_trystopfeedback_152765558.md), [KnownSimpleHapticsControllerWaveforms](knownsimplehapticscontrollerwaveforms.md)

## -examples


