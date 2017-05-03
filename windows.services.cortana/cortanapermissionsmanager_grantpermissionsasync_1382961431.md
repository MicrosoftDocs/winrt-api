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

## -remarks
The [CortanaPermissionManager](cortanapermissionsmanager.md) class requires the following be added to the Package.appmanifest:

- `<iot:Capability Name="systemManagement"/>`
- "iot" to the list of **IgnorableNamespaces**

## -see-also
[CortanaPermission](cortanapermission.md)

## -examples

