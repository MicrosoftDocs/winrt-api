---
-api-id: M:Windows.ApplicationModel.PackageStatus.VerifyIsOK
-api-type: winrt method
---

<!-- Method syntax
public bool VerifyIsOK()
-->

# Windows.ApplicationModel.PackageStatus.VerifyIsOK

## -description
Indicates whether the package is in good condition and may be used.

## -returns
**TRUE** indicates that the package is in good condition; otherwise **FALSE**.

## -remarks
This property reflects a set of properties that you would otherwise have to query individually to determine if the package is in good condition and is usable. For example this property reflects whether [NotAvailable](packagestatus_notavailable.md), [LicenseIssue](packagestatus_licenseissue.md), [Modified](packagestatus_modified.md), [Tampered ](packagestatus_tampered.md) are not set.



## -examples

## -see-also
