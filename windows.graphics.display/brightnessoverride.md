---
-api-id: T:Windows.Graphics.Display.BrightnessOverride
-api-type: winrt class
---

<!-- Class syntax.
public class BrightnessOverride 
-->

# Windows.Graphics.Display.BrightnessOverride

## -description
Overrides the screen brightness level setting on a device. This API provides the ability to have per-application brightness control on devices that support controllable brightness. 
Use the [BrightnessOverride](brightnessoverride.md) object to override the user's brightness level setting temporarily or permanently.

## -remarks

## -see-also

## -examples

This example shows how apps that run in a window can override the device's brightness at full brightness. To stop the overriding process, use [StopOverride()](brightnessoverride_stopoverride_1207260318.md).

```csharp
private void Set_Full_Brightness()
{
    //Create BrightnessOverride object
    BrightnessOverride bo = BrightnessOverride.GetForCurrentView();

    //Set override brightness to full brightness even when battery is low
    bo.SetBrightnessScenario(DisplayBrightnessScenario.FullBrightness, DisplayBrightnessOverrideOptions.None);

    //Request to start the overriding process
    bo.StartOverride();
}
```

This example also overrides the device's brightness at full brightness, but is used by apps that run in the background and do not have a [CoreWindow](../windows.ui.core/corewindow.md).

```csharp
private void Set_Full_Brightness_AppsInBackground()
{
    //Create BrightnessOverride object
    BrightnessOverride bo = BrightnessOverride.GetDefaultForSystem();

    //Set override brightness to full brightness even when battery is low
    bo.SetBrightnessScenario(DisplayBrightnessScenario.FullBrightness, DisplayBrightnessOverrideOptions.None);

    //Request to start the overriding process
    bo.StartOverride();
}
```