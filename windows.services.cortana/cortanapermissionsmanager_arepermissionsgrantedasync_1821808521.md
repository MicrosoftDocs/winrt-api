---
-api-id: M:Windows.Services.Cortana.CortanaPermissionsManager.ArePermissionsGrantedAsync(Windows.Foundation.Collections.IIterable{Windows.Services.Cortana.CortanaPermission})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> CortanaPermissionsManager.ArePermissionsGrantedAsync(IIterable<CortanaPermission> permissions)
-->

# Windows.Services.Cortana.CortanaPermissionsManager.ArePermissionsGrantedAsync

## -description
Asynchronously retreives whether the specified permissions are granted.

## -parameters

### -param permissions
The collection of [permissions](cortanapermission.md) of interest.

## -returns
**true** if permission is granted. Otherwise, **false**.

## -remarks
The [CortanaPermissionManager](cortanapermissionsmanager.md) class requires the following be added to the Package.appmanifest:

- `<rescap:capability name="cortanaPermissions"/> `
- "rescap" to the list of **IgnorableNamespaces**

## -see-also
[CortanaPermission](cortanapermission.md)

## -examples


## -capabilities
cortanaPermissions
