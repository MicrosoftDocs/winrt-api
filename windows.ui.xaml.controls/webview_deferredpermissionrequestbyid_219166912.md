---
-api-id: M:Windows.UI.Xaml.Controls.WebView.DeferredPermissionRequestById(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest DeferredPermissionRequestById(System.UInt32 id)
-->

# Windows.UI.Xaml.Controls.WebView.DeferredPermissionRequestById

## -description
Returns the deferred permission request with the specified [Id](webviewdeferredpermissionrequest_id.md).

## -parameters
### -param id
The [Id](webviewdeferredpermissionrequest_id.md) of the deferred permission request.

## -returns
The deferred permission request with the specified [Id](webviewdeferredpermissionrequest_id.md).

## -remarks
When you defer a [WebViewPermissionRequest](webviewpermissionrequest.md), a new [WebViewDeferredPermissionRequest](webviewdeferredpermissionrequest.md) is created with the same [Id](webviewpermissionrequest_id.md) and added to the [DeferredPermissionRequests](webview_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [DeferredPermissionRequestById](webview_deferredpermissionrequestbyid_219166912.md) method and pass the [Id](webviewdeferredpermissionrequest_id.md) of the deferred request. After you retrieve the request, you can call the [Allow](webviewdeferredpermissionrequest_allow_1592747266.md) method to grant the request, or call the [Deny](webviewdeferredpermissionrequest_deny_445869776.md) method to deny the request.

## -examples

## -see-also
[WebView.PermissionRequested](webview_permissionrequested.md)