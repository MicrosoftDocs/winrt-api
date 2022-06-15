---
-api-id: P:Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs.Handled

## -description
Gets or sets a value that marks the routed event as handled. Setting to **true** prevents most handlers along the event route from handling the same event again.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Input.ManipulationStartedRoutedEventArgs.Handled](/windows/winui/api/microsoft.ui.xaml.input.manipulationstartedroutedeventargs.handled) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -property-value
**true** to mark the routed event handled; **false** to leave the routed event unhandled, which permits the event to potentially route further. The default is **false**.

## -remarks

## -examples

## -see-also
[Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview)
