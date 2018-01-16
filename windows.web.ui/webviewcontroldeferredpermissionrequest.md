---
-api-id: T:Windows.Web.UI.WebViewControlDeferredPermissionRequest
-api-type: winrt class
---

<!-- Class syntax.
public class WebViewControlDeferredPermissionRequest 
-->

# Windows.Web.UI.WebViewControlDeferredPermissionRequest

## -description
Represents a deferred request for permissions in an [IWebViewControl](iwebviewcontrol.md).

## -remarks
For more info, see the [IWebViewControl.PermissionRequested](iwebviewcontrol_permissionrequested.md) event.

When a [WebViewPermissionRequest](webviewcontrolpermissionrequest.md) is deferred, a **WebViewDeferredPermissionRequest** is created with the same Id and added to the [DeferredPermissionRequests](iwebviewcontrol_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [DeferredPermissionRequestById](iwebviewcontrol_getdeferredpermissionrequestbyid_614999640.md) method and pass the Id of the deferred request. After you retrieve the request, you can call the Allow method to grant the request, or call the Deny method to deny the request.

## -see-also

## -examples

