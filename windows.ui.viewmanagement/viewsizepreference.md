---
-api-id: T:Windows.UI.ViewManagement.ViewSizePreference
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.ViewManagement.ViewSizePreference : int
-->

# ViewSizePreference

## -description
Defines the set of possible general window (app view) size preferences.

## -enum-fields
### -field Default:0
The app does not have a window size preference specified. Windows, rather than the app, sets the size preference, which defaults to **UseHalf**.

### -field UseLess:1
The window uses less than 50% of the available horizontal screen pixels.

### -field UseHalf:2
The window uses 50% (half) of the available horizontal screen pixels.

### -field UseMore:3
The window uses more than 50% of the available horizontal screen pixels.

### -field UseMinimum:4
The window uses the minimum horizontal pixel width (either 320 or 500 pixels) specifies in the app's manifest (such as package.appxmanifest).

### -field UseNone:5
The window has no visible component.

### -field Custom:6
The window uses a custom preferred size specifed in the app.

## -remarks
An "app view" is the displayed portion of a Windows Store app, and which can be variably sized by the user. A user's screen can have up to 4 app views of variable width displayed simultaneously, with a combined horizontal pixel width equal to that of the display device's horizontal resolution.

### Custom view sizes
Set the [ViewModePreferences.ViewSizePreference](viewmodepreferences_viewsizepreference.md) property value to **Custom** when you set the [ViewModePreferences.CustomSize](viewmodepreferences_customsize.md) property.

## -examples

## -see-also
