---
-api-id: M:Windows.Graphics.Display.BrightnessOverride.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax.
public BrightnessOverride BrightnessOverride.GetForCurrentView()
-->

# Windows.Graphics.Display.BrightnessOverride.GetForCurrentView

## -description
Returns a [BrightnessOverride](/uwp/api/windows.graphics.display.brightnessoverride) object. This method requires [CoreWindow](../windows.ui.core/corewindow.md), so it can be used only by apps that are currently running in a window. The returned brightness override object might not be the same between multiple calls to **BrightnessOverride.GetForCurrentView** on the same thread.

You must call **BrightnessOverride.GetForCurrentView** from the main UI thread.

## -returns
The brightness override object.

## -remarks
This method throws an access-denied exception if there is no [CoreWindow](../windows.ui.core/corewindow.md) on the calling thread.

If you call the [StartOverride](brightnessoverride_startoverride_1290413150.md) method on multiple instances in succession, the override with the highest *brightness* value will take precedence over subsequent calls on instances with lower values. To avoid problems, cache the instance retrieved from **BrightnessOverride.GetForCurrentView** and reuse that instance, or always call [StopOverride](brightnessoverride_stopoverride_1207260318.md) on the previously applied [BrightnessOverride](brightnessoverride.md).

## -see-also

## -examples

This example shows how apps that run in a window can override the device's brightness at full brightness. To stop the overriding process, use [StopOverride](brightnessoverride_stopoverride_1207260318.md).

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
