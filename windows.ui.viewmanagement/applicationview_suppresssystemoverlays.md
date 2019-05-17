---
-api-id: P:Windows.UI.ViewManagement.ApplicationView.SuppressSystemOverlays
-api-type: winrt property
---

<!-- Property syntax
public bool SuppressSystemOverlays { get;  set; }
-->

# Windows.UI.ViewManagement.ApplicationView.SuppressSystemOverlays

## -description
> [!NOTE]
> SuppressSystemOverlays may be altered or unavailable for releases after Windows 10. Instead, use [TryEnterFullScreenMode](applicationview_tryenterfullscreenmode_1643702755.md) and [FullScreenSystemOverlayMode](applicationview_fullscreensystemoverlaymode.md).

Gets or sets a value indicating whether or not system overlays (such as overlay applications or the soft steering wheel) should be shown.

## -property-value
**true** if system overlays (such as overlay applications or the soft steering wheel) should be shown; otherwise, **false**.

## -remarks
> **Windows 10**
> For Universal Windows Platform (UWP) app on Windows 10, this property is deprecated. This property has an effect only on the mobile device family.

To launch your app in full screen mode, set [PreferredLaunchWindowingMode](applicationview_preferredlaunchwindowingmode.md) to **FullScreen**. To enter full screen mode after your app is launched, call [TryEnterFullScreenMode](applicationview_tryenterfullscreenmode_1643702755.md). To exit full screen mode, call [ExitFullScreenMode](applicationview_exitfullscreenmode_1516691675.md).

To suppress edge gestures, set [FullScreenSystemOverlayMode](applicationview_fullscreensystemoverlaymode.md) to **Minimal**.

> **Windows Phone 8.1**
> You can set your app to "full-screen" by setting this property to **true**. A full-screen app, such as a game, is not occluded by overlay apps. An overlay app is one that shows its UI in the Overlay Layer, which is positioned in a layer above the app and lock layers, but below certain other chrome elements (such as the SIP). An example of an overlay app is an instant messaging app that displays a UI that overlays the app below.

In addition, by setting **SuppressSystemOverlays** to **true**, accidental taps of the Search button are far less likely to affect the app. When **SuppressSystemOverlays** is set to **true**, the user must tap the Search button twice in close succession to actuate the Search experience, which overlays the running app. We recommend using this property to opt into this behavior only in these cases: user feedback shows that accidental taps of the Search button are likely based on the layout of your app; if your app shows full-screen media content; or if your app uses camera functionality or the viewfinder.

**SuppressSystemOverlays** is **true** by default for an app associated with the Games category, and **false** by default for an application associated with any other category.

## -examples

## -see-also
