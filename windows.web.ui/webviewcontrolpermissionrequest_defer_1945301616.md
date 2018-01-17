---
-api-id: M:Windows.Web.UI.WebViewControlPermissionRequest.Defer
-api-type: winrt method
---

<!-- Method syntax.
public void WebViewControlPermissionRequest.Defer()
-->

# Windows.Web.UI.WebViewControlPermissionRequest.Defer

## -description
Defers the permission request to be allowed or denied at a later time.

## -remarks
When you defer a **WebViewPermissionRequest**, a new **WebViewDeferredPermissionRequest** is created with the same [Id](webviewcontrolpermissionrequest_id.md) and added to the [DeferredPermissionRequests](iwebviewcontrol_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [GetDeferredPermissionRequestById](iwebviewcontrol_getdeferredpermissionrequestbyid_614999640.md) method and pass the [Id](webviewcontrolpermissionrequest_id.md) of the deferred request. After you retrieve the request, you can call the [Allow](webviewcontrolpermissionrequest_allow_1592747266.md) method to grant the request, or call the [Deny](webviewcontrolpermissionrequest_deny_445869776.md) method to deny the request.

## -see-also

## -examples

