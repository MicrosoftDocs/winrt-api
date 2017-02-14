---
-api-id: T:Windows.Graphics.Display.DisplayBrightnessOverrideOptions
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum DisplayBrightnessOverrideOptions : uint 
-->

# Windows.Graphics.Display.DisplayBrightnessOverrideOptions

## -description
Describes the options that modify the brightness level of the screen during the override session. When __UseDimmedPolicyWhenBatteryIsLow__ is set, it reduces the specified override brightness level in order to conserve battery if the device
battery is low during the override session. For example, if the override brightness level is set to 100% and __UseDimmedPolicyWhenBatteryIsLow__ is set, the screen will dim to 70% instead.

## -enum-fields
### -field UseDimmedPolicyWhenBatteryIsLow:1
Screen display dims when the device battery is low and a brightness override session is running.

### -field None:0
Screen display stays at the specified override brightness level when the device battery is low.

## -remarks

## -see-also

## -examples

