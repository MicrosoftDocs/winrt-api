---
-api-id: T:Windows.Media.ClosedCaptioning.ClosedCaptionTheme
-api-type: winrt class
---

# Windows.Media.ClosedCaptioning.ClosedCaptionTheme

<!--
public sealed class ClosedCaptionTheme
-->


## -description

Represents a closed caption theme, providing access to the display name, unique identifier, and formatting settings for the theme. Use the static methods of this class to get available themes, get or set the selected theme, and subscribe to theme change notifications.

## -remarks

A **ClosedCaptionTheme** object is a snapshot of a theme's settings at the time it was retrieved. The object is not updated if the user modifies the theme through the Windows Settings app. Use the [ThemesChanged](closedcaptiontheme_themeschanged.md) and [SelectedThemeChanged](closedcaptiontheme_selectedthemechanged.md) events to detect changes and retrieve updated theme data.

Setting a theme through [TrySetSelectedTheme](closedcaptiontheme_trysetselectedtheme_533743757.md) changes the system-wide closed caption theme for the current user, affecting all applications that render closed captions.

## -see-also

[ClosedCaptionProperties](closedcaptionproperties.md)

## -examples


