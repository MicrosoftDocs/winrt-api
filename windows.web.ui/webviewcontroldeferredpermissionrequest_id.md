---
-api-id: P:Windows.Web.UI.WebViewControlDeferredPermissionRequest.Id
-api-type: winrt property
---

<!-- Property syntax.
public uint Id { get; }
-->

# Windows.Web.UI.WebViewControlDeferredPermissionRequest.Id

## -description
Gets the identifier for the permission request.

## -property-value
The identifier for the permission request.

## -remarks
When a [WebViewPermissionRequest](webviewcontrolpermissionrequest.md) is deferred, a **WebViewDeferredPermissionRequest** is created with the same Id and added to the [DeferredPermissionRequests](iwebviewcontrol_deferredpermissionrequests.md) collection. When you are ready to act on the request, call the [DeferredPermissionRequestById](iwebviewcontrol_getdeferredpermissionrequestbyid_614999640.md) method and pass the Id of the deferred request.

## -see-also

## -examples

