---
-api-id: M:Windows.Services.Cortana.CortanaPermissionsManager.IsSupported
-api-type: winrt method
---

<!-- Method syntax.
public bool CortanaPermissionsManager.IsSupported()
-->

# Windows.Services.Cortana.CortanaPermissionsManager.IsSupported


## -description

Retrieves whether Cortana is supported.

## -returns

**true** if Cortana is supported. Otherwise, **false**.

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

