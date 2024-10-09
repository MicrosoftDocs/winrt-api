---
-api-id: T:Windows.Media.Effects.AudioCaptureEffectsManager
-api-type: winrt class
---

<!-- Class syntax.
public class AudioCaptureEffectsManager : Windows.Media.Effects.IAudioCaptureEffectsManager
-->

# Windows.Media.Effects.AudioCaptureEffectsManager

## -description

Represents an audio capture effects manager which can be used to discover the audio processing chain on a device for a specific media category and audio processing mode.

## -remarks
To create an instance of **AudioCaptureEffectsManager**, call [AudioEffectsManager.CreateAudioCaptureEffectsManager](audioeffectsmanager_createaudiocaptureeffectsmanager_1036225902.md). Or, you can get an instance of this class from an <xref:Windows.Media.Devices.AudioDeviceController> by accessing the <xref:Windows.Media.Devices.AudioDeviceController.AudioCaptureEffectsManager> property.

See the [Audio effects discovery sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Audio%20effects%20discovery%20sample) for an example of how to query and monitor audio effects on render and capture audio devices.

## -examples

The following example demonstrates the [CaptureEffectsManager.GetAudioCaptureEffects](audiocaptureeffectsmanager_getaudiocaptureeffects_1705960470.md) to detect whether the [DeepNoiseSuppression](audioeffecttype.md) effect is present on the specified capture device.

```csharp
private bool IsDeepNoiseSuppressionSupported()
{
    var captureEffectsManager = Windows.Media.Effects.AudioEffectsManager.CreateAudioCaptureEffectsManager(
        MediaDevice.GetDefaultAudioCaptureId(AudioDeviceRole.Default),
        Windows.Media.Capture.MediaCategory.Speech,
        Windows.Media.AudioProcessing.Default);

    // Check for the presence of DeepNoiseSuppression
    IReadOnlyList<AudioEffect> effectslist = captureEffectsManager.GetAudioCaptureEffects();
    for (int i = 0; i < effectslist.Count; i++)
    {
        if (effectslist[i].AudioEffectType == Windows.Media.Effects.AudioEffectsType.DeepNoiseSuppression)
        {
            return true;
        }
    }

    return false;
}
```

## -see-also
[Audio effects discovery sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Audio%20effects%20discovery%20sample)
