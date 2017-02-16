---
-api-id: P:Windows.UI.Xaml.Controls.WebView.DeferredPermissionRequests
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest> DeferredPermissionRequests { get; }
-->

# Windows.UI.Xaml.Controls.WebView.DeferredPermissionRequests

## -description
Gets a collection of permission requests that are waiting to be granted or denied.

## -property-value
A collection of [WebViewDeferredPermissionRequest](webviewdeferredpermissionrequest.md) objects that are waiting to be granted or denied.

## -remarks
When you defer a [WebViewPermissionRequest](webviewpermissionrequest.md), a new [WebViewDeferredPermissionRequest](webviewdeferredpermissionrequest.md) is created with the same [Id](webviewpermissionrequest_id.md) and added to the [DeferredPermissionRequests](webview_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [DeferredPermissionRequestById](webview_deferredpermissionrequestbyid.md) method and pass the [Id](webviewdeferredpermissionrequest_id.md) of the deferred request. After you retrieve the request, you can call the [Allow](webviewdeferredpermissionrequest_allow.md) method to grant the request, or call the [Deny](webviewdeferredpermissionrequest_deny.md) method to deny the request.

## -examples

## -see-also
[DeferredPermissionRequestById](webview_deferredpermissionrequestbyid.md), [WebViewDeferredPermissionRequest](webviewdeferredpermissionrequest.md)