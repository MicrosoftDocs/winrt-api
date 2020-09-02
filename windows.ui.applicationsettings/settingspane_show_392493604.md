---
-api-id: M:Windows.UI.ApplicationSettings.SettingsPane.Show
-api-type: winrt method
---

<!-- Method syntax
public void Show()
-->

# Windows.UI.ApplicationSettings.SettingsPane.Show

## -description
> [!NOTE]
> [SettingsPane](settingspane.md) is deprecated, and might not work on all versions of Windows 10. Instead of using a [SettingsPane](settingspane.md), integrate settings options into the app experience. For more info, see [Guidelines for app settings](/windows/uwp/app-settings/guidelines-for-app-settings).

Displays the Settings Charm pane to the user.

## -remarks

The Show method raises an exception if one of the following is true:

+ It is called from a snapped app.
+ It is called when the current app does not have focus.
+ It is called when the pane is already displayed.


## -examples

## -see-also
