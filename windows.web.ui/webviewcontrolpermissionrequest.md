---
-api-id: T:Windows.Web.UI.WebViewControlPermissionRequest
-api-type: winrt class
---

<!-- Class syntax.
public class WebViewControlPermissionRequest 
-->

# Windows.Web.UI.WebViewControlPermissionRequest

## -description
Represents a request for permissions in a WebView.

## -remarks
For more info, see the [IWebViewControl.PermissionRequested](C:\Users\misatran\Desktop\Clones\winrt-api\windows.web.ui\iwebviewcontrol_permissionrequested.md) event.

When you handle a permission request in an [IWebViewControl](iwebviewcontrol.md), you get a [WebViewControlPermissionRequest](webviewcontrolpermissionrequestedeventargs.md) object as the value of the [WebViewPermissionRequestedEventArgs.PermissionRequest](webviewcontrolpermissionrequestedeventargs_permissionrequest.md) property. You can call [Allow](webviewcontrolpermissionrequest_allow_1592747266.md) to grant the request, [Deny](webviewcontroldeferredpermissionrequest_deny_445869776.md) to deny the request, or [Defer](webviewcontrolpermissionrequest_defer_1945301616.md) to defer the request until a later time. For example, you might defer the request if you need to prompt the user for consent.

## -see-also

## -examples

