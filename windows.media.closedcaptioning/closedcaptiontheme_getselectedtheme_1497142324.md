---
-api-id: M:Windows.Media.ClosedCaptioning.ClosedCaptionTheme.GetSelectedTheme
-api-type: winrt method
---

# Windows.Media.ClosedCaptioning.ClosedCaptionTheme.GetSelectedTheme

<!--
public static Windows.Media.ClosedCaptioning.ClosedCaptionTheme GetSelectedTheme ();
-->


## -description

Gets the currently selected closed caption theme.

## -returns

A [ClosedCaptionTheme](closedcaptiontheme.md) object representing the currently selected theme at the time of the call.

## -remarks

The returned object is a snapshot and is not updated if the selected theme changes after this method is called. Subscribe to [SelectedThemeChanged](closedcaptiontheme_selectedthemechanged.md) to detect changes.

## -see-also

## -examples


