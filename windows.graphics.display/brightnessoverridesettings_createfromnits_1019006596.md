---
-api-id: M:Windows.Graphics.Display.BrightnessOverrideSettings.CreateFromNits(System.Single)
-api-type: winrt method
---

<!-- Method syntax.
public BrightnessOverrideSettings BrightnessOverrideSettings.CreateFromNits(Single nits)
-->

# Windows.Graphics.Display.BrightnessOverrideSettings.CreateFromNits



## -description
Creates a [BrightnessOverrideSettings](brightnessoverridesettings.md) object with the specified brightness in nits.

## -parameters
### -param nits

The brightness in nits to use to create the override settings.

## -returns

The override settings.

## -remarks

The supported nit values can be queried with [GetSupportedNitRanges](displayenhancementoverridecapabilities_getsupportednitranges_2119123994.md). If the view does not support the given nit value, then the nearest supported nit value will be set. If no
nit values are supported, this will be set to 0.

## -see-also

## -examples

