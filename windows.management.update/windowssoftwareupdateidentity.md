---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateIdentity
-api-type: winrt class
---

# Windows.Management.Update.WindowsSoftwareUpdateIdentity

<!--
public sealed class WindowsSoftwareUpdateIdentity
-->


## -description

Identifies the installed product that a [WindowsSoftwareUpdate](./windowssoftwareupdate.md) targets, either by MSI product code or by MSIX package family name.

## -remarks

The orchestrator validates each scan-result update against the device's installed-product inventory. An update whose identity doesn't match an installed product is rejected, so the identity must correspond to a product that's actually installed on the device.

## -see-also

[WindowsSoftwareUpdateIdentityType](./windowssoftwareupdateidentitytype.md), [WindowsSoftwareUpdate](./windowssoftwareupdate.md)

## -examples

