---
-api-id: T:Windows.UI.ViewManagement.ViewModePreferences
-api-type: winrt class
---

<!-- Class syntax.
public class ViewModePreferences 
-->

# Windows.UI.ViewManagement.ViewModePreferences

## -description

Represents the preferred settings to be applied to a view when it's changed to a new view mode.

## -remarks

To get an instance of **ViewModePreferences**, call the [CreateDefault](viewmodepreferences_createdefault_1698970327.md) method.

These view mode preferences are requested values only. The system might override these values when your app is changed to the new view mode. Custom sizes that you specify are not guaranteed to be honored by Windows, so you should not write code that relies on never getting into a size that is smaller than the preferred minimum size or larger than the preferred maximum size. No error is returned when a preferred size is ignored.

## -see-also

## -examples

