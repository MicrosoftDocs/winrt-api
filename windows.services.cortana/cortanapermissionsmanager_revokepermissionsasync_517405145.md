---
-api-id: M:Windows.Services.Cortana.CortanaPermissionsManager.RevokePermissionsAsync(Windows.Foundation.Collections.IIterable{Windows.Services.Cortana.CortanaPermission})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<CortanaPermissionsChangeResult> CortanaPermissionsManager.RevokePermissionsAsync(IIterable<CortanaPermission> permissions)
-->

# Windows.Services.Cortana.CortanaPermissionsManager.RevokePermissionsAsync

## -description

Asynchronously revokes the specified set of Cortana permissions.

## -parameters

### -param permissions

The collection of [permissions](cortanapermission.md) to revoke.

## -returns

The result of the permission operation.

## -capabilities

cortanaPermissions

## -remarks

The [CortanaPermissionManager](cortanapermissionsmanager.md) class requires the following be added to the Package.appmanifest:

- To \<Package\>
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
  - `IgnorableNamespaces="rescap"`
- Under \<Capabilities\>
  - `<rescap:capability name="cortanaPermissions"/>`

## -see-also

[CortanaPermission](cortanapermission.md)

## -examples
