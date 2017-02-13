---
-api-id: M:Windows.Graphics.Display.BrightnessOverride.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax.
public BrightnessOverride BrightnessOverride.GetForCurrentView()
-->

# Windows.Graphics.Display.BrightnessOverride.GetForCurrentView

## -description
Gets the brightness level for the current view the app is on when this method is called.

## -returns
The brightness level of the current view.

## -remarks
This method will fail if there is no [CoreWindow](# ./windows.ui.core/corewindow.md) on the calling thread. Note: When multiple GetForCurrentView() calls are made on the same thread, the returned [BrightnessOverride](# brightnessoverride.md) object may not be exactly the same.

## -see-also

## -examples

