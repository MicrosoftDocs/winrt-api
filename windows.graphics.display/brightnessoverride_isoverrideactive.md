---
-api-id: P:Windows.Graphics.Display.BrightnessOverride.IsOverrideActive
-api-type: winrt property
---

<!-- Property syntax.
public bool IsOverrideActive { get; }
-->

# Windows.Graphics.Display.BrightnessOverride.IsOverrideActive

## -description
BOOLEAN value that indicates whether the brightness override is active. If TRUE, the current brightness level matches the override brightness level. This property value will always be FALSE if [StartOverride()](# brightnessoverride\_startoverride\_1290413150.md) isn’t called.

## -property-value

## -remarks
As a device screen can only be set to one brightness level at any given time, only one [BrightnessOverride](# brightnessoverride.md) object can be set to active to allow the screen's brightness to match the override value.
In a situation when there are multiple [BrightnessOverride](# brightnessoverride.md) objects from multiple apps that want to override the brightness level, only one [BrightnessOverride](# brightnessoverride.md) object has this property set to TRUE at any one time.

## -see-also

## -examples

