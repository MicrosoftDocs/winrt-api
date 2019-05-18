---
-api-id: M:Windows.Graphics.Display.DisplayEnhancementOverride.RequestOverride
-api-type: winrt method
---

<!-- Method syntax.
public void DisplayEnhancementOverride.RequestOverride()
-->

# Windows.Graphics.Display.DisplayEnhancementOverride.RequestOverride



## -description

Requests that the current display be overridden with the current display override settings.

## -remarks

RequestOverride notifies the system that the current [DisplayEnhancementOverride](displayenhancementoverride.md) object wants to apply its brightness and color settings to the system. It is up to the system to decide if these settings will be applied. Applying settings is atomic: either all settings are applied, or none at all.

## -see-also

## -examples

