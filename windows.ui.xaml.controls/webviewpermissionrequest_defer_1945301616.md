---
-api-id: M:Windows.UI.Xaml.Controls.WebViewPermissionRequest.Defer
-api-type: winrt method
---

<!-- Method syntax
public void Defer()
-->

# Windows.UI.Xaml.Controls.WebViewPermissionRequest.Defer

## -description
Defers the permission request to be allowed or denied at a later time.

## -remarks
When you defer a [WebViewPermissionRequest](webviewpermissionrequest.md), a new [WebViewDeferredPermissionRequest](webviewdeferredpermissionrequest.md) is created with the same [Id](webviewpermissionrequest_id.md) and added to the [DeferredPermissionRequests](webview_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [DeferredPermissionRequestById](webview_deferredpermissionrequestbyid.md) method and pass the [Id](webviewdeferredpermissionrequest_id.md) of the deferred request. After you retrieve the request, you can call the [Allow](webviewdeferredpermissionrequest_allow.md) method to grant the request, or call the [Deny](webviewdeferredpermissionrequest_deny.md) method to deny the request.

## -examples

## -see-also
