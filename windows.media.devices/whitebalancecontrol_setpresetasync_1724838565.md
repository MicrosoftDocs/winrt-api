---
-api-id: M:Windows.Media.Devices.WhiteBalanceControl.SetPresetAsync(Windows.Media.Devices.ColorTemperaturePreset)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetPresetAsync(Windows.Media.Devices.ColorTemperaturePreset preset)
-->

# Windows.Media.Devices.WhiteBalanceControl.SetPresetAsync

## -description
Asynchronously sets the color temperature [Preset](whitebalancecontrol_preset.md).

## -parameters
### -param preset
The color temperate preset to set the [Preset](whitebalancecontrol_preset.md) property to.

## -returns
The object that is used to control the asynchronous operation.

## -remarks
Adjusting the white balance is only supported while the preview stream is running. Check to make sure that the preview stream is running before setting the white balance value or preset.

The [ColorTemperaturePreset.Auto](colortemperaturepreset.md) preset value instructs the system to automatically adjust the white balance level. For some scenarios, such as capturing a photo sequence where the white balance levels should be the same for each frame, you may want to lock the control to the current automatic value. To do this, call [SetPresetAsync](whitebalancecontrol_setpresetasync.md) and specify the **Manual** preset and do not set a value on the control using [SetValueAsync](whitebalancecontrol_setvalueasync.md). This will cause the device to lock the current value. Do not attempt to read the current control value and then pass the returned value into [SetValueAsync](whitebalancecontrol_setvalueasync.md) because this value is not guaranteed to be correct.

## -examples

## -see-also
