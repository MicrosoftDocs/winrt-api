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
Requires the __systemManagement__ capability to be declared in your app's package manifest. This capability allows apps to have basic system administration privileges. If it isn’t declared, this method throws an access is denied exception. For more info, see [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#general-use-capabilities).

## -see-also

## -examples

