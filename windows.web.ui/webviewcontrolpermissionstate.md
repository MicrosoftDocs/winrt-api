---
-api-id: T:Windows.Web.UI.WebViewControlPermissionState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum WebViewControlPermissionState : int 
-->

# Windows.Web.UI.WebViewControlPermissionState

## -description
Defines constants that specify the state of a [IWebViewControl.PermissionRequested](iwebviewcontrol_permissionrequested.md) event.

## -enum-fields
### -field Unknown:0
The state of the permission request can't be determined.

### -field Deny:3	
[WebViewPermissionRequest.Deny](webviewcontrolpermissionrequest_deny_445869776.md) was called. The permission request is denied.

### -field Defer:1
[WebViewPermissionRequest.Defer](webviewcontrolpermissionrequest_defer_1945301616.md) was called. The permission request is deferred.

### -field Allow:2
[WebViewPermissionRequest.Allow](webviewcontrolpermissionrequest_allow_1592747266.md) was called. The permission request is allowed.

## -remarks

## -see-also

## -examples

