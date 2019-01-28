---
-api-id: N:Windows.Devices.Input.Preview
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Windows.Devices.Input.Preview 
-->

# Windows.Devices.Input.Preview

## -description

Provide support for tracking a user's gaze, attention, and presence based on the location and movement of their eyes and head.

> [!NOTE]
> For gaze input in [Windows Mixed Reality](https://docs.microsoft.com/windows/mixed-reality/), see [Gaze](https://docs.microsoft.com/windows/mixed-reality/gaze).

## -remarks

Support for eye-tracking hardware was introduced in Windows 10 Fall Creators Update along with [Eye control](https://support.microsoft.com/en-us/help/4043921/windows-10-get-started-eye-control), a built-in feature that lets you use your eyes to control the on-screen pointer, type with the on-screen keyboard, and communicate with people using text-to-speech. This set of UWP APIs for building applications that can interact with eye tracking hardware is supported in RS4 and later.

See [Get started with eye control in Windows 10](https://support.microsoft.com/help/4043921/windows-10-get-started-eye-control#supported-devices ) for a list of supported eye-tracking devices.

To use the gaze input APIs and access both internal and peripheral devices such as eye trackers, you must register the `gazeInput` capability in the app manifest. Just add the following `DeviceCapability` to the `Capabilities` node in the Package.appxmanifest file of your project:

```xaml
<Capabilities>
   <DeviceCapability Name="gazeInput" />
</Capabilities>
```

## -see-also

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Samples

[Gaze input sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-gazeinput-basic.zip)

### Resources

[Windows Community Toolkit Gaze library](https://docs.microsoft.com/windows/uwpcommunitytoolkit/gaze/gazeinteractionlibrary)

## -examples
