---
-api-id: M:Windows.UI.Xaml.Controls.SettingsFlyout.Hide
-api-type: winrt method
---

<!-- Method syntax
public void Hide()
-->

# Windows.UI.Xaml.Controls.SettingsFlyout.Hide

## -description
Closes the Settings flyout.

## -remarks
By default, the settings flyout is dismissed when the user presses the back button, and is always light-dismissed when the user taps outside of it. In most cases, you will not need to call the [Hide](settingsflyout_hide_1985563870.md) method to dismiss the settings flyout.

Calling the [Hide](settingsflyout_hide_1985563870.md) method has the same behavior as light dismiss. It always returns the user to your app and closes the settings pane, regardless of whether the settings flyout was opened by calling [Show](settingsflyout_show_392493604.md) or [ShowIndependent](settingsflyout_showindependent_61271159.md).

## -examples

## -see-also
