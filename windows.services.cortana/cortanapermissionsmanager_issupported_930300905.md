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

## -parameters

## -returns
**true** if Cortana is supported. Otherwise, **false**.

## -remarks
The [CortanaPermissionManager](cortanapermissionsmanager.md) class requires the following be added to the Package.appmanifest:

- `<iot:Capability Name="systemManagement"/>`
- "iot" to the list of **IgnorableNamespaces**

## -see-also

## -examples

