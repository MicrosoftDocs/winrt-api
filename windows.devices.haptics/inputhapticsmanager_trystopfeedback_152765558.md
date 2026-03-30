---
-api-id: M:Windows.Devices.Haptics.InputHapticsManager.TryStopFeedback
-api-type: winrt method
---

# Windows.Devices.Haptics.InputHapticsManager.TryStopFeedback

<!--
public bool TryStopFeedback ();
-->


## -description

Attempts to stop any ongoing haptic playback on the input device that most recently received a haptic waveform from the manager.

## -returns

**true** if feedback was successfully stopped; **false** if no devices have been sent waveforms, a request to stop feedback had already been made for the device, or the request to stop feedback failed.

## -remarks

## -see-also

[InputHapticsManager.TrySendHapticWaveform(UInt16, UInt16)](inputhapticsmanager_trysendhapticwaveform_1961563947.md), [InputHapticsManager.TrySendHapticWaveform(UInt16, UInt16, Double)](inputhapticsmanager_trysendhapticwaveform_1337779939.md), [InputHapticsManager.TrySendHapticWaveformForDuration](inputhapticsmanager_trysendhapticwaveformforduration_524404563.md), [InputHapticsManager.TrySendHapticWaveformForPlayCount](inputhapticsmanager_trysendhapticwaveformforplaycount_22977135.md)

## -examples


