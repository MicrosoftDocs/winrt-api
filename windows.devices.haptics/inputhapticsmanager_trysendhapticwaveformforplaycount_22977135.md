---
-api-id: M:Windows.Devices.Haptics.InputHapticsManager.TrySendHapticWaveformForPlayCount(System.UInt16,System.UInt16,System.Double,System.Int32,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

# Windows.Devices.Haptics.InputHapticsManager.TrySendHapticWaveformForPlayCount(System.UInt16,System.UInt16,System.Double,System.Int32,Windows.Foundation.TimeSpan)

<!--
public bool TrySendHapticWaveformForPlayCount (ushort waveform, ushort waveformFallback, double intensity, int playCount, System.TimeSpan replayPauseInterval);
-->

## -description

Attempts to trigger the specified waveform, with the specified intensity, play count, and replay pause interval, on the input device that most recently delivered input to the thread. The fallback waveform is used if the first waveform is not supported.

## -parameters

### -param waveform

The waveform to trigger. If 0, a default waveform is chosen for known device types (see [Remarks](#remarks)). If *waveform* is 0, *waveformFallback* must also be 0.

### -param waveformFallback

The fallback waveform to use if *waveform* is not supported. If 0, a default waveform that matches the category of *waveform* is chosen for known device types (see [Remarks](#remarks)).

### -param intensity

The intensity of the waveform, expressed as a value between 0.0 and 1.0.

### -param playCount

The total number of times to trigger the feedback. Applicable only to discrete waveforms.

### -param replayPauseInterval

The duration between the end of one playback and the start of the next. Must be greater than or equal to zero.

## -returns

**true** if the waveform was successfully triggered; **false** if no input has been received recently, the most recent input device does not support haptics, or the device does not support either waveform or other parameters.

This method also returns **false** if an intensity other than 1.0 is specified and the device does not support configuring intensity.

## -remarks

When both *waveform* and *waveformFallback* are 0, a default discrete waveform is chosen: [Hover](knownsimplehapticscontrollerwaveforms_hover.md) for mouse and touchpad devices, or [Click](knownsimplehapticscontrollerwaveforms_click.md) for pen devices.

When *waveform* is non-zero and *waveformFallback* is 0, the default fallback attempts to match the discrete or continuous category of *waveform*.

Default continuous waveforms are [InkContinuous](knownsimplehapticscontrollerwaveforms_inkcontinuous.md) for pen devices; mouse and touchpad devices do not have a default continuous waveform.

The play count controls the total number of times the feedback is triggered. The method returns **false** if a play count other than 1 is specified and the device does not support configuring play count. Specifying multiple play counts is only applicable to discrete waveforms.

The replay pause interval controls the duration between the end of triggering one playback and the start of the next one. This value must be greater than or equal to zero. The method returns **false** if an interval other than 0 is specified and the device does not support configuring the interval.

## -see-also

[InputHapticsManager.TrySendHapticWaveform(UInt16, UInt16)](inputhapticsmanager_trysendhapticwaveform_1961563947.md), [InputHapticsManager.TrySendHapticWaveform(UInt16, UInt16, Double)](inputhapticsmanager_trysendhapticwaveform_1337779939.md), [InputHapticsManager.TrySendHapticWaveformForDuration](inputhapticsmanager_trysendhapticwaveformforduration_524404563.md), [InputHapticsManager.TryStopFeedback](inputhapticsmanager_trystopfeedback_152765558.md), [KnownSimpleHapticsControllerWaveforms](knownsimplehapticscontrollerwaveforms.md)

## -examples
