---
-api-id: T:Windows.Graphics.Display.DisplayBrightnessOverrideOptions
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum DisplayBrightnessOverrideOptions : uint 
-->

# Windows.Graphics.Display.DisplayBrightnessOverrideOptions

## -description
Describes the options that modify the brightness level of the screen during the brightness override session. When UseDimmedPolicyWhenBatteryIsLow is set, it will reduce the specified override brightness level in order to conserve battery if the device
goes into low battery mode during the overriding session. For example, if override brightness level is set to 100% and UseDimmedPolicyWhenBatteryIsLow is set, the screen will dim to 70% instead.

## -enum-fields
### -field UseDimmedPolicyWhenBatteryIsLow:1
Screen display dim when the device is on low battery and a brightness override session is running.

### -field None:0
Screen display does not dim when the device is on low battery and a brightness override session is running.

## -remarks

## -see-also

## -examples

