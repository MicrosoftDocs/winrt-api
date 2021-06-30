---
-api-id: T:Windows.Services.Cortana.CortanaPermissionsChangeResult
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum CortanaPermissionsChangeResult : int 
-->

# Windows.Services.Cortana.CortanaPermissionsChangeResult

## -description

Specifies the possible results from setting permissions using the [CortanaPermissionsManager](cortanapermissionsmanager.md).

## -enum-fields

### -field Unavailable:1

Setting one or more permissions failed.

### -field Success:0

Setting all permissions succeeded.

### -field DisabledByPolicy:2

Changes to settings are not permitted.

## -capabilities

cortanaPermissions

## -remarks

The [CortanaPermissionManager](cortanapermissionsmanager.md) class requires the following be added to the Package.appmanifest:

- To \<Package\>
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
  - `IgnorableNamespaces="rescap"`
- Under \<Capabilities\>
  - `<rescap:capability name="cortanaPermissions"/>`

- "iot" to the list of **IgnorableNamespaces**
  - `<iot:Capability Name="systemManagement"/>`

## -see-also

[CortanaPermission](cortanapermission.md), [CortanaPermissionManager](cortanapermissionsmanager.md), [CortanaPermissionsManager.ArePermissionsGrantedAsync](cortanapermissionsmanager_arepermissionsgrantedasync_1821808521.md), [CortanaPermissionsManager.GrantPermissionsAsync](cortanapermissionsmanager_grantpermissionsasync_1382961431.md), [CortanaPermissionsManager.RevokePermissionsAsync](cortanapermissionsmanager_revokepermissionsasync_517405145.md)

## -examples