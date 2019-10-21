---
-api-id: M:Windows.UI.ViewManagement.ApplicationView.TryUnsnap
-api-type: winrt method
---

<!-- Method syntax
public bool TryUnsnap()
-->

# Windows.UI.ViewManagement.ApplicationView.TryUnsnap

## -description
> [!NOTE]
> TryUnsnap may be altered or unavailable for releases after Windows 8.1. Apps can be continuously resized, but cannot be snapped, starting in Windows 8.1. Also, ApplicationView static methods may be altered or unavailable for releases after Windows 8.1. Use [ApplicationView.GetForCurrentView](applicationview_getforcurrentview_1363600702.md) to get an [ApplicationView](applicationview.md) object.

Attempts to unsnap a previously snapped app. This call will only succeed when the app is running in the foreground.

## -returns
**true** if the app has been successfully unsnapped; **false** if the unsnap attempt failed.

## -remarks
This is a static member of the [ApplicationView](applicationview.md) class. For JavaScript this means that it is a method of the [ApplicationView](applicationview.md) class, not of the window object that [getForCurrentView](applicationview_getforcurrentview_1363600702.md) creates.

## -examples

## -see-also
[Snap sample](https://go.microsoft.com/fwlink/p/?linkid=231523)
