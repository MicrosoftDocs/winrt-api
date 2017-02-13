---
-api-id: P:Windows.UI.ViewManagement.ApplicationView.Value
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.ViewManagement.ApplicationViewState Value { get; }
-->

# Windows.UI.ViewManagement.ApplicationView.Value

## -description
> [!NOTE]
> ApplicationView static methods may be altered or unavailable for releases after Windows 8.1. Instead, use [ApplicationView.GetForCurrentView](applicationview_getforcurrentview.md) to get an [ApplicationView](applicationview.md) object.

Gets the state of the current window (app view).

## -property-value
The state of the current window (app view). This state indicates the orientation (landscape or portrait) and whether or not the app is snapped.

## -remarks
To respond to a view state change, an app queries this property from inside the app window resize event handler to determine how to lay out the app in the changed view state.

This is a static member of the [ApplicationView](applicationview.md) class. For JavaScript this means that it is a method of the [ApplicationView](applicationview.md) class, not of the window object that [getForCurrentView](applicationview_getforcurrentview.md) creates.

## -examples

## -see-also
