---
-api-id: P:Windows.ApplicationModel.PackageStatus.NotAvailable
-api-type: winrt property
---

<!-- Property syntax
public bool NotAvailable { get; }
-->

# Windows.ApplicationModel.PackageStatus.NotAvailable

## -description
Indicates whether the package is available.

## -property-value
**TRUE** indicates that the package is not available; otherwise **FALSE**.

## -remarks
A package may be unavailable for multiple reasons. This property reflects a set of properties that you would otherwise have to query individually to determine if the package is unavailable. For example this property reflects whether one or more of [DataOffline](packagestatus_dataoffline.md), [Disabled](packagestatus_disabled.md), or [PackageOffline](packagestatus_packageoffline.md) is set.

## -examples

## -see-also
