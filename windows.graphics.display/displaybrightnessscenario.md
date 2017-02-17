---
-api-id: T:Windows.Graphics.Display.DisplayBrightnessScenario
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum DisplayBrightnessScenario : int 
-->

# Windows.Graphics.Display.DisplayBrightnessScenario

## -description
Describes common brightness scenarios that have well-known brightness levels. These scenarios are used in the [GetLevelForScenario()](brightnessoverride_getlevelforscenario_599977480.md) and [SetBrightnessScenario()](brightnessoverride_setbrightnessscenario_1995700297.md) methods. 

## -enum-fields
### -field IdleBrightness:1
Sets the screen to a battery friendly yet readable brightness level. This is currently set to 10% brightness. 

### -field FullBrightness:3
Sets the screen to 100% brightness.

### -field DefaultBrightness:0
Sets the screen to the current screen brightness, essentially freezing the brightness.

### -field BarcodeReadingBrightness:2
Sets the screen to the brightness level that it is easily readable by barcode readers. This is currently set to 100% brightness.

## -remarks

## -see-also

## -examples

