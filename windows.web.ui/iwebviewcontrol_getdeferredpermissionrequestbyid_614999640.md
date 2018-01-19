---
-api-id: M:Windows.Web.UI.IWebViewControl.GetDeferredPermissionRequestById(System.UInt32,Windows.Web.UI.WebViewControlDeferredPermissionRequest@)
-api-type: winrt method
---

<!-- Method syntax.
public void IWebViewControl.GetDeferredPermissionRequestById(UInt32 id, WebViewControlDeferredPermissionRequest result)
-->

# Windows.Web.UI.IWebViewControl.GetDeferredPermissionRequestById

## -description
Returns the deferred permission request with the specified Id.

## -parameters
### -param id
The Id of the deferred permission request.

### -param result
The deferred permission request with the specified Id.

## -remarks
When a [WebViewPermissionRequest](webviewcontrolpermissionrequest.md) is deferred, a **WebViewDeferredPermissionRequest** is created with the same Id and added to the [DeferredPermissionRequests](iwebviewcontrol_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [DeferredPermissionRequestById](iwebviewcontrol_getdeferredpermissionrequestbyid_614999640.md) method and pass the Id of the deferred request. After you retrieve the request, you can call the Allow method to grant the request, or call the Deny method to deny the request.

## -see-also

## -examples

