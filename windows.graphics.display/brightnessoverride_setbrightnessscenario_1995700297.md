---
-api-id: M:Windows.Graphics.Display.BrightnessOverride.SetBrightnessScenario(Windows.Graphics.Display.DisplayBrightnessScenario,Windows.Graphics.Display.DisplayBrightnessOverrideOptions)
-api-type: winrt method
---

<!-- Method syntax.
public void BrightnessOverride.SetBrightnessScenario(DisplayBrightnessScenario scenario, DisplayBrightnessOverrideOptions options)
-->

# Windows.Graphics.Display.BrightnessOverride.SetBrightnessScenario

## -description
Sets the brightness level, by specifying a scenario that has a well-known brightness level, and the override options of the brightness override.

## -parameters

### -param scenario
A scenario that has a well-known brightness level.

### -param options
Options that modify the brightness level of the screen during the brightness override session.

## -remarks

## -see-also

## -examples

```csharp
/* Set the display brightness to a level that is optimum for reading barcodes. If the device is on low battery during overriding, allow the display to dim*/

bo.SetBrightnessScenario(DisplayBrightnessScenario.BarcodeReadingBrightness, DisplayBrightnessOverrideOptions.UseDimmedPolicyWhenBatteryIsLow); 
```
