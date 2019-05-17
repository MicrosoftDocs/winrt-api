---
-api-id: E:Windows.UI.Xaml.Controls.WebView.PermissionRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PermissionRequested<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewPermissionRequestedEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.PermissionRequested

## -description
Occurs when an action in a [WebView](webview.md) requires that permission be granted.

## -remarks
The types of permission that can be requested are defined in the [WebViewPermissionType](webviewpermissiontype.md) enumeration.

If you don't handle the PermissionRequested event, the [WebView](webview.md) denies permission by default.

When you handle a permission request in a [WebView](webview.md), you get a [WebViewPermissionRequest](webviewpermissionrequest.md) object as the value of the [WebViewPermissionRequestedEventArgs.PermissionRequest](webviewpermissionrequestedeventargs_permissionrequest.md) property. You can call [Allow](webviewpermissionrequest_allow_1592747266.md) to grant the request, [Deny](webviewpermissionrequest_deny_445869776.md) to deny the request, or [Defer](webviewpermissionrequest_defer_1945301616.md) to defer the request until a later time. For example, you might defer the request if you need to prompt the user for consent.

When you defer a [WebViewPermissionRequest](webviewpermissionrequest.md), a new [WebViewDeferredPermissionRequest](webviewdeferredpermissionrequest.md) is created with the same [Id](webviewpermissionrequest_id.md) and added to the [DeferredPermissionRequests](webview_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [DeferredPermissionRequestById](webview_deferredpermissionrequestbyid_219166912.md) method and pass the [Id](webviewdeferredpermissionrequest_id.md) of the deferred request. After you retrieve the request, you can call the [Allow](webviewdeferredpermissionrequest_allow_1592747266.md) method to grant the request, or call the [Deny](webviewdeferredpermissionrequest_deny_445869776.md) method to deny the request.

## -examples

## -see-also
[WebViewPermissionRequestedEventArgs](webviewpermissionrequestedeventargs.md)
