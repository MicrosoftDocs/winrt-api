---
-api-id: E:Windows.UI.ApplicationSettings.SettingsPane.CommandsRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler CommandsRequested<Windows.UI.ApplicationSettings.SettingsPane,  Windows.UI.ApplicationSettings.SettingsPaneCommandsRequestedEventArgs>
-->

# Windows.UI.ApplicationSettings.SettingsPane.CommandsRequested

## -description
> [!NOTE]
> [SettingsPane](settingspane.md) is deprecated, and might not work on all versions of Windows 10. Instead of using a [SettingsPane](settingspane.md), integrate settings options into the app experience. For more info, see [Guidelines for app settings](/windows/uwp/app-settings/guidelines-for-app-settings).

Occurs when the user opens the settings pane. Listening for this event lets the app initialize the setting commands and pause its UI until the user closes the pane.

During this event, append your [SettingsCommand](settingscommand.md) objects to the available [ApplicationCommands](settingspanecommandsrequest_applicationcommands.md) vector to make them available to the [SettingsPane](settingspane.md)UI.

## -remarks

## -examples

## -see-also
