---
-api-id: M:Windows.UI.ViewManagement.ApplicationView.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.ViewManagement.ApplicationView GetForCurrentView()
-->

# Windows.UI.ViewManagement.ApplicationView.GetForCurrentView

## -description
Gets the view state and behavior settings of the active application.

## -returns
An [ApplicationView](applicationview.md) instance that can be used to get and set app display properties.

## -remarks
This is a static member of the [ApplicationView](applicationview.md) class. For JavaScript this means that it is a method of the [ApplicationView](applicationview.md) class, not of the window object that getForCurrentView creates.

> [!CAUTION]
> You can call `ApplicationView.GetForCurrentView` only after the [CoreWindow](../windows.ui.core/corewindow.md) has been constructed, so it is not safe to call this method in an app's constructor. Instead, the call should be deferred until [Application.OnLaunched](../windows.ui.xaml/application_onlaunched_859642554.md).

## -examples

## -see-also
