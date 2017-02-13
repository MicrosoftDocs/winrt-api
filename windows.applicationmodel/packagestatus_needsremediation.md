---
-api-id: P:Windows.ApplicationModel.PackageStatus.NeedsRemediation
-api-type: winrt property
---

<!-- Property syntax
public bool NeedsRemediation { get; }
-->

# Windows.ApplicationModel.PackageStatus.NeedsRemediation

## -description
Indicates whether the package is unusable.

## -property-value
**FALSE** indicates that the package is in a usable state; otherwise **TRUE**.

## -remarks
This property reflects a set of properties that you would otherwise have to query individually to determine if the package is usable. For example this property reflects whether one or more of [NotAvailable](packagestatus_notavailable.md), [LicenseIssue](packagestatus_licenseissue.md), [Modified](packagestatus_modified.md), or [Tampered](packagestatus_tampered.md) are set.

## -examples

## -see-also
