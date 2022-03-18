---
-api-id: M:Windows.Graphics.Display.BrightnessOverride.SetBrightnessLevel(System.Double,Windows.Graphics.Display.DisplayBrightnessOverrideOptions)
-api-type: winrt method
---

<!-- Method syntax.
public void BrightnessOverride.SetBrightnessLevel(Double brightnessLevel, DisplayBrightnessOverrideOptions options)
-->

# Windows.Graphics.Display.BrightnessOverride.SetBrightnessLevel

## -description

Sets the brightness level and the override options. When your app is ready to change the current brightness with what you want to override it with, call [StartOverride](/uwp/api/windows.graphics.display.brightnessoverride.startoverride).

## -parameters

### -param brightnessLevel

Brightness of the screen. Value should be in the range of 0.0 and 1.0, where 1.0 is for 100% brightness.

### -param options

Options that modify the brightness level of the screen during the brightness override session.

## -remarks

## -see-also

## -examples

```csharp
// Set display to 80% brightness and, if the device is on low battery during overriding,
// then allow the display to dim. */

bo.SetBrightnessLevel(0.80, DisplayBrightnessOverrideOptions.UseDimmedPolicyWhenBatteryIsLow);
```
