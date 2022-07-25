---
-api-id: M:Windows.UI.Xaml.Controls.Control.OnManipulationInertiaStarting(Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnManipulationInertiaStarting(Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
-->

# Windows.UI.Xaml.Controls.Control.OnManipulationInertiaStarting

## -description
Called before the [ManipulationInertiaStarting](../windows.ui.xaml/uielement_manipulationinertiastarting.md) event occurs.



## -parameters
### -param e
Event data for the event.

## -remarks
<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 467590-->
### Windows 8 behavior

Windows 8 doesn't fire [ManipulationCompleted](../windows.ui.xaml/uielement_manipulationcompleted.md) in cases where the inertial phase has started (and [ManipulationInertiaStarting](../windows.ui.xaml/uielement_manipulationinertiastarting.md) has fired) but the user has tapped on the item before it's finished scrolling, which cancels the inertial phase visually. The issue is fixed starting with Windows 8.1; [ManipulationCompleted](../windows.ui.xaml/uielement_manipulationcompleted.md) is fired as soon as the tap action cancels the inertial phase.

Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples

## -see-also
[UIElement.ManipulationInertiaStarting](../windows.ui.xaml/uielement_manipulationinertiastarting.md), [ManipulationInertiaStartingRoutedEventArgs](../windows.ui.xaml.input/manipulationinertiastartingroutedeventargs.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Custom user interactions](/windows/uwp/design/layout/index), [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input)
