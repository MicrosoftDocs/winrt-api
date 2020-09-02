---
-api-id: P:Windows.UI.ApplicationSettings.SettingsPaneCommandsRequest.ApplicationCommands
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.UI.ApplicationSettings.SettingsCommand> ApplicationCommands { get; }
-->

# Windows.UI.ApplicationSettings.SettingsPaneCommandsRequest.ApplicationCommands

## -description
> [!NOTE]
> [SettingsPaneCommandsRequest](settingspanecommandsrequest.md) is deprecated, and might not work on all versions of Windows 10. Instead of using a [SettingsPane](settingspane.md), integrate settings options into the app experience. For more info, see [Guidelines for app settings](/windows/uwp/app-settings/guidelines-for-app-settings).

A vector that is available during the [CommandsRequested](settingspane_commandsrequested.md) event. Append [SettingsCommand](settingscommand.md) objects to it to make them available to the [SettingsPane](settingspane.md)UI.

## -property-value
The vector of [SettingsCommand](settingscommand.md) objects.

## -remarks

## -examples

## -see-also
