---
-api-id: T:Windows.UI.Xaml.Controls.WebViewPermissionState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.WebViewPermissionState : int
-->

# WebViewPermissionState

## -description
Defines constants that specify the state of a [WebView.PermissionRequested](webview_permissionrequested.md) event.

## -enum-fields
### -field Unknown:0
The state of the permission request can't be determined.

### -field Defer:1
[WebViewPermissionRequest.Defer](webviewpermissionrequest_defer.md) was called. The permission request is deferred.

### -field Allow:2
[WebViewPermissionRequest.Allow](webviewpermissionrequest_allow.md) was called. The permission request is allowed.

### -field Deny:3
[WebViewPermissionRequest.Deny](webviewpermissionrequest_deny.md) was called. The permission request is denied.


## -remarks
This enumeration provides values for the [WebViewPermissionRequest.State](webviewpermissionrequest_state.md) property.

## -examples

## -see-also
[WebView.PermissionRequested](webview_permissionrequested.md), [WebViewPermissionRequest.State](webviewpermissionrequest_state.md)