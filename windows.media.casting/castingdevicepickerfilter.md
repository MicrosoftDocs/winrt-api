---
-api-id: T:Windows.Media.Casting.CastingDevicePickerFilter
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class CastingDevicePickerFilter : Windows.Media.Casting.ICastingDevicePickerFilter
-->

# Windows.Media.Casting.CastingDevicePickerFilter

## -description
Represents the filter used to determine which devices to show in a casting device picker UI. The filter parameters are OR-ed together to build the resulting filter. In other words, if [SupportsAudio](castingdevicepickerfilter_supportsaudio.md) and [SupportsVideo](castingdevicepickerfilter_supportsvideo.md) are both true, the picker will display Audio-only devices, video-only devices, and audio/video devices.

## -remarks
Get an instance of this class by accessing the [CastingDevicePicker.Filter](castingdevicepicker_filter.md) property.

## -examples

## -see-also
