---
-api-id: M:Windows.ApplicationModel.Core.IFrameworkView.SetWindow(Windows.UI.Core.CoreWindow)
-api-type: winrt method
---

<!-- Method syntax
public void SetWindow(Windows.UI.Core.CoreWindow window)
-->

# Windows.ApplicationModel.Core.IFrameworkView.SetWindow

## -description
Sets the current window for the app object's view.

## -parameters
### -param window
The current window for the app object.

## -remarks
The app object calls your implementation of this method whenever it needs to set the current window, represented as a [CoreWindow](../windows.ui.core/corewindow.md) instance, for the associated view. Your implementation must at least assign the provided window to the view and register for any view and window events.

## -examples

## -see-also
[CoreWindow](../windows.ui.core/corewindow.md)