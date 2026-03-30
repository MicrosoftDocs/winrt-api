---
-api-id: M:Windows.Devices.Haptics.InputHapticsManager.TrySendHapticWaveformForDuration(System.UInt16,System.UInt16,System.Double,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

# Windows.Devices.Haptics.InputHapticsManager.TrySendHapticWaveformForDuration(System.UInt16,System.UInt16,System.Double,Windows.Foundation.TimeSpan)

<!--
public bool TrySendHapticWaveformForDuration (ushort waveform, ushort waveformFallback, double intensity, System.TimeSpan playDuration);
-->

## -description

Attempts to trigger the specified waveform, with the specified intensity and duration, on the input device that most recently delivered input to the thread. The fallback waveform is used if the first waveform is not supported.

## -parameters

### -param waveform

The waveform to trigger. If 0, a default waveform is chosen for known device types (see [Remarks](#remarks)). If *waveform* is 0, *waveformFallback* must also be 0.

### -param waveformFallback

The fallback waveform to use if *waveform* is not supported. If 0, a default waveform that matches the category of *waveform* is chosen for known device types (see [Remarks](#remarks)).

### -param intensity

The intensity of the waveform, expressed as a value between 0.0 and 1.0.

### -param playDuration

The duration for which to play the waveform. Must be greater than zero. Applicable only to continuous waveforms.

## -returns

**true** if the waveform was successfully triggered; **false** if no input has been received recently, the most recent input device does not support haptics, or the device does not support either waveform or other parameters.

This method also returns **false** if specifying an intensity other than 1.0 and the device does not support configuring intensity.

## -remarks

When both *waveform* and *waveformFallback* are 0, a default continuous waveform is chosen: [InkContinuous](knownsimplehapticscontrollerwaveforms_inkcontinuous.md) for pen devices. Mouse and touchpad devices do not have a default continuous waveform.

When *waveform* is non-zero and *waveformFallback* is 0, the default fallback attempts to match the discrete or continuous category of *waveform*.

Default discrete waveforms are [Hover](knownsimplehapticscontrollerwaveforms_hover.md) for mouse and touchpad devices, or [Click](knownsimplehapticscontrollerwaveforms_click.md) for pen devices.

The duration must be greater than zero. Specifying durations is only applicable to continuous waveforms (which do not have a predetermined duration).

## -see-also

[InputHapticsManager.TrySendHapticWaveform(UInt16, UInt16)](inputhapticsmanager_trysendhapticwaveform_1961563947.md), [InputHapticsManager.TrySendHapticWaveform(UInt16, UInt16, Double)](inputhapticsmanager_trysendhapticwaveform_1337779939.md), [InputHapticsManager.TrySendHapticWaveformForPlayCount](inputhapticsmanager_trysendhapticwaveformforplaycount_22977135.md), [InputHapticsManager.TryStopFeedback](inputhapticsmanager_trystopfeedback_152765558.md), [KnownSimpleHapticsControllerWaveforms](knownsimplehapticscontrollerwaveforms.md)

## -examples
