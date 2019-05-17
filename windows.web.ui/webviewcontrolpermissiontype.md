---
-api-id: T:Windows.Web.UI.WebViewControlPermissionType
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum WebViewControlPermissionType : int 
-->

# Windows.Web.UI.WebViewControlPermissionType

## -description
Defines constants the specify the type of permission requested in a [IWebViewControl](iwebviewcontrol.md).

## -enum-fields
### -field WebNotifications:4
Permission is for web notifications.

### -field UnlimitedIndexedDBQuota:1
Permission is for unlimited **IndexedDB** data storage.

### -field Screen:5
Permission is for screen.

### -field PointerLock:3
Permission is for pointer lock.

### -field Media:2
Permission is for media.

### -field Geolocation:0
Permission is for geolocation.

### -field ImmersiveView:6
Permission is for the ImmersiveView.

## -remarks
This enumeration provides values for the [WebViewPermissionRequest.PermissionType](webviewcontrolpermissionrequest_permissiontype.md) and [WebViewDeferredPermissionRequest.PermissionType](webviewcontroldeferredpermissionrequest_permissiontype.md) properties.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | ImmersiveView |

## -see-also

## -examples
