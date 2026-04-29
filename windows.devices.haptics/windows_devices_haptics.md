---
-api-id: N:Windows.Devices.Haptics
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Windows.Devices.Haptics 
-->

# Windows.Devices.Haptics

## -description

Provides support for basic, non-directional haptic feedback such as clicks, buzzes, and rumbles that can be tuned through  characteristics such as intensity and timing.

## -remarks

## -see-also

[Pen interactions and haptic (tactile) feedback](/windows/apps/design/input/pen-haptics), [Surface Dial interactions](/windows/apps/design/input/windows-wheel-interactions)

## -examples

The following fully functional samples demonstrate haptic features across various devices.

### Pen haptics

See the [Pen haptics sample](https://github.com/microsoft/Windows-universal-samples/tree/dev/Samples/PenHaptics) for working examples of the following functionality:

- Get a [SimpleHapticsController](simplehapticscontroller.md) from pen input: Go from [PointerPoint.PointerId](../windows.ui.input/pointerpoint_pointerid.md) to [PenDevice](../windows.devices.input/pendevice.md)  to [SimpleHapticsController](simplehapticscontroller.md) (requires both a haptic-capable pen and a device that supports the pen).
- Check pen haptics capabilities: A [SimpleHapticsController](simplehapticscontroller.md) exposes properties for pen hardware capabilities, including [IsIntensitySupported](simplehapticscontroller_isintensitysupported.md), [IsPlayCountSupported](simplehapticscontroller_isplaycountsupported.md), [SupportedFeedback](simplehapticscontroller_supportedfeedback.md), and so on.
- Start and stop haptic feedback: Use the [SendHapticFeedback](simplehapticscontroller_sendhapticfeedback_1295394442.md) and [StopFeedback](simplehapticscontroller_stopfeedback_481424790.md) methods appropriately.
- Trigger haptic feedback: Feedback for both *inking feedback* and *interaction feedback*.

### RadialController haptics

See the [RadialController](https://github.com/microsoft/RadialController) for examples of how to use haptics with RadialController devices such as the Surface Dial.

### Mixed reality controller haptics

See the [Spatial interaction source sample](https://github.com/microsoft/Windows-universal-samples/tree/dev/Samples/SpatialInteractionSource) for an example of how to use haptics with Six Degree of Freedom (6DOF) Controllers on Windows Mixed Reality Desktop.
