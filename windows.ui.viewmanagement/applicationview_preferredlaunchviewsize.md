---
-api-id: P:Windows.UI.ViewManagement.ApplicationView.PreferredLaunchViewSize
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Size PreferredLaunchViewSize { get;  set; }
-->

# Windows.UI.ViewManagement.ApplicationView.PreferredLaunchViewSize

## -description
Gets or sets the size that the app launches with when the [ApplicationView.PreferredLaunchWindowingMode](applicationview_preferredlaunchwindowingmode.md) property is set to **PreferredLaunchViewSize**, except in cases where the system manages the window size directly.

## -property-value
The size that the app launches with when the [ApplicationView.PreferredLaunchWindowingMode](applicationview_preferredlaunchwindowingmode.md) property is set to **PreferredLaunchViewSize**, except in cases where the system manages the window size directly.

## -remarks
This property only has an effect when the app is launched on a desktop device that is not in Tablet mode.

For the very first launch of an app the [PreferredLaunchWindowingMode](applicationview_preferredlaunchwindowingmode.md) will always be **Auto** and the [ApplicationView.PreferredLaunchViewSize](applicationview_preferredlaunchviewsize.md) will be determined by system policies. The API applies to the next launch of the app.

## -examples

## -see-also
[Window resizing sample](https://go.microsoft.com/fwlink/p/?LinkId=620026)
