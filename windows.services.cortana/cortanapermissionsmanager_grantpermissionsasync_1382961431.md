---
-api-id: M:Windows.Services.Cortana.CortanaPermissionsManager.GrantPermissionsAsync(Windows.Foundation.Collections.IIterable{Windows.Services.Cortana.CortanaPermission})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<CortanaPermissionsChangeResult> CortanaPermissionsManager.GrantPermissionsAsync(IIterable<CortanaPermission> permissions)
-->

# Windows.Services.Cortana.CortanaPermissionsManager.GrantPermissionsAsync

## -description

Asynchronously grants the specified set of Cortana permissions.

## -parameters

### -param permissions

The collection of [permissions](cortanapermission.md) to grant.

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
