---
-api-id: M:Windows.UI.Xaml.Application.OnWindowCreated(Windows.UI.Xaml.WindowCreatedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnWindowCreated(Windows.UI.Xaml.WindowCreatedEventArgs args)
-->

# Windows.UI.Xaml.Application.OnWindowCreated

## -description
Invoked when the application creates a window.

Equivalent WinUI method: [Microsoft.UI.Xaml.Application.OnWindowCreated](/windows/winui/api/microsoft.ui.xaml.application.onwindowcreated).

## -parameters
### -param args
Event data for the event.

## -remarks
This method is called once for the creation of the main window, once for each hosted window, and once each time [CreateNewView](/uwp/api/windows.applicationmodel.core.coreapplication.createnewview) is called. You can override this method, for example, to access various panes by calling **GetForCurrentView** methods such as [SearchPane.GetForCurrentView](../windows.applicationmodel.search/searchpane_getforcurrentview_1363600702.md) and [SettingsPane.GetForCurrentView](../windows.ui.applicationsettings/settingspane_getforcurrentview_1363600702.md).

## -examples

## -see-also
