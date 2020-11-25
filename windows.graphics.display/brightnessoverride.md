---
-api-id: T:Windows.Graphics.Display.BrightnessOverride
-api-type: winrt class
---

<!-- Class syntax.
public class BrightnessOverride 
-->

# Windows.Graphics.Display.BrightnessOverride

## -description

**BrightnessOverride** allows your application to override the screen brightness level that's set for the device. With this API, you can have per-application brightness controls on devices that support controllable brightness.

You can use **BrightnessOverride** to override the user's brightness level setting either temporarily or permanently.

> [!NOTE]
> When you first retrieve an initialized **BrightnessOverride** object from [GetDefaultForSystem](/uwp/api/windows.graphics.display.brightnessoverride.getdefaultforsystem) or from [GetForCurrentView](/uwp/api/windows.graphics.display.brightnessoverride.getforcurrentview), the value of that object's **BrightnessLevel** property is undefined (the value doesn't, for example, represent the current system brightness level). You need to first call [**SetBrightnessLevel**](/uwp/api/windows.graphics.display.brightnessoverride.setbrightnesslevel?view=winrt-19041) to set a brightness level.

## -remarks

## -see-also

## -examples
