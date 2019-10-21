---
-api-id: T:Windows.UI.Xaml.Controls.WebViewPermissionRequest
-api-type: winrt class
---

<!-- Class syntax.
public class WebViewPermissionRequest : Windows.UI.Xaml.Controls.IWebViewPermissionRequest
-->

# Windows.UI.Xaml.Controls.WebViewPermissionRequest

## -description
Represents a request for permissions in a [WebView](webview.md).

## -remarks
For more info, see the [WebView.PermissionRequested](webview_permissionrequested.md) event.

When you handle a permission request in a [WebView](webview.md), you get a WebViewPermissionRequest object as the value of the [WebViewPermissionRequestedEventArgs.PermissionRequest](webviewpermissionrequestedeventargs_permissionrequest.md) property. You can call [Allow](webviewpermissionrequest_allow_1592747266.md) to grant the request, [Deny](webviewpermissionrequest_deny_445869776.md) to deny the request, or [Defer](webviewpermissionrequest_defer_1945301616.md) to defer the request until a later time. For example, you might defer the request if you need to prompt the user for consent.

## -examples

## -see-also
[WebView.PermissionRequested](webview_permissionrequested.md), [WebViewPermissionRequestedEventArgs.PermissionRequest](webviewpermissionrequestedeventargs_permissionrequest.md)
