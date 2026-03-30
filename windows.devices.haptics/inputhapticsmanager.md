---
-api-id: T:Windows.Devices.Haptics.InputHapticsManager
-api-type: winrt class
---

# Windows.Devices.Haptics.InputHapticsManager

<!--
public sealed class InputHapticsManager
-->


## -description

Provides functionality to trigger haptic feedback on the input device that most recently delivered input to the associated thread, if the device supports haptics and input was received recently. The object must be used on the same thread on which it was created.

## -remarks

## -see-also

[SimpleHapticsController](simplehapticscontroller.md), [HapticDeviceType](hapticdevicetype.md), [HapticsControllerOverrideToken](hapticscontrolleroverridetoken.md), [KnownSimpleHapticsControllerWaveforms](knownsimplehapticscontrollerwaveforms.md)

## -examples

The following example shows how to trigger a haptic waveform on the input device that most recently delivered input to the current thread, with a device-type-specific fallback if the waveform is not supported. It gracefully handles OS versions where the API does not exist or is not supported.

```cppwinrt
bool SendHapticFeedback(uint16_t waveform)
{
    auto hapticsManagerStatics = winrt::try_get_activation_factory<
        winrt::InputHapticsManager, winrt::IInputHapticsManagerStatics>();

    if (hapticsManagerStatics && hapticsManagerStatics.IsSupported())
    {
        return hapticsManagerStatics
            .GetForCurrentThread()
            .TrySendHapticWaveform(waveform, 0);
    }

    return false;
}
```