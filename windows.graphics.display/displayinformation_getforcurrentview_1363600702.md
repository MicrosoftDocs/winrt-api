---
-api-id: M:Windows.Graphics.Display.DisplayInformation.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax
public Windows.Graphics.Display.DisplayInformation GetForCurrentView()
-->

# Windows.Graphics.Display.DisplayInformation.GetForCurrentView

## -description
Gets the  DisplayInformation instance associated with the current thread's [CoreApplicationView](../windows.applicationmodel.core/coreapplicationview.md). This DisplayInformation instance is tied to the view and cannot be used from other threads.

## -returns
A [DisplayInformation](displayinformation.md) object that provides display-related information for the current thread's view.

## -remarks
This method is static. This method can fail if the current thread is not the UI thread for an application view.

## -examples

## -see-also
