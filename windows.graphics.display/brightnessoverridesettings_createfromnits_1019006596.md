---
-api-id: M:Windows.Graphics.Display.BrightnessOverrideSettings.CreateFromNits(System.Single)
-api-type: winrt method
---

<!-- Method syntax.
public BrightnessOverrideSettings BrightnessOverrideSettings.CreateFromNits(Single nits)
-->

# Windows.Graphics.Display.BrightnessOverrideSettings.CreateFromNits



## -description
Creates a set of brightness override settings from the specified Nits level.

## -parameters
### -param nits

The Nits level to use to create the override settings.

## -returns

The override settings.

## -remarks

The supported nit values can be queried with [GetSupportedNitRanges](displayenhancementoverridecapabilities_getsupportednitranges_2119123994.md). If the view does not support the given nit value, then the nearest supported nit value will be set. If no
nit values are supported, this will be set to 0.

## -see-also

## -examples

