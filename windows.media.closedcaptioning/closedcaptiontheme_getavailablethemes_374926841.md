---
-api-id: M:Windows.Media.ClosedCaptioning.ClosedCaptionTheme.GetAvailableThemes
-api-type: winrt method
---

# Windows.Media.ClosedCaptioning.ClosedCaptionTheme.GetAvailableThemes

<!--
public static Windows.Media.ClosedCaptioning.ClosedCaptionTheme[] GetAvailableThemes ();
-->


## -description

Gets the available closed caption themes.

## -returns

An array of [ClosedCaptionTheme](closedcaptiontheme.md) objects representing the available themes at the time of the call.

## -remarks

The returned array is a snapshot and is not updated if themes are added, removed, or modified after this method is called. Subscribe to [ThemesChanged](closedcaptiontheme_themeschanged.md) to detect changes.

## -see-also

## -examples


