---
-api-id: T:Windows.Services.Cortana.CortanaPermissionsManager
-api-type: winrt class
---

<!-- Class syntax.
public class CortanaPermissionsManager 
-->

# Windows.Services.Cortana.CortanaPermissionsManager

## -description

Provides access to the users Cortana authorization settings.

## -capabilities

cortanaPermissions

## -remarks

This is a static class, you do not need to get a CortanaPermissionsManager object to access its members.

The CortanaPermissionManager class requires the following be added to the Package.appmanifest:

- To \<Package\>
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
  - `IgnorableNamespaces="rescap"`
- Under \<Capabilities\>
  - `<rescap:capability name="cortanaPermissions"/>`

## -see-also

## -examples
