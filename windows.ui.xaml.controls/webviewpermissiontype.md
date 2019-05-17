---
-api-id: T:Windows.UI.Xaml.Controls.WebViewPermissionType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.WebViewPermissionType : int
-->

# WebViewPermissionType

## -description
Defines constants the specify the type of permission requested in a [WebView](webview.md).

## -enum-fields
### -field Geolocation:0
Permission is for geolocation.

### -field UnlimitedIndexedDBQuota:1
Permission is for unlimited **IndexedDB** data storage.

### -field Media:2
Permission is for media.

### -field PointerLock:3
Permission is for pointer lock.

### -field WebNotifications:4
Permission is for web notifications.

### -field Screen:5
Permission is for screen capture.

### -field ImmersiveView:6
Permission is for immersive view (WebVR).

## -remarks
This enumeration provides values for the [WebViewPermissionRequest.PermissionType](webviewpermissionrequest_permissiontype.md) and [WebViewDeferredPermissionRequest.PermissionType](webviewdeferredpermissionrequest_permissiontype.md) properties.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | PointerLock |
| 1607 | 14393 | WebNotifications |
| 1803 | 17134 | ImmersiveView |
| 1803 | 17134 | Screen |

## -examples

## -see-also
[WebViewPermissionRequest.PermissionType](webviewpermissionrequest_permissiontype.md), [WebViewDeferredPermissionRequest.PermissionType](webviewdeferredpermissionrequest_permissiontype.md)

