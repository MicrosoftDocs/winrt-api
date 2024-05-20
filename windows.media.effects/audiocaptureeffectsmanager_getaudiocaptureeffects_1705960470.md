---
-api-id: M:Windows.Media.Effects.AudioCaptureEffectsManager.GetAudioCaptureEffects
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Effects.AudioEffect> GetAudioCaptureEffects()
-->

# Windows.Media.Effects.AudioCaptureEffectsManager.GetAudioCaptureEffects

## -description
Gets the list of audio effects on the device.

## -returns
The list of audio effects.

## -remarks

## -examples

The following example demonstrates the **GetAudioCaptureEffects** to detect whether the [DeepNoiseSuppression](audioeffecttype.md) effect is present on the specified capture device.

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
