---
-api-id: M:Windows.Graphics.Display.BrightnessOverride.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax.
public BrightnessOverride BrightnessOverride.GetForCurrentView()
-->

# Windows.Graphics.Display.BrightnessOverride.GetForCurrentView

## -description
Returns a brightness override object. This method requires [CoreWindow](../windows.ui.core/corewindow.md) so it can only be used by apps that are currently running in a window. The returned [BrightnessOverride](brightnessoverride.md) object may not be the same between multiple [GetForCurrentView()](brightnessoverride_getforcurrentview_1363600702.md) calls on the same thread.

## -returns
The brightness override object.

## -remarks
This method throws an access is denied exception if there is no [CoreWindow](../windows.ui.core/corewindow.md) on the calling thread.

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