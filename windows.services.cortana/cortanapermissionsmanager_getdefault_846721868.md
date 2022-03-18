---
-api-id: M:Windows.Services.Cortana.CortanaPermissionsManager.GetDefault
-api-type: winrt method
---

<!-- Method syntax.
public CortanaPermissionsManager CortanaPermissionsManager.GetDefault()
-->

# Windows.Services.Cortana.CortanaPermissionsManager.GetDefault


## -description

Retrieves the Cortana permissions for the current user.

## -returns

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

## -examples

