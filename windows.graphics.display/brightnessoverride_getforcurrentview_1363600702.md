---
-api-id: M:Windows.Graphics.Display.BrightnessOverride.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax.
public BrightnessOverride BrightnessOverride.GetForCurrentView()
-->

# Windows.Graphics.Display.BrightnessOverride.GetForCurrentView

## -description
Returns a brightness override object. This method requires [CoreWindow](# ./windows.ui.core/corewindow.md) so it can only be used by apps that are currently running in a window. The returned [BrightnessOverride](# brightnessoverride.md) object may not be the same between multiple [GetForCurrentView()](# brightnessoverride\_getforcurrentview\_1363600702.md) calls on the same thread.

## -returns
The brightness override object.

## -remarks
This method fails if there is no [CoreWindow](# ./windows.ui.core/corewindow.md) on the calling thread.

## -see-also

## -examples

