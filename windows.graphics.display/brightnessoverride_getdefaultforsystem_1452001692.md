---
-api-id: M:Windows.Graphics.Display.BrightnessOverride.GetDefaultForSystem
-api-type: winrt method
---

<!-- Method syntax.
public BrightnessOverride BrightnessOverride.GetDefaultForSystem()
-->

# Windows.Graphics.Display.BrightnessOverride.GetDefaultForSystem

## -description
Returns a brightness override object. This method does not require [CoreWindow](../windows.ui.core/corewindow.md) so it can be used by apps that are running in the background.

## -returns
The brightness override object.

## -remarks
Requires the __systemManagement__ capability to be declared in your app's package manifest. Usage of the __systemManagement__ capability requires [Embedded mode](/windows/iot-core/develop-your-app/embeddedmode) to be enabled. This capability allows apps to have basic system administration privileges. If it isn’t declared, this method throws an access is denied exception. For more info, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations#general-use-capabilities).

## -see-also

## -examples

This example overrides the device's brightness at full brightness, but is used by apps that run in the background and do not have a [CoreWindow](../windows.ui.core/corewindow.md).

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
