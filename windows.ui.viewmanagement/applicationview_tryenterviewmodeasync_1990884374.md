---
-api-id: M:Windows.UI.ViewManagement.ApplicationView.TryEnterViewModeAsync(Windows.UI.ViewManagement.ApplicationViewMode,Windows.UI.ViewManagement.ViewModePreferences)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> ApplicationView.TryEnterViewModeAsync(ApplicationViewMode viewMode, ViewModePreferences viewModePreferences)
-->

# Windows.UI.ViewManagement.ApplicationView.TryEnterViewModeAsync

## -description
Attempts to change the app view to the specified view mode using the specified options. 

## -parameters

### -param viewMode
A value of the enumeration that indicates the desired view mode.

### -param viewModePreferences
Preferred settings for the desired view mode.

## -returns
**true** if the app view was changed to the specified view mode; otherwise, **false**.

## -remarks
The view mode preferences are requested values only. The system might override these values when your app is changed to the new view mode.

## -see-also

## -examples

