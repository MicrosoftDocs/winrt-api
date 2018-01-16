---
-api-id: E:Windows.Web.UI.IWebViewControl.PermissionRequested
-api-type: winrt event
---

<!-- Event syntax.
abstract public event TypedEventHandler PermissionRequested<IWebViewControl, WebViewControlPermissionRequestedEventArgs>
-->

# Windows.Web.UI.IWebViewControl.PermissionRequested

## -description
Occurs when an action in an IWebViewControl requires that permission be granted.

## -remarks
The types of permission that can be requested are defined in the [WebViewControlPermissionType](webviewcontrolpermissiontype.md) enumeration.

If you don't handle the **PermissionRequested** event, the WebView denies permission by default.

When you handle a permission request in a IWebViewControl, you get a [WebViewControlPermissionRequest](webviewcontrolpermissionrequest.md) object as the value of the [WebViewControlPermissionRequestedEventArgs.PermissionRequest](webviewcontrolpermissionrequestedeventargs_permissionrequest.md) property. You can call [Allow](webviewcontrolpermissionrequest_allow_1592747266.md) to grant the request, [Deny](webviewcontrolpermissionrequest_deny_445869776.md) to deny the request, or [Defer](webviewcontrolpermissionrequest_defer_1945301616.md) to defer the request until a later time. For example, you might defer the request if you need to prompt the user for consent.

When you defer a [WebViewControlPermissionRequest](webviewcontrolpermissionrequest.md), a new [WebViewControlPermissionRequest](webviewcontrolpermissionrequest.md) is created with the same Id and added to the [DeferredPermissionRequests](iwebviewcontrol_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [GetDeferredPermissionRequestById](iwebviewcontrol_getdeferredpermissionrequestbyid_614999640.md) method and pass the Id of the deferred request. After you retrieve the request, you can call the [Allow](webviewcontrolpermissionrequest_allow_1592747266.md) method to grant the request, or call the [Deny](webviewcontrolpermissionrequest_deny_445869776.md) method to deny the request.

## -see-also

## -examples

