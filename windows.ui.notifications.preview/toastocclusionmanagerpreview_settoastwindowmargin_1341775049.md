---
-api-id: M:Windows.UI.Notifications.Preview.ToastOcclusionManagerPreview.SetToastWindowMargin(Windows.UI.WindowId,System.Double)
-api-type: winrt method
---

# Windows.UI.Notifications.Preview.ToastOcclusionManagerPreview.SetToastWindowMargin(Windows.UI.WindowId,System.Double)

<!--
public static void SetToastWindowMargin (Windows.UI.WindowId appWindowId, double margin);
-->


## -description

Requests that the OS display app notifications with the specified vertical offset, in view pixels, in order to avoid the notification occluding content in the specified window.

## -parameters

### -param appWindowId

The **WindowId** of the window for associated with the notification offset request. For the offset to be applied, the specified window must be maximized, in focus, not right-to-left (RTL), and the onscreen keyboard must not be visible. 

### -param margin

The vertical offset with which app notifications are displayed, in view pixels.

## -remarks

This API is being released as a preview to enable testing of the feature by enterprise customers. This API is likely to be removed and/or modified in a future release. Before using the API, apps should call [LimitedAccessFeatures.TryUnlockFeature](/uwp/api/windows.applicationmodel.limitedaccessfeatures.tryunlockfeature), passing in the feature ID and app token provided by Microsoft, to verify that the app is authorized to use the API. Calls by unauthorized apps will have no effect.

## -see-also

[LimitedAccessFeatures](/uwp/api/windows.applicationmodel.limitedaccessfeatures)

## -examples


