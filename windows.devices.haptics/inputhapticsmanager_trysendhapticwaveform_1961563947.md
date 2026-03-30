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

The waveform to trigger. If 0, a default waveform is chosen for known device types (see [Remarks](#remarks)). If *waveform* is 0, *waveformFallback* must also be 0.

### -param waveformFallback

The fallback waveform to use if *waveform* is not supported. If 0, a default waveform that matches the category of *waveform* is chosen for known device types (see [Remarks](#remarks)).

## -returns

**true** if the waveform was successfully triggered; **false** if no input has been received recently, the most recent input device does not support haptics, or the device does not support either waveform.

## -remarks

When both *waveform* and *waveformFallback* are 0, a default discrete waveform is chosen: [Hover](knownsimplehapticscontrollerwaveforms_hover.md) for mouse and touchpad devices, or [Click](knownsimplehapticscontrollerwaveforms_click.md) for pen devices. When *waveform* is non-zero and *waveformFallback* is 0, the default fallback attempts to match the discrete or continuous category of *waveform*. Default continuous waveforms are [InkContinuous](knownsimplehapticscontrollerwaveforms_inkcontinuous.md) for pen devices; mouse and touchpad devices do not have a default continuous waveform.

## -see-also

[InputHapticsManager.TrySendHapticWaveform(UInt16, UInt16, Double)](inputhapticsmanager_trysendhapticwaveform_1337779939.md), [InputHapticsManager.TrySendHapticWaveformForDuration](inputhapticsmanager_trysendhapticwaveformforduration_524404563.md), [InputHapticsManager.TrySendHapticWaveformForPlayCount](inputhapticsmanager_trysendhapticwaveformforplaycount_22977135.md), [InputHapticsManager.TryStopFeedback](inputhapticsmanager_trystopfeedback_152765558.md), [KnownSimpleHapticsControllerWaveforms](knownsimplehapticscontrollerwaveforms.md)

## -examples
