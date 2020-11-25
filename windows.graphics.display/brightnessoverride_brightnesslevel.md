---
-api-id: P:Windows.Graphics.Display.BrightnessOverride.BrightnessLevel
-api-type: winrt property
---

<!-- Property syntax.
public double BrightnessLevel { get; }
-->

# Windows.Graphics.Display.BrightnessOverride.BrightnessLevel

## -description

Gets the screen brightness level for this [**BrightnessOverride**](/uwp/api/windows.graphics.display.brightnessoverride) instance (if you've previously called [**SetBrightnessLevel**](/uwp/api/windows.graphics.display.brightnessoverride.setbrightnesslevel?view=winrt-19041) to set the brightness level).

> [!NOTE]
> When you first retrieve an initialized **BrightnessOverride** object from [GetDefaultForSystem](/uwp/api/windows.graphics.display.brightnessoverride.getdefaultforsystem) or from [GetForCurrentView](/uwp/api/windows.graphics.display.brightnessoverride.getforcurrentview), the value of that object's **BrightnessLevel** property is undefined (the value doesn't, for example, represent the current system brightness level). You need to first call [**SetBrightnessLevel**](/uwp/api/windows.graphics.display.brightnessoverride.setbrightnesslevel?view=winrt-19041) to set a brightness level.

## -property-value

A value representing the screen brightness level for this [**BrightnessOverride**](/uwp/api/windows.graphics.display.brightnessoverride) instance (if you've previously called [**SetBrightnessLevel**](/uwp/api/windows.graphics.display.brightnessoverride.setbrightnesslevel?view=winrt-19041) to set the brightness level). If you haven't previously called [**SetBrightnessLevel**](/uwp/api/windows.graphics.display.brightnessoverride.setbrightnesslevel?view=winrt-19041) to set the brightness level, then the property value is undefined.

## -remarks

## -see-also

## -examples
