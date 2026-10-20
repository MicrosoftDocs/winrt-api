---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateIdentityType
-api-type: winrt enum
---

# Windows.Management.Update.WindowsSoftwareUpdateIdentityType

<!--
public enum WindowsSoftwareUpdateIdentityType
-->


## -description

Defines constants that specify how the product targeted by a [WindowsSoftwareUpdateIdentity](./windowssoftwareupdateidentity.md) is identified.

## -enum-fields

### -field ProductCode: 0
The identity is an MSI **ProductCode** GUID that identifies an installed Windows Installer product.

### -field PackageFamilyName: 1
The identity is an MSIX/AppX **package family name** that identifies an installed application package.

## -remarks

The orchestrator validates each scan-result update against the device's installed-product inventory. The identity type tells the system which inventory to match the update against.

## -see-also

[WindowsSoftwareUpdateIdentity](./windowssoftwareupdateidentity.md)

## -examples

