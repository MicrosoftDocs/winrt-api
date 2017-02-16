---
-api-id: M:Windows.UI.ApplicationSettings.SettingsPane.GetForCurrentView
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.ApplicationSettings.SettingsPane GetForCurrentView()
-->

# Windows.UI.ApplicationSettings.SettingsPane.GetForCurrentView

## -description
> [!NOTE]
> [SettingsPane](settingspane.md) may be altered or unavailable for releases after Windows 10. Instead of using a [SettingsPane](settingspane.md), integrate settings options into the app experience. For more info, see [Guidelines for app settings](http://msdn.microsoft.com/library/2d765e90-3fa0-42f5-a5cb-bedc14c3f60a).

Gets a [SettingsPane](settingspane.md) object that is associated with the current app view (that is, with [CoreWindow](../windows.ui.core/corewindow.md)).

## -returns
The settings pane.

## -remarks
If you're creating an app with XAML, you should override OnWindowCreated in App.xaml.cs/vb/cpp to register the [CommandsRequested](settingspane_commandsrequested.md) event there.

## -examples

## -see-also
