---
-api-id: M:Windows.Media.Devices.WhiteBalanceControl.SetValueAsync(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetValueAsync(System.UInt32 temperature)
-->

# Windows.Media.Devices.WhiteBalanceControl.SetValueAsync

## -description
Asynchronously sets the color temperature [Value](whitebalancecontrol_value.md).

## -parameters
### -param temperature
The temperature value to set the [Value](whitebalancecontrol_value.md) property to.

## -returns
The object that is used to control the asynchronous operation.

## -remarks
White balance is specified as a color temperature in degrees Kelvin.

Adjusting the white balance is only supported while the preview stream is running. Check to make sure that the preview stream is running before setting the white balance value or preset.

The [ColorTemperaturePreset.Auto](colortemperaturepreset.md) preset value instructs the system to automatically adjust the white balance level. For some scenarios, such as capturing a photo sequence where the white balance levels should be the same for each frame, you may want to lock the control to the current automatic value. To do this, call [SetPresetAsync](whitebalancecontrol_setpresetasync_1724838565.md) and specify the **Manual** preset and do not set a value on the control using SetValueAsync. This will cause the device to lock the current value. Do not attempt to read the current control value and then pass the returned value into SetValueAsync because this value is not guaranteed to be correct.

## -examples

## -see-also
