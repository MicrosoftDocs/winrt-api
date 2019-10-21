---
-api-id: T:Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest
-api-type: winrt class
---

<!-- Class syntax.
public class WebViewDeferredPermissionRequest : Windows.UI.Xaml.Controls.IWebViewDeferredPermissionRequest
-->

# Windows.UI.Xaml.Controls.WebViewDeferredPermissionRequest

## -description
Represents a deferred request for permissions in a [WebView](webview.md).

## -remarks
For more info, see the [WebView.PermissionRequested](webview_permissionrequested.md) event.

When a [WebViewPermissionRequest](webviewpermissionrequest.md) is deferred, a WebViewDeferredPermissionRequest is created with the same [Id](webviewpermissionrequest_id.md) and added to the [DeferredPermissionRequests](webview_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [DeferredPermissionRequestById](webview_deferredpermissionrequestbyid_219166912.md) method and pass the [Id](webviewdeferredpermissionrequest_id.md) of the deferred request. After you retrieve the request, you can call the [Allow](webviewdeferredpermissionrequest_allow_1592747266.md) method to grant the request, or call the [Deny](webviewdeferredpermissionrequest_deny_445869776.md) method to deny the request.

## -examples

## -see-also
