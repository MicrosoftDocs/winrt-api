---
-api-id: P:Windows.UI.ViewManagement.UISettings.AutoHideScrollBars
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool AutoHideScrollBars { get; }
-->

# Windows.UI.ViewManagement.UISettings.AutoHideScrollBars

## -description

Gets whether the user has specified that scroll bars should be automatically hidden when not being interacted with.

## -property-value

True, if **Settings -> Ease of Access -> Display -> Automatically hide scroll bars in Windows** is set. Otherwise, false.

## -remarks

This property is intended for handling mouse cursor proximity in custom UI frameworks and custom scroll bar implementations.

This property returns the specified user setting, not whether a specific scroll bar is visible.

You must manage all view updates that might be required when hiding or displaying the scroll bar.

## -see-also

[AutoHideScrollBarsChanged](uisettings_autohidescrollbarschanged.md), [UISettingsAutoHideScrollBarsChangedEventArgs](uisettingsautohidescrollbarschangedeventargs.md)

## -examples
