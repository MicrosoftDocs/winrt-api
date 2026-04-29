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

[SimpleHapticsController](simplehapticscontroller.md), [HapticDeviceType](hapticdevicetype.md), [HapticsControllerOverrideToken](hapticscontrolleroverridetoken.md), [KnownSimpleHapticsControllerWaveforms](knownsimplehapticscontrollerwaveforms.md), [Input Device Haptics Implementation Guide](windows-hardware/design/component-guidelines/input-haptics-implementation-guide)

## -examples

The following example shows how to trigger a haptic waveform on the input device that most recently delivered input to the current thread. If the requested waveform is not supported, passing 0 for the second parameter lets the system use a device-type-specific fallback. The example also handles cases where the API is unavailable or unsupported.

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
